using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZglaszanieAwariiApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        // Przeniesienie po kliknięciu do formularza Zgłaszania Awarii
        private void btnZglosAwarie_Click(object sender, EventArgs e)
        {
            {
                new FormZgloszenie().ShowDialog();
            }
        }
        // Przeniesienie po kliknięciu do formularza Wyświetlania Wszystkich Awarii
        private void btnListaAwarii_Click(object sender, EventArgs e)
        {
            {
                new FormListaAwarii().ShowDialog();
            }
        }
        // Przeniesienie po kliknięciu do formularza Sprawdzenia Statusu Awarii
        private void btnSprawdzStatus_Click(object sender, EventArgs e)
        {
            {
                new FormSprawdzStatus().ShowDialog();
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
