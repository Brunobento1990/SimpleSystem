using Newtonsoft.Json;
using SimpleSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSystem.Forms
{
    
    public partial class frmRepresentante : Form
    {
        clsMenssage msg = new clsMenssage();
        bool VerificaSeEstaAlterando = true;
        public frmRepresentante()
        {
            InitializeComponent();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void BloquearCampo()
        {
            txtnome.Enabled = false;
            txtcpf.Enabled = false;
            txtrg.Enabled = false;
            txtdatanascimento.Enabled = false;
            txttelefone.Enabled = false;
            txtemail.Enabled = false;
            txtobs.Enabled = false;
            txtcep.Enabled = false;
            btncancelar.Enabled = false;
            btnsalvar.Enabled = false;
            btnsair.Enabled = true;
            btnexcluir.Enabled = true;
            btnincluir.Enabled = true;
            btnpesquisarcep.Enabled = false;
            txtlogradouro.Enabled = false;
            txtbairro.Enabled = false;
            txtuf.Enabled = false;
            txtrua.Enabled = false;
            txtnumero.Enabled = false;
            txtcomplemento.Enabled = false;
            txtpais.Enabled = false;
            btnalterar.Enabled = true;
        }
        private void LiberarCampo()
        {
            txtnome.Enabled = true;
            txtcpf.Enabled = true;
            txtrg.Enabled = true;
            txtdatanascimento.Enabled = true;
            txttelefone.Enabled = true;
            txtemail.Enabled = true;
            txtobs.Enabled = true;
            txtcep.Enabled = true;
            btncancelar.Enabled = true;
            btnsalvar.Enabled = true;
            btnsair.Enabled = false;
            btnexcluir.Enabled = false;
            btnincluir.Enabled = false;
            btnpesquisarcep.Enabled = true;
            btnalterar.Enabled = false;
        }
        private void btnpesquisarcep_Click(object sender, EventArgs e)
        {
            var strCep = string.Format("https://viacep.com.br/ws/{0}/json/", txtcep.Text);
            if (string.IsNullOrWhiteSpace(txtcep.Text))
            {
                string texto = "Senhor usuário, informe um CEP Válido.";
                msg.Alerta(texto);
                return;
            }
            else
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var respost = client.GetAsync(strCep).Result;
                        if (respost.IsSuccessStatusCode)
                        {
                            var resultado = respost.Content.ReadAsStringAsync().Result;
                            clsRepresentante representante = JsonConvert.DeserializeObject<clsRepresentante>(resultado);
                            txtlogradouro.Text = representante.Localidade;
                            txtbairro.Text = representante.Bairro;
                            txtuf.Text = representante.Uf;
                            txtrua.Text = representante.Logradouro;
                            txtcomplemento.Text = representante.Complemento;
                            txtlogradouro.Enabled = true;
                            txtbairro.Enabled = true;
                            txtuf.Enabled = true;
                            txtrua.Enabled = true;
                            txtnumero.Enabled = true;
                            txtcomplemento.Enabled = true;
                            txtpais.Enabled = true;
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Sr usuário, não foi encontrado o Cep informado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            LiberarCampo();
            tabControl1.SelectedTab = tabPage2;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            BloquearCampo();
            tabControl1.SelectedTab = tabPage1;
            return;
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (VerificaSeEstaAlterando)
            {
                GravarRepresentante();
            }
            else
            {
                Alterar();
            }

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            var representante = new clsRepresentante();
            var result = msg.Excluir("Senhor usuário, esta operação irá desativar o representante, deseja continuar?");
            if (result)
            {
                if (tabControl1.SelectedTab == tabPage2)
                {
                    representante = representante.AcharRepresentantePorId(Int32.Parse(txtcodigo.Text));
                    if (representante != null)
                    {
                        representante.Excluir(Int32.Parse(txtcodigo.Text), representante);
                    }
                }
                else
                {
                    PegarDadosGrid();
                    tabControl1.SelectedTab = tabPage2;
                    representante = representante.AcharRepresentantePorId(Int32.Parse(txtcodigo.Text));
                    if (representante != null)
                    {
                        representante.Excluir(Int32.Parse(txtcodigo.Text), representante);
                    }
                }
            }
            else
            {
                BloquearCampo();
                tabControl1.SelectedTab = tabPage1;
            }
            
        }

        private void frmRepresentante_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'simpleSystemDataSet1.Representante'. Você pode movê-la ou removê-la conforme necessário.
            this.representanteTableAdapter.Fill(this.simpleSystemDataSet1.Representante);

        }
        private void GravarRepresentante()
        {
            if (string.IsNullOrWhiteSpace(txtnome.Text))
            {
                msg.Alerta("Senhor usuário, informe o nome do representante!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtpais.Text))
            {
                msg.Alerta("Senhor usuário, informe o país do representante!");
                return;
            }
            var representante = new clsRepresentante();
            representante.Nome = txtnome.Text;
            representante.Rg = txtrg.Text;
            representante.Telefone = txttelefone.Text;
            representante.Data_Nascimento = txtdatanascimento.Text;
            representante.Email = txtemail.Text;
            representante.Obs = txtobs.Text;
            representante.Pais = txtpais.Text;
            representante.Numero = txtnumero.Text;
            representante.Cep = txtcep.Text;
            representante.Ativo = "1";
            representante.Localidade = txtlogradouro.Text;
            representante.Bairro = txtbairro.Text;
            representante.Uf = txtuf.Text;
            representante.Logradouro = txtrua.Text;
            representante.Complemento = txtcomplemento.Text;
            representante.Cpf = txtcep.Text;
            representante.Gravar();
            BloquearCampo();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                LiberarCampo();
                txtrua.Enabled = true;
                txtbairro.Enabled = true;
                txtlogradouro.Enabled = true;
                txtnumero.Enabled = true;
                txtpais.Enabled = true;
                txtuf.Enabled = true;
                txtcomplemento.Enabled = true;
            }
            else
            {
                PegarDadosGrid();
                tabControl1.SelectedTab = tabPage2;
                LiberarCampo();
                txtrua.Enabled = true;
                txtbairro.Enabled = true;
                txtlogradouro.Enabled = true;
                txtnumero.Enabled = true;
                txtpais.Enabled = true;
                txtuf.Enabled = true;
                txtcomplemento.Enabled = true;
            }

            VerificaSeEstaAlterando = false;
        }
        private void Alterar()
        {
            var representante = new clsRepresentante();
            representante = representante.AcharRepresentantePorId(Int32.Parse(txtcodigo.Text));
            representante.Nome = txtnome.Text;
            representante.Rg = txtrg.Text;
            representante.Telefone = txttelefone.Text;
            representante.Data_Nascimento = txtdatanascimento.Text;
            representante.Email = txtemail.Text;
            representante.Obs = txtobs.Text;
            representante.Pais = txtpais.Text;
            representante.Numero = txtnumero.Text;
            representante.Cep = txtcep.Text;
            representante.Localidade = txtlogradouro.Text;
            representante.Bairro = txtbairro.Text;
            representante.Uf = txtuf.Text;
            representante.Logradouro = txtrua.Text;
            representante.Complemento = txtcomplemento.Text;
            representante.Cpf = txtcep.Text;
            representante.Alterar(Int32.Parse(txtcodigo.Text));
            BloquearCampo();
        }

        private void representanteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void PegarDadosGrid()
        {
            var dataIndexNo = dataGridView1.CurrentCell.RowIndex;
            txtcodigo.Text = dataGridView1.Rows[dataIndexNo].Cells[0].Value.ToString();
            txtnome.Text = dataGridView1.Rows[dataIndexNo].Cells[1].Value.ToString();
            txtcpf.Text = dataGridView1.Rows[dataIndexNo].Cells[2].Value.ToString();
            txtnumero.Text = dataGridView1.Rows[dataIndexNo].Cells[3].Value.ToString();
            txttelefone.Text = dataGridView1.Rows[dataIndexNo].Cells[4].Value.ToString();
            txtemail.Text = dataGridView1.Rows[dataIndexNo].Cells[5].Value.ToString();
            txtdatanascimento.Text = dataGridView1.Rows[dataIndexNo].Cells[6].Value.ToString();
            txtrg.Text = dataGridView1.Rows[dataIndexNo].Cells[7].Value.ToString();
            txtobs.Text = dataGridView1.Rows[dataIndexNo].Cells[8].Value.ToString();
            txtpais.Text = dataGridView1.Rows[dataIndexNo].Cells[9].Value.ToString();
            txtcep.Text = dataGridView1.Rows[dataIndexNo].Cells[10].Value.ToString();
            txtrua.Text = dataGridView1.Rows[dataIndexNo].Cells[11].Value.ToString();
            txtcomplemento.Text = dataGridView1.Rows[dataIndexNo].Cells[12].Value.ToString();
            txtbairro.Text = dataGridView1.Rows[dataIndexNo].Cells[13].Value.ToString();
            txtlogradouro.Text = dataGridView1.Rows[dataIndexNo].Cells[14].Value.ToString();
            txtuf.Text = dataGridView1.Rows[dataIndexNo].Cells[15].Value.ToString();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var dataIndexNo = dataGridView1.Rows[e.RowIndex].Index.ToString(); 
            txtcodigo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcpf.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtnumero.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txttelefone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtdatanascimento.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtrg.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtobs.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtpais.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtcep.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtrua.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtcomplemento.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtbairro.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtlogradouro.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            txtuf.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            tabControl1.SelectedTab = tabPage2;
        }
    }
}
