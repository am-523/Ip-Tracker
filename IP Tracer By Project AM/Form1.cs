using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Tracer_By_Project_AM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFetchLocationDetails_Click(object sender, EventArgs e)
        {
            if (txtIPAddress.Text.Equals("") == false)
            {
                txtIPLocationResult.Text = FetchCurrentIpLocation(txtIPAddress.Text);
            }
        }


        private string FetchCurrentIpLocation()
        {
            string strIpLocation = string.Empty;

            var client = new RestClient("https://ipapi.co/json/");
            var request = new RestRequest()
            {
                Method = Method.GET
            };

            var response = client.Execute(request);

            var dictionary = JsonConvert.DeserializeObject<IDictionary>(response.Content);
            foreach (var key in dictionary.Keys)
            {
                strIpLocation += key.ToString() + ": " + dictionary[key] + "\r\n";
            }
            return strIpLocation;
        }

        //To Fetch Location of IP Address User Supplied
        private string FetchCurrentIpLocation(string strIP)
        {
            string strIpLocation = string.Empty;

            var client = new RestClient("https://ipapi.co/" + strIP + "/json/");
            var request = new RestRequest()
            {
                Method = Method.GET
            };

            var response = client.Execute(request);

            var dictionary = JsonConvert.DeserializeObject<IDictionary>(response.Content);
            foreach (var key in dictionary.Keys)
            {
                strIpLocation += key.ToString() + ": " + dictionary[key] + "\r\n";
            }
            return strIpLocation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
