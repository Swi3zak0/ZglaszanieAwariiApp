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
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOpis.Text) || string.IsNullOrWhiteSpace(cmbKategoria.Text) || string.IsNullOrWhiteSpace(txtUzytkownik.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Wszystkie pola muszą być wypełnione.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Podaj poprawny adres e-mail.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNumerBudynku.Text) || string.IsNullOrWhiteSpace(txtPietro.Text))
                {
                    MessageBox.Show("Uzupełnij numer budynku i piętro.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var awaria = new Awarie
                {
                    Opis = txtOpis.Text,
                    Kategoria = cmbKategoria.SelectedItem.ToString(),
                    Status = StatusAwarii.Nowe,
                    Pietro = txtPietro.Text,
                    NumerBudynku = txtNumerBudynku.Text,
                    Zglaszajacy = new Uzytkownik
                    {
                        Id = 1,
                        Imie = txtUzytkownik.Text,
                        Email = txtEmail.Text,
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
                txtUzytkownik.Clear();
                txtEmail.Clear();
                txtPietro.Clear();
                txtNumerBudynku.Clear();
                cmbKategoria.SelectedIndex = -1;
            }
            catch (AwarieException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormZgloszenie_Load(object sender, EventArgs e)
        {
            cmbKategoria.Items.AddRange(new string[]
            {
                "Awaria sieci",
                "Problemy z komputerem",
                "Brak dostępu do Internetu",
                "Awaria drukarki",
                "Problem z aplikacją",
                "Błąd systemu operacyjnego",
                "Zgłoszenie nowego sprzętu",
                "Awaria poczty e-mail",
                "Zgłoszenie incydentu bezpieczeństwa",
                "Problem z dostępem do systemu",
                "Inne"
            });
        }
    }
}
