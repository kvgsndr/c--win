using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace chat
{
    public partial class Form1 : Form //KLIENS
    {
        public Socket kapcs; //a kapcsolatot tartó socket
        byte[] vett = new byte[1024];//ide pakolja a vett byteokat
        int vett_db;//ennyi darabot vett
        int statusztar;//a kapcsolat státusza 0:hívhatsz, 1:kapcsolódom, 2:kapcsolatban, 3:adat jött

        public Form1()
        {
            InitializeComponent();
            statusztar = 0;
        }

        private void felhiv_Click(object sender, EventArgs e)
        {//felhív valakit
            try
            {
                Byte[] ab = new Byte[4];
                IPEndPoint ipe = null;
                IPAddress ipa = IPAddress.Parse(sIP_cim.Text);//nem vizsgál
                ipe = new IPEndPoint(ipa, 65500);
                kapcs = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                kapcs.BeginConnect(ipe, new AsyncCallback(DoConnect), kapcs);//kezdi építeni a kapcsolatot
                statusztar = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TCP/IP HIBA 1");
            }
        }

        private void DoConnect(IAsyncResult ar)
        {//sikerült a TCP/IP kapcsolat
            try
            {
                Socket s = (Socket)ar.AsyncState;
                s.EndConnect(ar);
                s.BeginReceive(vett, 0, 1024, SocketFlags.None, new AsyncCallback(DoDatajott), s);//vételi állapot
                statusztar = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TCP/IP HIBA 2");
            }
        }

        void DoDatajott(IAsyncResult ar)
        {//jött a partnertől egy adat
            try
            {
                SocketError errk;
                Socket s = (Socket)ar.AsyncState;
                vett_db = s.EndReceive(ar, out errk);
                if (errk == SocketError.Success)
                {//sikeres vétel
                    if (vett_db > 0)
                        statusztar = 3;//adat a bufferben
                    else
                    {//a semmi jött sikeresen általában kapcsolatszakadást jelent
                        statusztar = 0;
                        throw new Exception("Semmi jött!");
                    }
                }
                else
                {//sikertelen vétel
                    statusztar = 0;
                    throw new Exception("Hibát adott az endreceive!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TCP/IP HIBA 3");
            }
        }

        private void onenter(object sender, KeyPressEventArgs e)
        {//enter az üzenet sávban
            if (e.KeyChar == '\r')
            {
                TcpKuld(uzenet.Text);
                dumalista.Items.Add("<-- " + uzenet.Text);
                uzenet.Text = "";
            }
        }

        private void TcpKuld(string mit)
        {//adat küldése TCP/IP-n a kliensnek
            try
            {
                byte[] Buffer = Encoding.UTF8.GetBytes(mit);
                kapcs.Send(Buffer, Buffer.Length, SocketFlags.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TCP/IP HIBA 4");
            }
        }

        private void kuld_Click(object sender, EventArgs e)
        {//küld gomb
            TcpKuld(uzenet.Text);
            dumalista.Items.Add("<-- " + uzenet.Text);
            uzenet.Text = "";
        }

        private void bont_Click(object sender, EventArgs e)
        {//bontja a kapcsolatot
            if (kapcs.Connected)
                kapcs.Disconnect(false);
            statusztar = 0;
        }

        private void idovan(object sender, EventArgs e)
        {//100 ms-es óra az asszinkron vétel miatt
            switch (statusztar)
            {
                case 0://alap
                    status.Text = "Hívhatsz !";
                    felhiv.Visible = true;
                    bont.Visible = false;
                    kuld.Visible = false;
                    dumalista.Visible = false;
                    uzenetduma.Visible = false;
                    uzenet.Visible = false;
                    dumalista.Items.Clear();
                    break;
                case 1://kapcsolódik (ez csak rövid ideig lehet)
                    status.Text = "kapcsolódom !";
                    break;
                case 2://kapcsolatban
                    status.Text = "KAPCSOLATBAN";
                    felhiv.Visible = false;
                    bont.Visible = true;
                    kuld.Visible = true;
                    dumalista.Visible = true;
                    uzenetduma.Visible = true;
                    uzenet.Visible = true;
                    break;
                case 3://adat jött
                    string tar;
                    tar = Encoding.UTF8.GetString(vett, 0, vett_db);
                    dumalista.Items.Add("--> " + tar);
                    statusztar = 2;//én állok vissza kapcsolatbanra
                    kapcs.BeginReceive(vett, 0, 1024, SocketFlags.None, new AsyncCallback(DoDatajott), kapcs);
                    break;
            }
        }
    }
}
