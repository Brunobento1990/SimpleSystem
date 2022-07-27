using SimpleSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSystem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            this.menuStrip1.Enabled = false;
            cliente.ShowDialog();
            this.menuStrip1.Enabled = true;
        }
    }
}
