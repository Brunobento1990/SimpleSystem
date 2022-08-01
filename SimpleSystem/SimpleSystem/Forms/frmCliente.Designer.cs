
namespace SimpleSystem.Forms
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.representanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleSystemDataSet = new SimpleSystem.SimpleSystemDataSet();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtdatanascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtcnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.labelobs = new System.Windows.Forms.Label();
            this.txtobs1 = new System.Windows.Forms.TextBox();
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
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.labelcpf = new System.Windows.Forms.Label();
            this.labelrg = new System.Windows.Forms.Label();
            this.labeltelefone = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.labeldatanascimento = new System.Windows.Forms.Label();
            this.labelnome = new System.Windows.Forms.Label();
            this.checkjuridica = new System.Windows.Forms.CheckBox();
            this.checkfisica = new System.Windows.Forms.CheckBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.representanteTableAdapter = new SimpleSystem.SimpleSystemDataSetTableAdapters.RepresentanteTableAdapter();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.btnalterar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.representanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSystemDataSet)).BeginInit();
            this.groupendereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 542);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista de Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtobs);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.txtrg);
            this.tabPage2.Controls.Add(this.txttelefone);
            this.tabPage2.Controls.Add(this.txtdatanascimento);
            this.tabPage2.Controls.Add(this.txtcnpj);
            this.tabPage2.Controls.Add(this.txtcpf);
            this.tabPage2.Controls.Add(this.labelobs);
            this.tabPage2.Controls.Add(this.txtobs1);
            this.tabPage2.Controls.Add(this.groupendereco);
            this.tabPage2.Controls.Add(this.txtcodigo);
            this.tabPage2.Controls.Add(this.txtemail);
            this.tabPage2.Controls.Add(this.txtnome);
            this.tabPage2.Controls.Add(this.labelcpf);
            this.tabPage2.Controls.Add(this.labelrg);
            this.tabPage2.Controls.Add(this.labeltelefone);
            this.tabPage2.Controls.Add(this.labelemail);
            this.tabPage2.Controls.Add(this.labelcodigo);
            this.tabPage2.Controls.Add(this.labeldatanascimento);
            this.tabPage2.Controls.Add(this.labelnome);
            this.tabPage2.Controls.Add(this.checkjuridica);
            this.tabPage2.Controls.Add(this.checkfisica);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Representante";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.representanteBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 317);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(325, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.ValueMember = "Id_Representante";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // representanteBindingSource
            // 
            this.representanteBindingSource.DataMember = "Representante";
            this.representanteBindingSource.DataSource = this.simpleSystemDataSet;
            this.representanteBindingSource.CurrentChanged += new System.EventHandler(this.representanteBindingSource_CurrentChanged);
            // 
            // simpleSystemDataSet
            // 
            this.simpleSystemDataSet.DataSetName = "SimpleSystemDataSet";
            this.simpleSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtrg
            // 
            this.txtrg.Enabled = false;
            this.txtrg.Location = new System.Drawing.Point(6, 143);
            this.txtrg.Mask = "99,999,999-9";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(70, 20);
            this.txtrg.TabIndex = 33;
            // 
            // txttelefone
            // 
            this.txttelefone.Enabled = false;
            this.txttelefone.Location = new System.Drawing.Point(6, 233);
            this.txttelefone.Mask = "(99)99999-9999";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(82, 20);
            this.txttelefone.TabIndex = 32;
            // 
            // txtdatanascimento
            // 
            this.txtdatanascimento.Enabled = false;
            this.txtdatanascimento.Location = new System.Drawing.Point(6, 189);
            this.txtdatanascimento.Mask = "99/99/9999";
            this.txtdatanascimento.Name = "txtdatanascimento";
            this.txtdatanascimento.Size = new System.Drawing.Size(67, 20);
            this.txtdatanascimento.TabIndex = 31;
            // 
            // txtcnpj
            // 
            this.txtcnpj.Enabled = false;
            this.txtcnpj.Location = new System.Drawing.Point(6, 103);
            this.txtcnpj.Mask = "99,999,999/9999-99";
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(108, 20);
            this.txtcnpj.TabIndex = 30;
            this.txtcnpj.Visible = false;
            // 
            // txtcpf
            // 
            this.txtcpf.Enabled = false;
            this.txtcpf.Location = new System.Drawing.Point(6, 103);
            this.txtcpf.Mask = "999,999,999-99";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(82, 20);
            this.txtcpf.TabIndex = 29;
            // 
            // labelobs
            // 
            this.labelobs.AutoSize = true;
            this.labelobs.Location = new System.Drawing.Point(3, 351);
            this.labelobs.Name = "labelobs";
            this.labelobs.Size = new System.Drawing.Size(70, 13);
            this.labelobs.TabIndex = 24;
            this.labelobs.Text = "Observações";
            // 
            // txtobs1
            // 
            this.txtobs1.Enabled = false;
            this.txtobs1.Location = new System.Drawing.Point(6, 317);
            this.txtobs1.Name = "txtobs1";
            this.txtobs1.Size = new System.Drawing.Size(82, 20);
            this.txtobs1.TabIndex = 23;
            this.txtobs1.Visible = false;
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
            this.groupendereco.Location = new System.Drawing.Point(588, 29);
            this.groupendereco.Name = "groupendereco";
            this.groupendereco.Size = new System.Drawing.Size(429, 435);
            this.groupendereco.TabIndex = 22;
            this.groupendereco.TabStop = false;
            this.groupendereco.Text = "Endereço";
            // 
            // txtcep
            // 
            this.txtcep.Enabled = false;
            this.txtcep.Location = new System.Drawing.Point(7, 35);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(62, 20);
            this.txtcep.TabIndex = 26;
            // 
            // txtpais
            // 
            this.txtpais.Enabled = false;
            this.txtpais.Location = new System.Drawing.Point(73, 246);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(100, 20);
            this.txtpais.TabIndex = 16;
            // 
            // txtuf
            // 
            this.txtuf.Enabled = false;
            this.txtuf.Location = new System.Drawing.Point(6, 246);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(40, 20);
            this.txtuf.TabIndex = 15;
            // 
            // labelpais
            // 
            this.labelpais.AutoSize = true;
            this.labelpais.Location = new System.Drawing.Point(70, 230);
            this.labelpais.Name = "labelpais";
            this.labelpais.Size = new System.Drawing.Size(29, 13);
            this.labelpais.TabIndex = 14;
            this.labelpais.Text = "País";
            // 
            // labeluf
            // 
            this.labeluf.AutoSize = true;
            this.labeluf.Location = new System.Drawing.Point(6, 230);
            this.labeluf.Name = "labeluf";
            this.labeluf.Size = new System.Drawing.Size(21, 13);
            this.labeluf.TabIndex = 13;
            this.labeluf.Text = "UF";
            // 
            // txtlogradouro
            // 
            this.txtlogradouro.Enabled = false;
            this.txtlogradouro.Location = new System.Drawing.Point(6, 204);
            this.txtlogradouro.Name = "txtlogradouro";
            this.txtlogradouro.Size = new System.Drawing.Size(246, 20);
            this.txtlogradouro.TabIndex = 12;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Enabled = false;
            this.txtcomplemento.Location = new System.Drawing.Point(6, 160);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(246, 20);
            this.txtcomplemento.TabIndex = 11;
            // 
            // txtnumero
            // 
            this.txtnumero.Enabled = false;
            this.txtnumero.Location = new System.Drawing.Point(174, 114);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(78, 20);
            this.txtnumero.TabIndex = 10;
            // 
            // txtbairro
            // 
            this.txtbairro.Enabled = false;
            this.txtbairro.Location = new System.Drawing.Point(6, 114);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(142, 20);
            this.txtbairro.TabIndex = 9;
            // 
            // txtrua
            // 
            this.txtrua.Enabled = false;
            this.txtrua.Location = new System.Drawing.Point(6, 74);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(355, 20);
            this.txtrua.TabIndex = 8;
            // 
            // labelrua
            // 
            this.labelrua.AutoSize = true;
            this.labelrua.Location = new System.Drawing.Point(6, 58);
            this.labelrua.Name = "labelrua";
            this.labelrua.Size = new System.Drawing.Size(27, 13);
            this.labelrua.TabIndex = 7;
            this.labelrua.Text = "Rua";
            // 
            // labelcomplemento
            // 
            this.labelcomplemento.AutoSize = true;
            this.labelcomplemento.Location = new System.Drawing.Point(6, 140);
            this.labelcomplemento.Name = "labelcomplemento";
            this.labelcomplemento.Size = new System.Drawing.Size(71, 13);
            this.labelcomplemento.TabIndex = 6;
            this.labelcomplemento.Text = "Complemento";
            // 
            // labelcidade
            // 
            this.labelcidade.AutoSize = true;
            this.labelcidade.Location = new System.Drawing.Point(6, 187);
            this.labelcidade.Name = "labelcidade";
            this.labelcidade.Size = new System.Drawing.Size(40, 13);
            this.labelcidade.TabIndex = 5;
            this.labelcidade.Text = "Cidade";
            // 
            // labelbairro
            // 
            this.labelbairro.AutoSize = true;
            this.labelbairro.Location = new System.Drawing.Point(6, 98);
            this.labelbairro.Name = "labelbairro";
            this.labelbairro.Size = new System.Drawing.Size(34, 13);
            this.labelbairro.TabIndex = 4;
            this.labelbairro.Text = "Bairro";
            // 
            // labelnumero
            // 
            this.labelnumero.AutoSize = true;
            this.labelnumero.Location = new System.Drawing.Point(171, 98);
            this.labelnumero.Name = "labelnumero";
            this.labelnumero.Size = new System.Drawing.Size(44, 13);
            this.labelnumero.TabIndex = 3;
            this.labelnumero.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
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
            this.btnpesquisarcep.Location = new System.Drawing.Point(73, 30);
            this.btnpesquisarcep.Name = "btnpesquisarcep";
            this.btnpesquisarcep.Size = new System.Drawing.Size(28, 28);
            this.btnpesquisarcep.TabIndex = 0;
            this.btnpesquisarcep.UseVisualStyleBackColor = true;
            this.btnpesquisarcep.Click += new System.EventHandler(this.btnpesquisarcep_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(6, 22);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(50, 20);
            this.txtcodigo.TabIndex = 16;
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(6, 275);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(214, 20);
            this.txtemail.TabIndex = 14;
            // 
            // txtnome
            // 
            this.txtnome.Enabled = false;
            this.txtnome.Location = new System.Drawing.Point(6, 61);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(232, 20);
            this.txtnome.TabIndex = 10;
            // 
            // labelcpf
            // 
            this.labelcpf.AutoSize = true;
            this.labelcpf.Location = new System.Drawing.Point(3, 84);
            this.labelcpf.Name = "labelcpf";
            this.labelcpf.Size = new System.Drawing.Size(27, 13);
            this.labelcpf.TabIndex = 9;
            this.labelcpf.Text = "CPF";
            // 
            // labelrg
            // 
            this.labelrg.AutoSize = true;
            this.labelrg.Location = new System.Drawing.Point(3, 127);
            this.labelrg.Name = "labelrg";
            this.labelrg.Size = new System.Drawing.Size(23, 13);
            this.labelrg.TabIndex = 8;
            this.labelrg.Text = "RG";
            // 
            // labeltelefone
            // 
            this.labeltelefone.AutoSize = true;
            this.labeltelefone.Location = new System.Drawing.Point(3, 216);
            this.labeltelefone.Name = "labeltelefone";
            this.labeltelefone.Size = new System.Drawing.Size(49, 13);
            this.labeltelefone.TabIndex = 7;
            this.labeltelefone.Text = "Telefone";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(3, 259);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(41, 13);
            this.labelemail.TabIndex = 6;
            this.labelemail.Text = "E - mail";
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.Location = new System.Drawing.Point(3, 6);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(40, 13);
            this.labelcodigo.TabIndex = 5;
            this.labelcodigo.Text = "Código";
            // 
            // labeldatanascimento
            // 
            this.labeldatanascimento.AutoSize = true;
            this.labeldatanascimento.Location = new System.Drawing.Point(3, 169);
            this.labeldatanascimento.Name = "labeldatanascimento";
            this.labeldatanascimento.Size = new System.Drawing.Size(104, 13);
            this.labeldatanascimento.TabIndex = 4;
            this.labeldatanascimento.Text = "Data de Nascimento";
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Location = new System.Drawing.Point(3, 45);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(35, 13);
            this.labelnome.TabIndex = 2;
            this.labelnome.Text = "Nome";
            // 
            // checkjuridica
            // 
            this.checkjuridica.AutoSize = true;
            this.checkjuridica.Enabled = false;
            this.checkjuridica.Location = new System.Drawing.Point(430, 6);
            this.checkjuridica.Name = "checkjuridica";
            this.checkjuridica.Size = new System.Drawing.Size(102, 17);
            this.checkjuridica.TabIndex = 1;
            this.checkjuridica.Text = "Pessoa Jurídica";
            this.checkjuridica.UseVisualStyleBackColor = true;
            this.checkjuridica.CheckedChanged += new System.EventHandler(this.checkjuridica_CheckedChanged);
            // 
            // checkfisica
            // 
            this.checkfisica.AutoSize = true;
            this.checkfisica.Enabled = false;
            this.checkfisica.Location = new System.Drawing.Point(308, 6);
            this.checkfisica.Name = "checkfisica";
            this.checkfisica.Size = new System.Drawing.Size(91, 17);
            this.checkfisica.TabIndex = 0;
            this.checkfisica.Text = "Pessoa Fisica";
            this.checkfisica.UseVisualStyleBackColor = true;
            this.checkfisica.CheckedChanged += new System.EventHandler(this.checkfisica_CheckedChanged);
            // 
            // btnsair
            // 
            this.btnsair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsair.BackgroundImage")));
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsair.Location = new System.Drawing.Point(947, 548);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 24);
            this.btnsair.TabIndex = 1;
            this.btnsair.Text = "    Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnincluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnincluir.BackgroundImage")));
            this.btnincluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnincluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnincluir.Location = new System.Drawing.Point(542, 549);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 24);
            this.btnincluir.TabIndex = 2;
            this.btnincluir.Text = "    Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexcluir.BackgroundImage")));
            this.btnexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnexcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexcluir.Location = new System.Drawing.Point(704, 548);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 24);
            this.btnexcluir.TabIndex = 3;
            this.btnexcluir.Text = "      Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalvar.BackgroundImage")));
            this.btnsalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalvar.Enabled = false;
            this.btnsalvar.Location = new System.Drawing.Point(785, 548);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 24);
            this.btnsalvar.TabIndex = 4;
            this.btnsalvar.Text = "      Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Enabled = false;
            this.btncancelar.Location = new System.Drawing.Point(866, 548);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 24);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // representanteTableAdapter
            // 
            this.representanteTableAdapter.ClearBeforeFill = true;
            // 
            // txtobs
            // 
            this.txtobs.Enabled = false;
            this.txtobs.Location = new System.Drawing.Point(6, 367);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(565, 20);
            this.txtobs.TabIndex = 36;
            this.txtobs.WordWrap = false;
            // 
            // btnalterar
            // 
            this.btnalterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnalterar.BackgroundImage")));
            this.btnalterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnalterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnalterar.Location = new System.Drawing.Point(623, 549);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 13;
            this.btnalterar.Text = "     Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 582);
            this.ControlBox = false;
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.representanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSystemDataSet)).EndInit();
            this.groupendereco.ResumeLayout(false);
            this.groupendereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label labelcpf;
        private System.Windows.Forms.Label labelrg;
        private System.Windows.Forms.Label labeltelefone;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelcodigo;
        private System.Windows.Forms.Label labeldatanascimento;
        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.CheckBox checkjuridica;
        private System.Windows.Forms.CheckBox checkfisica;
        private System.Windows.Forms.GroupBox groupendereco;
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
        private System.Windows.Forms.Label labelobs;
        private System.Windows.Forms.TextBox txtobs1;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.MaskedTextBox txtdatanascimento;
        private System.Windows.Forms.MaskedTextBox txtcnpj;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private SimpleSystemDataSet simpleSystemDataSet;
        private System.Windows.Forms.BindingSource representanteBindingSource;
        private SimpleSystemDataSetTableAdapters.RepresentanteTableAdapter representanteTableAdapter;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Button btnalterar;
    }
}