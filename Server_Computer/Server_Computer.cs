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
using System.Threading;
using System.IO;

namespace Server_Computer
{
    public partial class Server_Computer : Form
    {
        public Server_Computer()
        {
            InitializeComponent();
        }
        static public int portNumber;
        private void Server_Computer_Load(object sender, EventArgs e)
        {
            string host = Dns.GetHostName();
            IPHostEntry ip = Dns.GetHostByName(host);
            string ipAdresi = ip.AddressList[0].ToString();
            lblID.Text = ipAdresi;
        }
        ListenPorts lp;
        private void btn_Dinle_Click(object sender, EventArgs e)
        {

            portNumber = Convert.ToInt32(txt_Port.Text);
            timer1.Start();
            #region Port Atama İşlemi
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, portNumber);
            IPEndPoint ipPoint1 = new IPEndPoint(IPAddress.Any, (portNumber + 1));
            IPEndPoint[] ipPoints = new IPEndPoint[2] { ipPoint, ipPoint1 };
            #endregion
            #region Port Dinleme
            lp = new ListenPorts(ipPoints);
            #endregion
            txt_AlınanVeri.Items.Add("Dinleniyor...");
            #region Thread Çalıştırma
            lp.beginListen();
            #endregion
            
        }

        private void btn_Durdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            txt_AlınanVeri.Items.Add("Server Durduruldu...");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ListenPorts.aaaaa != null)
            {
                txt_AlınanVeri.Items.Add(ListenPorts.aaaaa);
                txt_AlınanVeri.Refresh();
            }
            else
                return;
        }
        
    }
}
