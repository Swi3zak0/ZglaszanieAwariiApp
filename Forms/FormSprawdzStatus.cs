using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZglaszanieAwariiApp.Services;
using ZglaszanieAwariiApp.Config;


namespace ZglaszanieAwariiApp.Forms
{
    public partial class FormSprawdzStatus : Form
    {
        public FormSprawdzStatus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Obsługa przycisku - wyszukiwanie awarii, w razie problemów errory
        private void btnSprawdz_Click(object sender, EventArgs e)
        {
            lblWynik.Text = "";

            // Sprawdzenie poprawności wprowadzonego ID - musi być int
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Wprowadź poprawny numer ID.");
                return;
            }
            // Wczytanie listy awarii z pliku konfiguracyjnego
            var dane = new ZarzadzanieDanymi(Config.Config.GetInstance().SciezkaPliku);
            var lista = dane.Wczytaj();
            // Wyszukanie awarii o podanym ID
            var awaria = lista.FirstOrDefault(a => a.Id == id);

            // Wyświetlanie wyniku do label
            if (awaria != null)
            {
                lblWynik.Text = $"Status: {awaria.Status}\n" +
                    $"Opis: {awaria.Opis}";
            }
            // Warunek w razie nieznalezienia id
            else
            {
                lblWynik.Text = $"Nie znaleziono awarii o ID {id}.";
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
