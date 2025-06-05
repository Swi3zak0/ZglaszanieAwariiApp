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

        private void btnSprawdz_Click(object sender, EventArgs e)
        {
            lblWynik.Text = "";

            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Wprowadź poprawny numer ID.");
                return;
            }

            var dane = new ZarzadzanieDanymi(Config.Config.GetInstance().SciezkaPliku);

            var lista = dane.Wczytaj();
            var awaria = lista.FirstOrDefault(a => a.Id == id);

            if (awaria != null)
            {
                lblWynik.Text = $"Status: {awaria.Status}\n" +
                    $"Opis: {awaria.Opis}";
            }
            else
            {
                lblWynik.Text = $"Nie znaleziono awarii o ID {id}.";
            }
        }
    }
}
