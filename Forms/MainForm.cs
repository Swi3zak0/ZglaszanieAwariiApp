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

        private void btnZglosAwarie_Click(object sender, EventArgs e)
        {
            {
                new FormZgloszenie().ShowDialog();
            }
        }

        private void btnListaAwarii_Click(object sender, EventArgs e)
        {
            {
                new FormListaAwarii().ShowDialog();
            }
        }

        private void btnSprawdzStatus_Click(object sender, EventArgs e)
        {
            {
                new FormSprawdzStatus().ShowDialog();
            }
        }
    }
}
