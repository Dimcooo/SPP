using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace WnfrmJsn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Translate()
        {
            try
            {
                var client = new Transl.TranslClient("NetTcpBinding_ITransl");
                textBox2.Text = client.ReadJson(textBox1.Text);

                WeatherCl weatherCl = JsonConvert.DeserializeObject<WeatherCl>(textBox2.Text);

                textBox3.Text = "Country: " + weatherCl.Country + Environment.NewLine +
                                "City: " + weatherCl.Name + Environment.NewLine +
                                "Temperature: " + weatherCl.Temp + Environment.NewLine +
                                "Description: " + weatherCl.Descriprion;

                client.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Translate();
        }
    }

    public partial class WeatherCl
    {
        [JsonProperty("descriprion")]
        public string Descriprion { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("temp")]
        public double Temp { get; set; }
    }
}
