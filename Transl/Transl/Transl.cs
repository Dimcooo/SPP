using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.Web.Helpers;
using System.Threading.Tasks;
using System.Threading;

namespace Transl
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Transl" в коде и файле конфигурации.
    public class Transl : ITransl
    {
        public string response, answer;

        public Task Trnslt(string city)
        {
            return Task.Run(() =>
            {
                string url = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=f69b60cbb2e403ce6f6da145b9e974ef";

                HttpWebRequest httpWebRequesr = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse httpWebResponce = (HttpWebResponse)httpWebRequesr.GetResponse();

                using (StreamReader streamReader = new StreamReader(httpWebResponce.GetResponseStream()))
                {
                    response = streamReader.ReadToEnd();
                    ThreadPool.QueueUserWorkItem(SerializRezThread);
                    Thread.Sleep(1000);
                }

            });
        }

        public void SerializRezThread(object state)
        {
            WeatherResponse weatherResponce = JsonConvert.DeserializeObject<WeatherResponse>(response);

            SerialJson Ser = new SerialJson();
            Ser.descriprion = weatherResponce.weather[0].description;
            Ser.temp = weatherResponce.Main.Temp;
            Ser.country = weatherResponce.Sys.country;
            Ser.name = weatherResponce.Name;

            DataContractJsonSerializer jsonFormart = new DataContractJsonSerializer(typeof(SerialJson));

            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                jsonFormart.WriteObject(fs, Ser);
            }

            StreamReader f = new StreamReader("people.json");
            answer = f.ReadLine();
            f.Close();
            File.Delete("people.json");
        }

        public async Task<string> ReadJson(string city)
        {
            await Trnslt(city);

            return answer;
        }

        [DataContract]
        public class SerialJson
        {
            [DataMember]
            public string descriprion { get; set; }

            [DataMember]
            public float temp { get; set; }

            [DataMember]
            public string country { get; set; }

            [DataMember]
            public string name { get; set; }
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
            public Sys Sys { get; set; }
            public string Name { get; set; }
        }

    }
}
