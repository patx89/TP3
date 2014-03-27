using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;

namespace Client
{
    public partial class ClientTCP : Form
    {
        public ClientTCP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient tcpclnt = new TcpClient();
                Console.WriteLine("Connecting.....");

                tcpclnt.Connect("127.0.0.1", 8001); // use the ipaddress as in the server program

                Console.WriteLine("Connected");
                Console.Write("Enter the string to be transmitted : ");

                String str = this.textBox1.Text;
                Stream stm = tcpclnt.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                Console.WriteLine("Transmitting.....");

                stm.Write(ba, 0, ba.Length);

                byte[] bb = new byte[100];
                int k = stm.Read(bb, 0, 100);

                String output = "";

                for (int i = 0; i < k; i++)
                    output += Convert.ToChar(bb[i]);

                this.textBox2.Text = output;
                tcpclnt.Close();
            }

            catch (Exception ey)
            {
                Console.WriteLine("Error..... " + ey.StackTrace);
            }
        }
    }
}
