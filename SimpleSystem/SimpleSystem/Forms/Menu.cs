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
            btnfrmcliente.Visible = false;
            cliente.ShowDialog();
            this.menuStrip1.Enabled = true;
            btnfrmcliente.Visible = true;
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnfrmcliente_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            btnfrmcliente.Visible = false;
            btnfrmrepresentante.Visible = false;
            cliente.ShowDialog();
            btnfrmcliente.Visible = true;
            btnfrmrepresentante.Visible = true;
        }

        private void btnfrmrepresentante_Click(object sender, EventArgs e)
        {
            var representante = new frmRepresentante();
            btnfrmcliente.Visible = false;
            btnfrmrepresentante.Visible = false;
            representante.ShowDialog();
            btnfrmcliente.Visible = true;
            btnfrmrepresentante.Visible = true;
        }

        private void cadastroDeRepresentanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var representante = new frmRepresentante();
            btnfrmcliente.Visible = false;
            btnfrmrepresentante.Visible = false;
            representante.ShowDialog();
            btnfrmcliente.Visible = true;
            btnfrmrepresentante.Visible = true;
        }
    }
}
