using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DSManager
{
    public partial class DSManager : Form
    {
        public DSManager()
        {
            InitializeComponent();
        }

        private void DSManager_Load(object sender, EventArgs e)
        {
            InitializeSQL();
            timer1.Enabled = true;
            ServerDataList.View = View.Details;
            ServerDataList.Columns.Add("Server Name",100, HorizontalAlignment.Left);
            ServerDataList.Columns.Add("Server IP", 100, HorizontalAlignment.Left);
            ServerDataList.Columns.Add("Server Port", 100, HorizontalAlignment.Left);
            ServerDataList.Columns.Add("Max Players", 100, HorizontalAlignment.Left);
            ServerDataList.Columns.Add("Server Status", 100, HorizontalAlignment.Left);
            ServerDataList.Columns.Add("Last Create Time", 100, HorizontalAlignment.Left);
        }

        private void InitializeSQL()
        {
            string IsStarted = "1";
            string post = "IsStarted=" + IsStarted;
            string url = "http://fullplugins.org/MultiServer/ResetServers.php";
            string method = "POST";
            string rc = "";

            rc = ProcessURL(url, method, post);
        }

        private void CheckCreateRequest()
        {
            string post = "1";
            string url = "http://fullplugins.org/MultiServer/GetHostRequest.php";
            string method = "POST";
            string rc = "";

            rc = ProcessURL(url, method, post);
            T_Return.Text = rc;
            if (rc.Length>0)
            {
                ServerDataList.Items.Add(rc);
            }

            string[] rcp = rc.Split(new char[1] {';'});

            foreach(string a in rcp)
            {
                switch (a)
                { 
                    case "Level1":
                        Process.Start(@"C:\Users\Administrator\Desktop\WindowsNoEditor\CarpetAR\Binaries\Win64\Level1");
                        break;
                    case "Level2":
                            Process.Start(@"C:\Users\Administrator\Desktop\WindowsNoEditor\CarpetAR\Binaries\Win64\Server2");
                            break;
                    case "Level3":
                        Process.Start(@"C:\Users\Administrator\Desktop\WindowsNoEditor\CarpetAR\Binaries\Win64\Level3");
                        break;
                    default:
                        break;
                }
            }

        }

        private string ProcessURL(string url, string method, string post)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] data = encoding.GetBytes(post);
            string rc = "";
            WebRequest request = WebRequest.Create(url);

            request.Timeout = 6000000;
            request.Method = method;
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);
            stream.Close();

            WebResponse response = request.GetResponse();
            stream = response.GetResponseStream();

            StreamReader sr = new StreamReader(stream);
            rc = sr.ReadToEnd();   

            return rc;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckCreateRequest();
        }

        private void DSManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            string IsStarted = "0";
            string post = "IsStarted=" + IsStarted;
            string url = "http://fullplugins.org/MultiServer/ResetServers.php";
            string method = "POST";
            string rc = "";

            rc = ProcessURL(url, method, post);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerDataList.Items.Add(T_Return.Text);
        }

        private void Client_Close_btn_Click(object sender, EventArgs e)
        {

        }

        private void Client_Close_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Server_Database_btn_Click(object sender, EventArgs e)
        {
          
    }
    }
}

