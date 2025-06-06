using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZglaszanieAwariiApp.Models;
using ZglaszanieAwariiApp.Services;
using ZglaszanieAwariiApp.Config;

namespace ZglaszanieAwariiApp.Forms
{
    public partial class FormListaAwarii : Form
    {
        private List<Awarie> listaAwarii;

        public FormListaAwarii()
        {
            InitializeComponent();
        }

        private void FormListaAwarii_Load(object sender, EventArgs e)
        {
            WczytajDane();
            cmbFiltr.DataSource = Enum.GetValues(typeof(StatusAwarii)); // źródło danych dla filtra
            cmbFiltr.SelectedIndex = -1;
            cmbFiltr.SelectedIndexChanged += cmbFiltr_SelectedIndexChanged; // obsługę zmiany filtra
        }

        // Wczytuje dane awarii i ustawia kolumny w DataGridView
        private void WczytajDane()
        {
            var zarzadzanieDanymi = new ZarzadzanieDanymi(Config.Config.GetInstance().SciezkaPliku);
            listaAwarii = zarzadzanieDanymi.Wczytaj();
            dgvLista.Columns.Clear();

            dgvLista.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                ReadOnly = true
            });

            dgvLista.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Opis",
                HeaderText = "Opis",
                ReadOnly = true
            });

            dgvLista.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Kategoria",
                HeaderText = "Kategoria",
                ReadOnly = true
            });

            dgvLista.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataZgloszenia",
                HeaderText = "Data zgłoszenia",
                ReadOnly = true
            });
            // Kolumna z rozwijanym wyborem statusu
            var comboStatus = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
                Name = "Status",
                DataSource = Enum.GetValues(typeof(StatusAwarii)),
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                FlatStyle = FlatStyle.Flat,
                ReadOnly = false // Możliwość edytowania, pozostałe zablokowane
            };
            dgvLista.Columns.Add(comboStatus);

            dgvLista.DataSource = listaAwarii; // Przypisanie danych do wyświetlenia w liście
        }
        // Obsługa kliknięcia przycisku + zapisanie danych do pliku json
        private void btnZmienStatus_Click(object sender, EventArgs e)
        {
            dgvLista.EndEdit(); // Zakończenie edycji komórki 
            var zarzadzanieDanymi = new ZarzadzanieDanymi(Config.Config.GetInstance().SciezkaPliku);
            zarzadzanieDanymi.Zapisz(listaAwarii);

            MessageBox.Show("Statusy zostały zaktualizowane.", "Zapisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Obsługuje zmianę wybranego statusu w filtrze — filtruje dane
        private void cmbFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltr.SelectedItem == null)
                return;

            var wybranyStatus = (StatusAwarii)cmbFiltr.SelectedItem;

            var przefiltrowanaLista = listaAwarii
                .Where(a => a.Status == wybranyStatus)
                .ToList();

            dgvLista.DataSource = null;
            dgvLista.DataSource = przefiltrowanaLista; // Przypisanie przefiltrowanych danych
        }
        // Obsługuje kliknięcie przycisku — resetuje widok do pełnej listy
        private void btnClearFiltr_Click(object sender, EventArgs e)
        {
            cmbFiltr.SelectedIndex = -1; // reset filtrów
            WczytajDane(); // odświeżenie danych
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

