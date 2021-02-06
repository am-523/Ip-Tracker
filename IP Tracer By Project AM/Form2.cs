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

namespace IP_Tracer_By_Project_AM
{
    public partial class Form2 : Form
    {
        GeoIP test = new GeoIP();
        public Form2()
        {
            InitializeComponent();
        }

        public class GeoIP
        {
            public IPAddress IP;
            public string Country;
            public string City;
            public float Latitude = 361;
            public float Longitude = 361;

            public void GetLocation()
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.hostip.info/get_html.php?position=true&ip=" + IP);
                request.Method = "GET";
                WebResponse response = request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8);
                Country = sr.ReadLine().Substring(9);
                City = sr.ReadLine().Substring(6);
                sr.ReadLine();
                try
                {
                    Latitude = float.Parse(sr.ReadLine().Substring(10));   // substrings to skip the "Latitude: "
                    Longitude = float.Parse(sr.ReadLine().Substring(11));  // and "Longitude: "
                }
                catch
                {
                };
                sr.Close();
                response.Close();
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                test.IP = IPAddress.Parse(txtIP.Text);
                test.GetLocation();
                lblCity.Text = "City: " + test.City;
                lblCountry.Text = "Country: " + test.Country;
                lblLatitude.Text = "Latitude: " + test.Latitude;
                lblLongitude.Text = "Longitude: " + test.Longitude;
                if (test.Longitude != 361)
                {
                    float xplot = ((float)imgMap.Width / 360) * (180 + test.Longitude);
                    float yplot = ((float)imgMap.Height / 180) * (90 - test.Latitude);
                    System.Drawing.Pen myPen;
                    myPen = new System.Drawing.Pen(System.Drawing.Color.White, 1);
                    System.Drawing.Graphics formGraphics = imgMap.CreateGraphics();
                    imgMap.Refresh();
                    formGraphics.DrawLine(myPen, xplot, 0, xplot, imgMap.Height);
                    formGraphics.DrawLine(myPen, 0, yplot, imgMap.Width, yplot);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }
    }
    }

