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
                // Sprawdzanie czy wszystkie pola zostały wypełnione
                if (string.IsNullOrWhiteSpace(txtOpis.Text) || string.IsNullOrWhiteSpace(cmbKategoria.Text) || string.IsNullOrWhiteSpace(txtUzytkownik.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Wszystkie pola muszą być wypełnione.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Sprawdzenie czy email został wprowadzony w poprawnym formacie
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Podaj poprawny adres e-mail.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Sprawdzanie czy dodatkowe informacje odnosnie budynku i piętra zostały wprowadzone
                if (string.IsNullOrWhiteSpace(txtNumerBudynku.Text) || string.IsNullOrWhiteSpace(txtPietro.Text))
                {
                    MessageBox.Show("Uzupełnij numer budynku i piętro.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Tworzenie obiektu awarii na podstawie danych z formularza
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
                // Wczytanie danych, przypisanie ID, dodanie nowej awarii i zapis do pliku
                var dane = new ZarzadzanieDanymi(Config.Config.GetInstance().SciezkaPliku);
                var lista = dane.Wczytaj();
                awaria.Id = lista.Count + 1;
                awaria.DataZgloszenia = DateTime.Now;
                lista.Add(awaria);
                dane.Zapisz(lista);

                MessageBox.Show("Awaria zgłoszona!");
                // Czyszczenie pól formularza po dodaniu zgłoszenia
                txtOpis.Clear();
                txtUzytkownik.Clear();
                txtEmail.Clear();
                txtPietro.Clear();
                txtNumerBudynku.Clear();
                cmbKategoria.SelectedIndex = -1;
            }
            // Wyłapywanie errorów
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
                    // Wypełnienie listy rozwijanej z kategoriami - na sztywno
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
