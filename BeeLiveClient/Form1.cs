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
            try
            {
                var seed = Convert.ToDecimal(random.NextDouble());
                var decibel = numericUpDownMin.Value + (seed * (numericUpDownMax.Value - numericUpDownMin.Value));
                var noiseData = new BeeLive.NoiseData.TransferModels.NoiseDataDto()
                {
                    HiveId = (int)numericUpDownHive.Value,
                    Decibel = decibel
                };
                var result = await client.PostAsJsonAsync(ConfigurationManager.AppSettings["NoiseDataUrl"], noiseData);
                if (result.IsSuccessStatusCode)
                {
                    textBoxValue.Text = decibel.ToString();
                }
                else
                {
                    textBoxValue.Text = $"ERROR {result.StatusCode.ToString()}";
                }

            }
            catch (Exception ex)
            {
                textBoxValue.Text = "EXCEPTION";
            }
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (timerNoise.Enabled)
            {
                timerNoise.Stop();
                buttonStartStop.Text = "Start";
            }
            else
            {
                timerNoise.Start();
                buttonStartStop.Text = "Stop";
            }
        }

        private async void timerHive_Tick(object sender, EventArgs e)
        {
            try
            {
                var hive = await client.GetFromJsonAsync<BeeLive.Hive.TransferModels.HiveDto>(ConfigurationManager.AppSettings["HiveUrl"] + "/" + ((int)numericUpDownHive.Value).ToString());
                if (hive == null)
                {
                    textBoxHiveNoise.Text = string.Empty;
                    panelColor.BackColor = Color.Transparent;
                }
                else
                {
                    textBoxHiveNoise.Text = hive.FormattedDecibel;
                    switch (hive.Status)
                    {
                        case BeeLive.Hive.TransferModels.HiveStatus.Ok:
                            panelColor.BackColor = Color.Green;
                            break;
                        case BeeLive.Hive.TransferModels.HiveStatus.Warning:
                            panelColor.BackColor = Color.Yellow;
                            break;
                        case BeeLive.Hive.TransferModels.HiveStatus.Alarm:
                            panelColor.BackColor = Color.Red;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                panelColor.BackColor = Color.Transparent;
                textBoxHiveNoise.Text = "EXCEPTION";
            }
        }

        private void buttonCheckStart_Click(object sender, EventArgs e)
        {
            if (timerHive.Enabled)
            {
                timerHive.Stop();
                buttonCheckStart.Text = "Start";
            }
            else
            {
                timerHive.Start();
                buttonCheckStart.Text = "Stop";
            }
        }
    }
}