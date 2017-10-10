using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace WebClientLb2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Translate()
        {
            try
            {
                var client = new Transl.TranslClient("NetTcpBinding_ITransl");
                TextBox2.Text = client.ReadJson(TextBox1.Text);

                WeatherCl weatherCl = JsonConvert.DeserializeObject<WeatherCl>(TextBox2.Text);

                TextBox3.Text = "Country: " + weatherCl.Country + ". " +
                                "City: " + weatherCl.Name + ". " +
                                "Temperature: " + weatherCl.Temp + ". " +
                                "Description: " + weatherCl.Descriprion;

                client.Close();
            }
            catch (Exception e)
            {
                TextBox2.Text = e.ToString();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Translate();
        }
    }
}