using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZglaszanieAwariiApp.Exceptions;
using ZglaszanieAwariiApp.Models;
using ZglaszanieAwariiApp.Services;

namespace ZglaszanieAwariiApp.Forms
{
    public partial class FormZgloszenie : Form
    {
        public FormZgloszenie()
        {
            InitializeComponent();
            cmbStatus.DataSource = Enum.GetValues(typeof(StatusAwarii));
            cmbStatus.SelectedItem = StatusAwarii.Nowe;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                var awaria = new Awarie
                {
                    Opis = txtOpis.Text,
                    Kategoria = txtKategoria.Text,
                    Status = (StatusAwarii)cmbStatus.SelectedItem,
                    Zglaszajacy = new Uzytkownik
                    {
                        Id = 1,
                        Imie = txtUzytkownik.Text,
                        Email = "brak@wp.pl"
                    }
                };

                var dane = new ZarzadzanieDanymi(Config.Config.GetInstance().SciezkaPliku);
                var lista = dane.Wczytaj();
                awaria.Id = lista.Count + 1;
                awaria.DataZgloszenia = DateTime.Now;
                lista.Add(awaria);
                dane.Zapisz(lista);

                MessageBox.Show("Awaria zgłoszona!");
                txtOpis.Clear();
                txtKategoria.Clear();
                txtUzytkownik.Clear();
                cmbStatus.SelectedItem = StatusAwarii.Nowe;
            }
            catch (AwarieException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
