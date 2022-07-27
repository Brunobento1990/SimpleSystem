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
        //clsCliente cliente = new clsCliente();
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
            checkfisica.Enabled = true;
            checkjuridica.Enabled = true;
            btnpesquisarcep.Enabled = true;
        }

        private void checkfisica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkfisica.Checked == false)
            {
                checkjuridica.Enabled = true;
            }
            else
            {
                txtcpf.Visible = true;
                labelcpf.Text = "CPF";
                checkjuridica.Enabled = false;
                txtcnpj.Visible = false;
            }

        }

        private void checkjuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkjuridica.Checked == false)
            {
                checkfisica.Enabled = true;
            }
            else
            {
                txtcpf.Visible = false;
                labelcpf.Text = "CNPJ";
                checkfisica.Enabled = false;
                txtcnpj.Visible = true;
                txtcnpj.Enabled = true;
            }

        }

        private void btnsalvar_Click(object sender, EventArgs e)
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
             //Regex.Replace(txtcpf.Text.ToString(), @"[^\w\.@-]", "",
                               // RegexOptions.None, TimeSpan.FromSeconds(1.5));//txtcpf.Text;
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
            cliente1.Ativo = "1";
            cliente1.Localidade = txtlogradouro.Text;
            cliente1.Bairro  = txtbairro.Text;
            cliente1.Uf = txtuf.Text;
            cliente1.Logradouro = txtrua.Text;
            cliente1.Complemento = txtcomplemento.Text;
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
            txtobs.TextChanged += txtobs_TextChanged;
            txtobs.Multiline = true;
            AutoSizeTextBox(txtobs);
        }

        private void txtobs_TextChanged(object sender, EventArgs e)
        {
            AutoSizeTextBox(txtobs);
        }

        private void AutoSizeTextBox(TextBox txtobs)
        {
            const int margin_x = 100;
            const int margin_y = 16;
            Size tamanho = TextRenderer.MeasureText(txtobs.Text, txtobs.Font);
            txtobs.ClientSize = new Size(tamanho.Width + margin_x, tamanho.Height + margin_y);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            BloquearCampo();
            tabControl1.SelectedTab = tabPage1;
            return;
        }
    }
}
