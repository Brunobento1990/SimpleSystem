
namespace SimpleSystem.Forms
{
    partial class frmRepresentante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepresentante));
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.labelcpf = new System.Windows.Forms.Label();
            this.labelnome = new System.Windows.Forms.Label();
            this.groupendereco = new System.Windows.Forms.GroupBox();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.txtuf = new System.Windows.Forms.TextBox();
            this.labelpais = new System.Windows.Forms.Label();
            this.labeluf = new System.Windows.Forms.Label();
            this.txtlogradouro = new System.Windows.Forms.TextBox();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.labelrua = new System.Windows.Forms.Label();
            this.labelcomplemento = new System.Windows.Forms.Label();
            this.labelcidade = new System.Windows.Forms.Label();
            this.labelbairro = new System.Windows.Forms.Label();
            this.labelnumero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpesquisarcep = new System.Windows.Forms.Button();
            this.labelrg = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.labelobs = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtdatanascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.labeldatanascimento = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labeltelefone = new System.Windows.Forms.Label();
            this.btnalterar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.simpleSystemDataSet1 = new SimpleSystem.SimpleSystemDataSet1();
            this.representanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.representanteTableAdapter = new SimpleSystem.SimpleSystemDataSet1TableAdapters.RepresentanteTableAdapter();
            this.idRepresentanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupendereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.representanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Enabled = false;
            this.btncancelar.Location = new System.Drawing.Point(813, 418);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 24);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalvar.BackgroundImage")));
            this.btnsalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalvar.Enabled = false;
            this.btnsalvar.Location = new System.Drawing.Point(732, 418);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 24);
            this.btnsalvar.TabIndex = 9;
            this.btnsalvar.Text = "      Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexcluir.BackgroundImage")));
            this.btnexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnexcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexcluir.Location = new System.Drawing.Point(651, 418);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 24);
            this.btnexcluir.TabIndex = 8;
            this.btnexcluir.Text = "      Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnincluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnincluir.BackgroundImage")));
            this.btnincluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnincluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnincluir.Location = new System.Drawing.Point(489, 419);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 24);
            this.btnincluir.TabIndex = 7;
            this.btnincluir.Text = "    Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btnsair
            // 
            this.btnsair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsair.BackgroundImage")));
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsair.Location = new System.Drawing.Point(894, 418);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 24);
            this.btnsair.TabIndex = 6;
            this.btnsair.Text = "    Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 400);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista de Representante";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelcodigo);
            this.tabPage2.Controls.Add(this.txtcodigo);
            this.tabPage2.Controls.Add(this.txtrg);
            this.tabPage2.Controls.Add(this.labelcpf);
            this.tabPage2.Controls.Add(this.labelnome);
            this.tabPage2.Controls.Add(this.groupendereco);
            this.tabPage2.Controls.Add(this.labelrg);
            this.tabPage2.Controls.Add(this.txtobs);
            this.tabPage2.Controls.Add(this.labelobs);
            this.tabPage2.Controls.Add(this.txttelefone);
            this.tabPage2.Controls.Add(this.txtnome);
            this.tabPage2.Controls.Add(this.txtdatanascimento);
            this.tabPage2.Controls.Add(this.txtemail);
            this.tabPage2.Controls.Add(this.txtcpf);
            this.tabPage2.Controls.Add(this.labeldatanascimento);
            this.tabPage2.Controls.Add(this.labelemail);
            this.tabPage2.Controls.Add(this.labeltelefone);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Representante";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.Location = new System.Drawing.Point(33, 15);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(40, 13);
            this.labelcodigo.TabIndex = 38;
            this.labelcodigo.Text = "Código";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(36, 33);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(50, 20);
            this.txtcodigo.TabIndex = 45;
            // 
            // txtrg
            // 
            this.txtrg.Enabled = false;
            this.txtrg.Location = new System.Drawing.Point(139, 129);
            this.txtrg.Mask = "99,999,999-9";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(70, 20);
            this.txtrg.TabIndex = 3;
            // 
            // labelcpf
            // 
            this.labelcpf.AutoSize = true;
            this.labelcpf.Location = new System.Drawing.Point(33, 106);
            this.labelcpf.Name = "labelcpf";
            this.labelcpf.Size = new System.Drawing.Size(23, 13);
            this.labelcpf.TabIndex = 42;
            this.labelcpf.Text = "Cpf";
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Location = new System.Drawing.Point(33, 60);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(35, 13);
            this.labelnome.TabIndex = 36;
            this.labelnome.Text = "Nome";
            // 
            // groupendereco
            // 
            this.groupendereco.Controls.Add(this.txtcep);
            this.groupendereco.Controls.Add(this.txtpais);
            this.groupendereco.Controls.Add(this.txtuf);
            this.groupendereco.Controls.Add(this.labelpais);
            this.groupendereco.Controls.Add(this.labeluf);
            this.groupendereco.Controls.Add(this.txtlogradouro);
            this.groupendereco.Controls.Add(this.txtcomplemento);
            this.groupendereco.Controls.Add(this.txtnumero);
            this.groupendereco.Controls.Add(this.txtbairro);
            this.groupendereco.Controls.Add(this.txtrua);
            this.groupendereco.Controls.Add(this.labelrua);
            this.groupendereco.Controls.Add(this.labelcomplemento);
            this.groupendereco.Controls.Add(this.labelcidade);
            this.groupendereco.Controls.Add(this.labelbairro);
            this.groupendereco.Controls.Add(this.labelnumero);
            this.groupendereco.Controls.Add(this.label1);
            this.groupendereco.Controls.Add(this.btnpesquisarcep);
            this.groupendereco.Location = new System.Drawing.Point(23, 173);
            this.groupendereco.Name = "groupendereco";
            this.groupendereco.Size = new System.Drawing.Size(905, 178);
            this.groupendereco.TabIndex = 46;
            this.groupendereco.TabStop = false;
            this.groupendereco.Text = "Endereço";
            // 
            // txtcep
            // 
            this.txtcep.Enabled = false;
            this.txtcep.Location = new System.Drawing.Point(13, 42);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(62, 20);
            this.txtcep.TabIndex = 7;
            // 
            // txtpais
            // 
            this.txtpais.Enabled = false;
            this.txtpais.Location = new System.Drawing.Point(492, 90);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(100, 20);
            this.txtpais.TabIndex = 12;
            // 
            // txtuf
            // 
            this.txtuf.Enabled = false;
            this.txtuf.Location = new System.Drawing.Point(425, 90);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(40, 20);
            this.txtuf.TabIndex = 11;
            // 
            // labelpais
            // 
            this.labelpais.AutoSize = true;
            this.labelpais.Location = new System.Drawing.Point(489, 74);
            this.labelpais.Name = "labelpais";
            this.labelpais.Size = new System.Drawing.Size(29, 13);
            this.labelpais.TabIndex = 14;
            this.labelpais.Text = "País";
            // 
            // labeluf
            // 
            this.labeluf.AutoSize = true;
            this.labeluf.Location = new System.Drawing.Point(425, 74);
            this.labeluf.Name = "labeluf";
            this.labeluf.Size = new System.Drawing.Size(21, 13);
            this.labeluf.TabIndex = 13;
            this.labeluf.Text = "UF";
            // 
            // txtlogradouro
            // 
            this.txtlogradouro.Enabled = false;
            this.txtlogradouro.Location = new System.Drawing.Point(97, 43);
            this.txtlogradouro.Name = "txtlogradouro";
            this.txtlogradouro.Size = new System.Drawing.Size(246, 20);
            this.txtlogradouro.TabIndex = 8;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Enabled = false;
            this.txtcomplemento.Location = new System.Drawing.Point(423, 43);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(246, 20);
            this.txtcomplemento.TabIndex = 9;
            // 
            // txtnumero
            // 
            this.txtnumero.Enabled = false;
            this.txtnumero.Location = new System.Drawing.Point(189, 140);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(78, 20);
            this.txtnumero.TabIndex = 14;
            // 
            // txtbairro
            // 
            this.txtbairro.Enabled = false;
            this.txtbairro.Location = new System.Drawing.Point(13, 140);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(142, 20);
            this.txtbairro.TabIndex = 13;
            // 
            // txtrua
            // 
            this.txtrua.Enabled = false;
            this.txtrua.Location = new System.Drawing.Point(13, 90);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(330, 20);
            this.txtrua.TabIndex = 10;
            // 
            // labelrua
            // 
            this.labelrua.AutoSize = true;
            this.labelrua.Location = new System.Drawing.Point(10, 69);
            this.labelrua.Name = "labelrua";
            this.labelrua.Size = new System.Drawing.Size(27, 13);
            this.labelrua.TabIndex = 7;
            this.labelrua.Text = "Rua";
            // 
            // labelcomplemento
            // 
            this.labelcomplemento.AutoSize = true;
            this.labelcomplemento.Location = new System.Drawing.Point(420, 22);
            this.labelcomplemento.Name = "labelcomplemento";
            this.labelcomplemento.Size = new System.Drawing.Size(71, 13);
            this.labelcomplemento.TabIndex = 6;
            this.labelcomplemento.Text = "Complemento";
            // 
            // labelcidade
            // 
            this.labelcidade.AutoSize = true;
            this.labelcidade.Location = new System.Drawing.Point(94, 22);
            this.labelcidade.Name = "labelcidade";
            this.labelcidade.Size = new System.Drawing.Size(40, 13);
            this.labelcidade.TabIndex = 5;
            this.labelcidade.Text = "Cidade";
            // 
            // labelbairro
            // 
            this.labelbairro.AutoSize = true;
            this.labelbairro.Location = new System.Drawing.Point(10, 120);
            this.labelbairro.Name = "labelbairro";
            this.labelbairro.Size = new System.Drawing.Size(34, 13);
            this.labelbairro.TabIndex = 4;
            this.labelbairro.Text = "Bairro";
            // 
            // labelnumero
            // 
            this.labelnumero.AutoSize = true;
            this.labelnumero.Location = new System.Drawing.Point(186, 120);
            this.labelnumero.Name = "labelnumero";
            this.labelnumero.Size = new System.Drawing.Size(44, 13);
            this.labelnumero.TabIndex = 3;
            this.labelnumero.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CEP";
            // 
            // btnpesquisarcep
            // 
            this.btnpesquisarcep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpesquisarcep.BackgroundImage")));
            this.btnpesquisarcep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnpesquisarcep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpesquisarcep.Enabled = false;
            this.btnpesquisarcep.Location = new System.Drawing.Point(44, 14);
            this.btnpesquisarcep.Name = "btnpesquisarcep";
            this.btnpesquisarcep.Size = new System.Drawing.Size(28, 28);
            this.btnpesquisarcep.TabIndex = 0;
            this.btnpesquisarcep.UseVisualStyleBackColor = true;
            this.btnpesquisarcep.Click += new System.EventHandler(this.btnpesquisarcep_Click);
            // 
            // labelrg
            // 
            this.labelrg.AutoSize = true;
            this.labelrg.Location = new System.Drawing.Point(136, 106);
            this.labelrg.Name = "labelrg";
            this.labelrg.Size = new System.Drawing.Size(21, 13);
            this.labelrg.TabIndex = 41;
            this.labelrg.Text = "Rg";
            // 
            // txtobs
            // 
            this.txtobs.Enabled = false;
            this.txtobs.Location = new System.Drawing.Point(410, 31);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(518, 20);
            this.txtobs.TabIndex = 15;
            this.txtobs.WordWrap = false;
            // 
            // labelobs
            // 
            this.labelobs.AutoSize = true;
            this.labelobs.Location = new System.Drawing.Point(407, 15);
            this.labelobs.Name = "labelobs";
            this.labelobs.Size = new System.Drawing.Size(70, 13);
            this.labelobs.TabIndex = 48;
            this.labelobs.Text = "Observações";
            // 
            // txttelefone
            // 
            this.txttelefone.Enabled = false;
            this.txttelefone.Location = new System.Drawing.Point(241, 129);
            this.txttelefone.Mask = "(99)99999-9999";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(82, 20);
            this.txttelefone.TabIndex = 4;
            // 
            // txtnome
            // 
            this.txtnome.Enabled = false;
            this.txtnome.Location = new System.Drawing.Point(36, 79);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(232, 20);
            this.txtnome.TabIndex = 1;
            // 
            // txtdatanascimento
            // 
            this.txtdatanascimento.Enabled = false;
            this.txtdatanascimento.Location = new System.Drawing.Point(344, 129);
            this.txtdatanascimento.Mask = "99/99/9999";
            this.txtdatanascimento.Name = "txtdatanascimento";
            this.txtdatanascimento.Size = new System.Drawing.Size(67, 20);
            this.txtdatanascimento.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(453, 129);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(214, 20);
            this.txtemail.TabIndex = 6;
            // 
            // txtcpf
            // 
            this.txtcpf.Enabled = false;
            this.txtcpf.Location = new System.Drawing.Point(36, 129);
            this.txtcpf.Mask = "999,999,999-99";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(82, 20);
            this.txtcpf.TabIndex = 2;
            // 
            // labeldatanascimento
            // 
            this.labeldatanascimento.AutoSize = true;
            this.labeldatanascimento.Location = new System.Drawing.Point(341, 106);
            this.labeldatanascimento.Name = "labeldatanascimento";
            this.labeldatanascimento.Size = new System.Drawing.Size(104, 13);
            this.labeldatanascimento.TabIndex = 37;
            this.labeldatanascimento.Text = "Data de Nascimento";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(451, 106);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(41, 13);
            this.labelemail.TabIndex = 39;
            this.labelemail.Text = "E - mail";
            // 
            // labeltelefone
            // 
            this.labeltelefone.AutoSize = true;
            this.labeltelefone.Location = new System.Drawing.Point(238, 106);
            this.labeltelefone.Name = "labeltelefone";
            this.labeltelefone.Size = new System.Drawing.Size(49, 13);
            this.labeltelefone.TabIndex = 40;
            this.labeltelefone.Text = "Telefone";
            // 
            // btnalterar
            // 
            this.btnalterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnalterar.BackgroundImage")));
            this.btnalterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnalterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnalterar.Location = new System.Drawing.Point(570, 419);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 12;
            this.btnalterar.Text = "     Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRepresentanteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.obsDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.logradouroDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.localidadeDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.representanteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(944, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // simpleSystemDataSet1
            // 
            this.simpleSystemDataSet1.DataSetName = "SimpleSystemDataSet1";
            this.simpleSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // representanteBindingSource
            // 
            this.representanteBindingSource.DataMember = "Representante";
            this.representanteBindingSource.DataSource = this.simpleSystemDataSet1;
            this.representanteBindingSource.CurrentChanged += new System.EventHandler(this.representanteBindingSource_CurrentChanged);
            // 
            // representanteTableAdapter
            // 
            this.representanteTableAdapter.ClearBeforeFill = true;
            // 
            // idRepresentanteDataGridViewTextBoxColumn
            // 
            this.idRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "Id_Representante";
            this.idRepresentanteDataGridViewTextBoxColumn.HeaderText = "Id_Representante";
            this.idRepresentanteDataGridViewTextBoxColumn.Name = "idRepresentanteDataGridViewTextBoxColumn";
            this.idRepresentanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data_Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "Rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "Rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            this.rgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            this.obsDataGridViewTextBoxColumn.DataPropertyName = "Obs";
            this.obsDataGridViewTextBoxColumn.HeaderText = "Obs";
            this.obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            this.obsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            this.paisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "Cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "Cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logradouroDataGridViewTextBoxColumn
            // 
            this.logradouroDataGridViewTextBoxColumn.DataPropertyName = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.HeaderText = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.Name = "logradouroDataGridViewTextBoxColumn";
            this.logradouroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "Complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            this.complementoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadeDataGridViewTextBoxColumn
            // 
            this.localidadeDataGridViewTextBoxColumn.DataPropertyName = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.HeaderText = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.Name = "localidadeDataGridViewTextBoxColumn";
            this.localidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ufDataGridViewTextBoxColumn
            // 
            this.ufDataGridViewTextBoxColumn.DataPropertyName = "Uf";
            this.ufDataGridViewTextBoxColumn.HeaderText = "Uf";
            this.ufDataGridViewTextBoxColumn.Name = "ufDataGridViewTextBoxColumn";
            this.ufDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmRepresentante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.btnsair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRepresentante";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Representante";
            this.Load += new System.EventHandler(this.frmRepresentante_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupendereco.ResumeLayout(false);
            this.groupendereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.representanteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.Label labelcpf;
        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.GroupBox groupendereco;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.TextBox txtuf;
        private System.Windows.Forms.Label labelpais;
        private System.Windows.Forms.Label labeluf;
        private System.Windows.Forms.TextBox txtlogradouro;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.Label labelrua;
        private System.Windows.Forms.Label labelcomplemento;
        private System.Windows.Forms.Label labelcidade;
        private System.Windows.Forms.Label labelbairro;
        private System.Windows.Forms.Label labelnumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpesquisarcep;
        private System.Windows.Forms.Label labelrg;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Label labelobs;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.MaskedTextBox txtdatanascimento;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label labeldatanascimento;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labeltelefone;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SimpleSystemDataSet1 simpleSystemDataSet1;
        private System.Windows.Forms.BindingSource representanteBindingSource;
        private SimpleSystemDataSet1TableAdapters.RepresentanteTableAdapter representanteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRepresentanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
    }
}