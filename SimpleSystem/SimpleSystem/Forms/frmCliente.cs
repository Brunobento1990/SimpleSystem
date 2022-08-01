using Newtonsoft.Json;
using SimpleSystem.Classe;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSystem.Forms
{
    public partial class frmCliente : Form
    {
        clsMenssage msg = new clsMenssage();
        bool VerificaAlterar = true;
        public frmCliente()
        {
            InitializeComponent();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            LiberarCampo();
            tabControl1.SelectedTab = tabPage2;
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
            checkfisica.Enabled = false;
            checkjuridica.Enabled = false;
            btnpesquisarcep.Enabled = false;
            txtlogradouro.Enabled = false;
            txtbairro.Enabled = false;
            txtuf.Enabled = false;
            txtrua.Enabled = false;
            txtnumero.Enabled = false;
            txtcomplemento.Enabled = false;
            txtpais.Enabled = false;
            txtcnpj.Enabled = false;
            comboBox1.Enabled = false;
            btnalterar.Enabled = true;
            checkjuridica.Enabled = false;
            checkfisica.Enabled = false;
        }
        private void LiberarCampo()
        {
            if (!string.IsNullOrWhiteSpace(txtcodigo.Text))
            {
                txtcodigo.Text = string.Empty;
                txtnome.Text = string.Empty;
                txtcpf.Text = string.Empty;
                txtcnpj.Text = string.Empty;
                txtrg.Text = string.Empty;
                txtdatanascimento.Text = string.Empty;
                txttelefone.Text = string.Empty;
                txtemail.Text = string.Empty;
                txtobs.Text = string.Empty;
                txtcep.Text = string.Empty;
                txtlogradouro.Text = string.Empty;
                txtbairro.Text = string.Empty;
                txtuf.Text = string.Empty;
                txtrua.Text = string.Empty;
                txtnumero.Text = string.Empty;
                txtcomplemento.Text = string.Empty;
                txtpais.Text = string.Empty;
                checkfisica.Checked = false;
                checkjuridica.Checked = false;
            }
            txtnome.Enabled = true;
            txtcpf.Enabled = true;
            txtcnpj.Enabled = true;
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
            checkfisica.Enabled = true;
            checkjuridica.Enabled = true;
            btnpesquisarcep.Enabled = true;
            comboBox1.Enabled = true;
            btnalterar.Enabled = false;
        }

        private void checkfisica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkfisica.Checked == true)
            {
                
                txtcpf.Visible = true;
                labelcpf.Text = "CPF";
                checkjuridica.Enabled = false;
                txtcnpj.Visible = false;
                checkjuridica.Checked = false;
            }
            else
            {
                checkjuridica.Enabled = true;
            }

        }

        private void checkjuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkjuridica.Checked == true)
            {
                
                txtcpf.Visible = false;
                labelcpf.Text = "CNPJ";
                checkfisica.Enabled = false;
                checkfisica.Checked = false;
                txtcnpj.Visible = true;
            }
            else
            {
                checkfisica.Enabled = true;
                //txtcnpj.Enabled = true;
            }

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (VerificaAlterar)
            {
                Gravar();
            }
            else
            {
                Alterar();
            }
        }
        private void Alterar()
        {
            var cliente = new clsCliente();
            cliente = cliente.AcharClientePorID(Int32.Parse(txtcodigo.Text));
            cliente.Nome = txtnome.Text;
            cliente.Rg = txtrg.Text;
            cliente.Telefone = txttelefone.Text;
            cliente.Data_Nascimento = txtdatanascimento.Text;
            cliente.Email = txtemail.Text;
            cliente.Obs = txtobs.Text;
            cliente.Pais = txtpais.Text;
            cliente.Numero = txtnumero.Text;
            cliente.Cep = txtcep.Text;
            cliente.Localidade = txtlogradouro.Text;
            cliente.Bairro = txtbairro.Text;
            cliente.Uf = txtuf.Text;
            cliente.Logradouro = txtrua.Text;
            cliente.Complemento = txtcomplemento.Text;
            
            if (checkfisica.Checked == true)
            {
                cliente.Tipo_Pessoa = "Fisica";
                cliente.Cpf = txtcpf.Text;
            }
            else
            {
                cliente.Tipo_Pessoa = "Jurídica";
                cliente.Cpf = txtcnpj.Text;
            }
            cliente.Id_Reprasentante = (int)comboBox1.SelectedValue;
            cliente.Alterar(Int32.Parse(txtcodigo.Text));
            BloquearCampo();
        }
        private void Gravar()
        {
            if (string.IsNullOrWhiteSpace(txtnome.Text))
            {
                string texto = "Senhor usuário, informe o nome do cliente.";
                msg.Alerta(texto);
                return;
            }
            if (checkfisica.Checked == false && checkjuridica.Checked == false)
            {
                string texto = "Senhor usuário, informe se o cliente é Jurídico ou Fisico.";
                msg.Alerta(texto);
                return;
            }
            if (txtcpf.TextLength < 14)
            {
                string texto = "Senhor usuário, informe um CPF válido.";
                msg.Alerta(texto);
                return;
            }

            clsCliente cliente1 = new clsCliente();
            cliente1.Nome = txtnome.Text;
            if (checkfisica.Checked == true)
            {
                cliente1.Cpf = txtcpf.Text;
            }
            else
            {
                cliente1.Cpf = txtcnpj.Text;
            }
            cliente1.Rg = txtrg.Text;
            cliente1.Telefone = txttelefone.Text;
            cliente1.Data_Nascimento = txtdatanascimento.Text;
            cliente1.Email = txtemail.Text;
            cliente1.Obs = txtobs.Text;
            cliente1.Pais = txtpais.Text;
            cliente1.Numero = txtnumero.Text;

            if (checkfisica.Checked == true)
            {
                cliente1.Tipo_Pessoa = "Fisica";
            }
            else
            {
                cliente1.Tipo_Pessoa = "Jurídica";
            }
            cliente1.Cep = txtcep.Text;
            cliente1.Ativo = true;
            cliente1.Localidade = txtlogradouro.Text;
            cliente1.Bairro = txtbairro.Text;
            cliente1.Uf = txtuf.Text;
            cliente1.Logradouro = txtrua.Text;
            cliente1.Complemento = txtcomplemento.Text;
            cliente1.Id_Reprasentante = (int)comboBox1.SelectedValue;
            cliente1.Gravar();
            BloquearCampo();
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
                            clsCliente cliente = JsonConvert.DeserializeObject<clsCliente>(resultado);
                            txtlogradouro.Text = cliente.Localidade;
                            txtbairro.Text = cliente.Bairro;
                            txtuf.Text = cliente.Uf;
                            txtrua.Text = cliente.Logradouro;
                            txtcomplemento.Text = cliente.Complemento;
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

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'simpleSystemDataSet2.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.simpleSystemDataSet2.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'simpleSystemDataSet.Representante'. Você pode movê-la ou removê-la conforme necessário.
            this.representanteTableAdapter.Fill(this.simpleSystemDataSet.Representante);
            //txtobs1.TextChanged += txtobs_TextChanged;
            //txtobs1.Multiline = true;
            //AutoSizeTextBox(txtobs1);
        }

        private void txtobs_TextChanged(object sender, EventArgs e)
        {
            //AutoSizeTextBox(txtobs1);
        }

        private void AutoSizeTextBox(TextBox txtobs)
        {
            //const int margin_x = 100;
            //const int margin_y = 16;
            //Size tamanho = TextRenderer.MeasureText(txtobs.Text, txtobs.Font);
            //txtobs.ClientSize = new Size(tamanho.Width + margin_x, tamanho.Height + margin_y);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            BloquearCampo();
            tabControl1.SelectedTab = tabPage1;
            return;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void representanteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

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
            VerificaAlterar = false;
        }
        private void PegarDadosGrid()
        {
            var dataIndexNo = dataGridView1.CurrentCell.RowIndex;
            txtcodigo.Text = dataGridView1.Rows[dataIndexNo].Cells[0].Value.ToString();
            txtnome.Text = dataGridView1.Rows[dataIndexNo].Cells[1].Value.ToString();
            txtcpf.Text = dataGridView1.Rows[dataIndexNo].Cells[2].Value.ToString();
            txtnumero.Text = dataGridView1.Rows[dataIndexNo].Cells[3].Value.ToString();
            string tipoDePessoa = dataGridView1.Rows[dataIndexNo].Cells[4].Value.ToString();
            if (tipoDePessoa == "Fisica")
            {
                checkfisica.Checked = true;
                txtcpf.Text = dataGridView1.Rows[dataIndexNo].Cells[2].Value.ToString();
            }
            else
            {
                checkjuridica.Checked = true;
                txtcnpj.Text = dataGridView1.Rows[dataIndexNo].Cells[2].Value.ToString();
            }
            txttelefone.Text = dataGridView1.Rows[dataIndexNo].Cells[5].Value.ToString();
            txtemail.Text = dataGridView1.Rows[dataIndexNo].Cells[6].Value.ToString();
            txtdatanascimento.Text = dataGridView1.Rows[dataIndexNo].Cells[7].Value.ToString();
            txtrg.Text = dataGridView1.Rows[dataIndexNo].Cells[8].Value.ToString();
            txtobs.Text = dataGridView1.Rows[dataIndexNo].Cells[9].Value.ToString();
            txtpais.Text = dataGridView1.Rows[dataIndexNo].Cells[10].Value.ToString();
            txtcep.Text = dataGridView1.Rows[dataIndexNo].Cells[11].Value.ToString();
            txtrua.Text = dataGridView1.Rows[dataIndexNo].Cells[12].Value.ToString();
            txtcomplemento.Text = dataGridView1.Rows[dataIndexNo].Cells[13].Value.ToString();
            txtbairro.Text = dataGridView1.Rows[dataIndexNo].Cells[14].Value.ToString();
            txtlogradouro.Text = dataGridView1.Rows[dataIndexNo].Cells[15].Value.ToString();
            txtuf.Text = dataGridView1.Rows[dataIndexNo].Cells[16].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.Rows[dataIndexNo].Cells[17].Value;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            var cliente = new clsCliente();
            var result = msg.Excluir("Senhor usuário, esta operação irá desativar o cliente, deseja continuar?");
            if (result)
            {
                if (tabControl1.SelectedTab == tabPage2)
                {
                    cliente = cliente.AcharClientePorID(Int32.Parse(txtcodigo.Text));
                    if (cliente != null)
                    {
                        cliente.Excluir(Int32.Parse(txtcodigo.Text), cliente);
                    }
                }
                else
                {
                    PegarDadosGrid();
                    tabControl1.SelectedTab = tabPage2;
                    cliente = cliente.AcharClientePorID(Int32.Parse(txtcodigo.Text));
                    if (cliente != null)
                    {
                        cliente.Ativo = false;
                        cliente.Excluir(Int32.Parse(txtcodigo.Text), cliente);
                    }
                }
            }
            else
            {
                BloquearCampo();
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var dataIndexNo = dataGridView1.Rows[e.RowIndex].Index.ToString();
            txtcodigo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtnumero.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string tipoDePessoa = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (tipoDePessoa == "Fisica")
            {
                checkfisica.Checked = true;
                txtcpf.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            else
            {
                checkjuridica.Checked = true;
                txtcnpj.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            txttelefone.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtdatanascimento.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtrg.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtobs.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtpais.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtcep.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtrua.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtcomplemento.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtbairro.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            txtlogradouro.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            txtuf.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[17].Value;
            tabControl1.SelectedTab = tabPage2;
            checkfisica.Enabled = false;
            checkjuridica.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
