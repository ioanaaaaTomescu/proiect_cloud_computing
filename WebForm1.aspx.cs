using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace proiect_cloud_ioana_tomescu
{
    public partial class WebForm1 : System.Web.UI.Page

    {
    
        IFirebaseClient client;
        protected void Page_Load(object sender, EventArgs e) 
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "JanSAnPFCwRoSfP4FtyQhIuaibl3yj0ohId1zbxp",
                BasePath = "https://proiect-cloud-c2a96-default-rtdb.europe-west1.firebasedatabase.app/"
            };
            client = new FireSharp.FirebaseClient(config);

        }

        private async Task SaveDataToFirebaseAsync()
        {
            var data = new Data
            {
                cityJson = lblWeatherCity.Text,
                temperatureJson = lblTemperature.Text,
                temperatueMin = lblTempMin.Text,
                temperatureMax = lblTempMax.Text,
                humidity = lblHumidity.Text
            };

            SetResponse response = await client.SetTaskAsync("Orase/" + data.cityJson, data);
            Data result = response.ResultAs<Data>();
        }

        public async void btnSubmit_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;

            // Fetch weather data from OpenWeatherMap API
            string apiKey = "f5cbb4cc5be65002ffecf98ab55dea1e"; // Replace with your API key
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";
            if (city.Length == 0 || city == null)
            {
                lblWeatherCity.Text = "Te rog alege un oras!";
            }
            else
            {
                string weatherData = await GetWeatherData(apiUrl);
                string cityJson = getCityName(weatherData);
                double temperatureJson = getTemp(weatherData);
                double temperatueMin = getTempMin(weatherData);
                double temperatureMax = getTempMax(weatherData);
                int humidity = GetHumidity(weatherData);
                // Display weather data
                lblWeatherCity.Text = "Oras: " + cityJson;
                lblTemperature.Text = "Temperatura: " + temperatureJson.ToString();
                lblTempMin.Text = "Temperatura minima: " + temperatueMin.ToString();
                lblTempMax.Text = "Temperatura maxima: " + temperatureMax.ToString();
                lblHumidity.Text = "Umiditate: " + humidity.ToString();
                await SaveDataToFirebaseAsync();
                MessageBox.Show("Data inserted");
            }
        }

        private async Task<string> GetWeatherData(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
        }
        static double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        static double getTemp(string JsonString)
        {
            dynamic weatherData = new JavaScriptSerializer().DeserializeObject(JsonString);

            return KelvinToCelsius((double)weatherData["main"]["temp"]);

        }
        static double getTempMin(string JsonString)
        {
            dynamic weatherData = new JavaScriptSerializer().DeserializeObject(JsonString);

            return KelvinToCelsius((double)weatherData["main"]["temp_min"]);

        }

        static double getTempMax(string JsonString)
        {
            dynamic weatherData = new JavaScriptSerializer().DeserializeObject(JsonString);

            return KelvinToCelsius((double)weatherData["main"]["temp_max"]);

        }

        static int GetHumidity(string JsonString)
        {
            dynamic weatherData = new JavaScriptSerializer().DeserializeObject(JsonString);

            return weatherData["main"]["humidity"];
        }

        static string getCityName(string JsonString)
        {
            dynamic weatherData = new JavaScriptSerializer().DeserializeObject(JsonString);

            return weatherData["name"];
        }

        internal class Data
        {
            public string cityJson;
            public string temperatureJson { get; set; }
            public string temperatueMin { get; set; }
            public string temperatureMax { get; set; }
            public string humidity { get; set; }
        }

    }
}
