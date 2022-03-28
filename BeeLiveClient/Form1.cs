using System.Configuration;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace BeeLiveClient
{
    public partial class Form1 : Form
    {
        HttpClient client;
        Random random;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient()
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseUrl"])
            };
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            random = new Random(); 
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            var seed = Convert.ToDecimal(random.NextDouble());
            var decibel = numericUpDownMin.Value + (seed * (numericUpDownMax.Value - numericUpDownMin.Value));
            var noiseData = new BeeLive.NoiseData.TransferModels.NoiseDataDto()
            {
                HiveId = 1,
                Decibel = decibel
            };
            var result = await client.PostAsJsonAsync(ConfigurationManager.AppSettings["NoiseDataUrl"], noiseData);

        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                buttonStartStop.Text = "Start";
            }
            else
            {
                timer.Start();
                buttonStartStop.Text = "Stop";
            }
        }
    }
}