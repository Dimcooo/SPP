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

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new Transl.TranslClient("NetTcpBinding_ITransl");
            textBox2.Text = client.ReadJson(textBox1.Text);

        }
    }

    public class Weather
    {
        public string description { get; set; }
    }

    public class TemperatureInfo
    {
        public float Temp { get; set; }
    }

    public class Sys
    {
        public string country { get; set; }
    }

    public class WeatherResponse
    {
        public TemperatureInfo Main { get; set; }
        public Weather[] weather { get; set; }
        public int Dt { get; set; }
        public Sys Sys { get; set; }
        public string Name { get; set; }
    }
}
