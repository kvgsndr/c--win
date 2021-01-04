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

namespace chats
{
    public partial class Form1 : Form  //SERVER
    {
        Socket hallgat;//a hallgatózó socket
        Socket dolgozo = null;//a kapcsolatot tartó socket
        int statusztar;//a státusz 0:hívhatsz, 1:hallgatok, 2:kapcsolatban, 3:adat jött
        byte[] vett = new byte[1024];//a vételi buffer
        int vett_db;//ennyi darabot vett


        public Form1()
        {
            InitializeComponent();
            hallgat = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//csak létrehoz
            statusztar = 0;
        }

        private void hallgatba_Click(object sender, EventArgs e)
        {//menjünk hallgatóba
            try
            {
                IPEndPoint ipe = null;
                IPAddress[] ipa = Dns.GetHostAddresses("");
                for (int i = 0; i < ipa.Length; i++)//van-e jó IP4-es címem
                    if (ipa[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        ipe = new IPEndPoint(ipa[i], 65500);
                        break;
                    }
                if (ipe == null)
                {
                    MessageBox.Show("Nincs használható IP címem!", "TCP/IP HIBA");
                    return;
                }
                hallgat.Bind(ipe);//hozzárendel
                hallgat.Listen(2);//hallgatóba rak
                hallgat.BeginAccept(new AsyncCallback(DoClientjott), hallgat);//kezdi a hallgatást
                statusztar = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TCP/IP HIBA 1");
            }
        }

        private void DoClientjott(IAsyncResult ar)
        {//felhívtak
            try
            {
                Socket s = (Socket)ar.AsyncState;
                dolgozo = s.EndAccept(ar);//vettem
                dolgozo.BeginReceive(vett, 0, 1024, SocketFlags.None, new AsyncCallback(DoDatajott), dolgozo);//vételi állapot
                statusztar = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"TCP/IP HIBA 2");
            }
        }


        private void DoDatajott(IAsyncResult ar)
        {//jött a partnertől egy adat
            try
            {
                SocketError errk;
                Socket s = (Socket)ar.AsyncState;
                vett_db = s.EndReceive(ar, out errk);
                if (errk == SocketError.Success)
                {//sikeres vétel
                    if (vett_db > 0)
                        statusztar = 3;//vett adat ok
                    else
                    {//semmi jött ez bontást szokott jelenteni
                        statusztar = 1;
                        hallgat.BeginAccept(new AsyncCallback(DoClientjott), hallgat);
                        throw new Exception("Semmi jött!");
                    }
                }
                else
                {//vételi hiba
                    statusztar = 1;
                    hallgat.BeginAccept(new AsyncCallback(DoClientjott), hallgat);
                    throw new Exception("Hibát adott az endreceive!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TCP/IP HIBA 3");
            }
        }

        private void TcpKuld(string mit)
        {//adat küldése TCP/IP-n a kliensnek
            try
            {
                byte[] Buffer = Encoding.UTF8.GetBytes(mit);
                dolgozo.Send(Buffer, Buffer.Length, SocketFlags.None);
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

        private void dumaenter(object sender, KeyPressEventArgs e)
        {//enter a küldő boxban
            if (e.KeyChar == '\r')
            {
                TcpKuld(uzenet.Text);
                dumalista.Items.Add("<-- " + uzenet.Text);
                uzenet.Text = "";
            }
        }

        private void bont_Click(object sender, EventArgs e)
        {//bontja a kapcsolatot@@ez még nem jó
           if (dolgozo != null)
                if (dolgozo.Connected)
                    dolgozo.Disconnect(false);
           hallgat.BeginAccept(new AsyncCallback(DoClientjott), hallgat);
           statusztar = 1;
        }

        private void idovan(object sender, EventArgs e)
        {//100 ms-es timer az asszinkronitás miatt
            switch (statusztar)
            {
                case 0://alapállapot
                    status.Text = "Hallgatóba rakhatsz!";
                    hallgatba.Visible = true;
                    dumalista.Visible = false;
                    bont.Visible = false;
                    kuld.Visible = false;
                    uzenet.Visible = false;
                    uzenetduma.Visible = false;
                    break;
                case 1://hallgatóban vagyok
                    hallgatba.Visible = false;
                    dumalista.Visible = false;
                    bont.Visible = false;
                    kuld.Visible = false;
                    uzenet.Visible = false;
                    uzenetduma.Visible = false;
                    dumalista.Items.Clear();
                    status.Text = "HALLGATOK!";
                    break;
                case 2://kapcsolatban vagyok
                    hallgatba.Visible = false;
                    dumalista.Visible = true;
                    bont.Visible = true;
                    kuld.Visible = true;
                    uzenet.Visible = true;
                    uzenetduma.Visible = true;
                    status.Text = "KAPCSOLATBAN!!!";
                    break;
                case 3://adatjött
                    string tar;
                    tar = Encoding.UTF8.GetString(vett, 0, vett_db);
                    dumalista.Items.Add("--> " + tar);
                    dolgozo.BeginReceive(vett, 0, 1024, SocketFlags.None, new AsyncCallback(DoDatajott), dolgozo);
                    statusztar = 2;//én állítom vissza
                    break;
            }
        }
    }
}
