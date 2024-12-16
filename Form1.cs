using System.Net.Http;

namespace Slagboom_handmatig
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();

            // Koppel de events aan de handlers
            btnOpen_Clicks.Click += new EventHandler(btnOpen_Click);
            btnClose_Clicks.Click += new EventHandler(btnClose_Click);
        }

        // Event handler voor Open knop
        private async void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                // API-aanroep naar /api/Slagboom/open
                var response = await _httpClient.PostAsync("http://localhost:5001/api/Slagboom/open", null);
                if (response.IsSuccessStatusCode)
                {
                    // Update tekst in de UI
                    OpenofClose.Text = "De slagboom is geopend!";
                    OpenofClose.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show($"Fout bij het openen van de slagboom: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}");
            }
        }


        // Event handler voor Sluit knop
        private async void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                // API-aanroep naar /api/Slagboom/close
                var response = await _httpClient.PostAsync("http://localhost:5001/api/Slagboom/close", null);
                if (response.IsSuccessStatusCode)
                {
                    // Update tekst in de UI
                    OpenofClose.Text = "De slagboom is gesloten!";
                    OpenofClose.ForeColor = Color.Red;
                }
                else
                {
                    MessageBox.Show($"Fout bij het sluiten van de slagboom: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}");
            }
        }

    }
}
