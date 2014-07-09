using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace Server_Computer
{
    class ListenPorts
    {
        Socket[] scon;
        IPEndPoint[] ipPoints;
        public static List<string> list;
        public static List<string> gonder;
        public static string data1 = null;// providerde gelecek data
        public static string aaaaa;
        public static string bbbbb;
        static string Filename = @"D:\test.txt";


        static void WriteFile(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Append, FileAccess.Write);
            byte[] text = new UTF8Encoding(true).GetBytes(aaaaa);
            fs.Write(text, 0, text.Length);
            fs.Close();
            
            //if (fs.CanWrite)
            //{
            //    byte[] buffer = Encoding.ASCII.GetBytes(aaaaa);
            //    fs.Write(buffer, 0, buffer.Length);
            //}
            //fs.Flush();
            //fs.Close();
        }

        static void ReadFile(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);

            if (fs.CanRead)
            {
                int length = (int)fs.Length;
                byte[] buffer = new byte[length];
                int bytesread = fs.Read(buffer, 0, buffer.Length);
                bbbbb = Encoding.ASCII.GetString(buffer, 0, bytesread);
            }
            fs.Close();
        }

        # region Portları dinleme
        internal ListenPorts(IPEndPoint[] ipPoints)
        {
            this.ipPoints = ipPoints;
            scon = new Socket[ipPoints.Length];
        }
        #endregion
        public void beginListen()
        {
            for (int i = 0; i < ipPoints.Length; i++)
            {
                #region Serverde Portlar Açma
                scon[i] = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                scon[i].Bind(ipPoints[i]);
                #endregion
                // Queue a task.
                #region Thread Havuzu Oluşturma
                Thread[] theThreads = new Thread[5];
                for (int s = 0; s < 5; s++)
                {
                    theThreads[s] = new Thread(threadListen);
                }
                Thread thread = new Thread(threadListen);
                thread.Start(scon[i]);
                #endregion
            }
        }

        #region Thread Dinleme
        static public void threadListen(object objs)
        {
            data1 = null;
            list = new List<string>();
            Socket scon = objs as Socket;
            Server_Computer frm = new Server_Computer();
            byte[] data = new byte[10 * 2048];
            byte[] bytes = new Byte[10 * 2048];
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint Remote = (EndPoint)(sender);
        #endregion
            while (true)
            {
                try
                {

                    scon.Listen(100);//Bağlantının ne kadar sürede dinleneceği
                    Socket newSocket = scon.Accept();//gelen socket bağlantısının kabul edilmesi
                    string port = ((IPEndPoint)newSocket.LocalEndPoint).Port.ToString();//gelen bağlantılarının port numarasının okuması
                    #region Port Yonlendirme
                    if (port == Convert.ToString(Server_Computer.portNumber))
                    {
                        frm.txt_AlınanVeri.Items.Add("I am connected to " + IPAddress.Parse(((IPEndPoint)newSocket.RemoteEndPoint).Address.ToString()) + "on port number " + ((IPEndPoint)newSocket.RemoteEndPoint).Port.ToString());//Providerden gelen socketlerin başka soketlere aktırımı
                        frm.txt_AlınanVeri.Items.Add("My local IpAddress is :" + IPAddress.Parse(((IPEndPoint)newSocket.LocalEndPoint).Address.ToString()) + " I am connected on port number " + ((IPEndPoint)newSocket.LocalEndPoint).Port.ToString());//Provider Ip Adresini ve Portunun yazdırılması

                        while (true)
                        {
                            #region Providerden Veri Okuma
                            data1 = null;
                            bytes = new byte[10 * 2048];
                            int bytesRec = newSocket.Receive(bytes);

                            data1 += Encoding.ASCII.GetString(bytes, 0, bytesRec);

                            if (data.Length > -1)
                            {
                                break;
                            }

                            #endregion
                        }
                        list.Add(data1);//okunan datayı liste aktarma
                        aaaaa = (data1).ToString();
                        WriteFile(Filename);
                    }
                    else if (port == Convert.ToString(Server_Computer.portNumber + 1))//Client portunun ayarlanması
                    {
                        Console.WriteLine("I am connected to " + IPAddress.Parse(((IPEndPoint)newSocket.RemoteEndPoint).Address.ToString()) + "on port number " + ((IPEndPoint)newSocket.RemoteEndPoint).Port.ToString());
                        Console.WriteLine("My local IpAddress is :" + IPAddress.Parse(((IPEndPoint)newSocket.LocalEndPoint).Address.ToString()) + " I am connected on port number " + ((IPEndPoint)newSocket.LocalEndPoint).Port.ToString());// Client Ip Adresini ve Portunun yazdırılması
                        ReadFile(Filename);
                        #region string -> byte Cevirme
                        byte[] dataAsBytes;
                        dataAsBytes = new Byte[10 * 2048];
                        dataAsBytes = Encoding.ASCII.GetBytes(bbbbb);
                        #endregion

                        newSocket.Send(dataAsBytes);// Cliente datayı gönderme
                        
                    }
                }
                    #endregion
                catch (SocketException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                ;
            }
        }
    }
}
