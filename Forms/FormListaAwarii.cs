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
            cmbFiltr.DataSource = Enum.GetValues(typeof(StatusAwarii));
            cmbFiltr.SelectedIndex = -1;
            cmbFiltr.SelectedIndexChanged += cmbFiltr_SelectedIndexChanged;
        }

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

            var comboStatus = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
                Name = "Status",
                DataSource = Enum.GetValues(typeof(StatusAwarii)),
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                FlatStyle = FlatStyle.Flat,
                ReadOnly = false
            };
            dgvLista.Columns.Add(comboStatus);

            dgvLista.DataSource = listaAwarii;
        }
        private void btnZmienStatus_Click(object sender, EventArgs e)
        {
            dgvLista.EndEdit();
            var zarzadzanieDanymi = new ZarzadzanieDanymi(Config.Config.GetInstance().SciezkaPliku);
            zarzadzanieDanymi.Zapisz(listaAwarii);

            MessageBox.Show("Statusy zostały zaktualizowane.", "Zapisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cmbFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltr.SelectedItem == null)
                return;

            var wybranyStatus = (StatusAwarii)cmbFiltr.SelectedItem;

            var przefiltrowanaLista = listaAwarii
                .Where(a => a.Status == wybranyStatus)
                .ToList();

            dgvLista.DataSource = null;
            dgvLista.DataSource = przefiltrowanaLista;
        }

        private void btnClearFiltr_Click(object sender, EventArgs e)
        {
            cmbFiltr.SelectedIndex = -1;
            dgvLista.DataSource = null;
            dgvLista.DataSource = listaAwarii;
        }
    }
}

