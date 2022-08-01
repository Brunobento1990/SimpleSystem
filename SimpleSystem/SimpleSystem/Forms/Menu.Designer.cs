
namespace SimpleSystem
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnfrmcliente = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnfrmrepresentante = new System.Windows.Forms.Button();
            this.cadastroDeRepresentanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.cadastroDeRepresentanteToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // btnfrmcliente
            // 
            this.btnfrmcliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfrmcliente.BackgroundImage")));
            this.btnfrmcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnfrmcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfrmcliente.Location = new System.Drawing.Point(33, 45);
            this.btnfrmcliente.Name = "btnfrmcliente";
            this.btnfrmcliente.Size = new System.Drawing.Size(58, 58);
            this.btnfrmcliente.TabIndex = 3;
            this.btnfrmcliente.UseVisualStyleBackColor = true;
            this.btnfrmcliente.Click += new System.EventHandler(this.btnfrmcliente_Click);
            // 
            // btnsair
            // 
            this.btnsair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsair.BackgroundImage")));
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsair.Location = new System.Drawing.Point(745, 396);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(43, 42);
            this.btnsair.TabIndex = 4;
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnfrmrepresentante
            // 
            this.btnfrmrepresentante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfrmrepresentante.BackgroundImage")));
            this.btnfrmrepresentante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnfrmrepresentante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfrmrepresentante.Location = new System.Drawing.Point(112, 45);
            this.btnfrmrepresentante.Name = "btnfrmrepresentante";
            this.btnfrmrepresentante.Size = new System.Drawing.Size(58, 58);
            this.btnfrmrepresentante.TabIndex = 6;
            this.btnfrmrepresentante.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnfrmrepresentante.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnfrmrepresentante.UseVisualStyleBackColor = true;
            this.btnfrmrepresentante.Click += new System.EventHandler(this.btnfrmrepresentante_Click);
            // 
            // cadastroDeRepresentanteToolStripMenuItem
            // 
            this.cadastroDeRepresentanteToolStripMenuItem.Name = "cadastroDeRepresentanteToolStripMenuItem";
            this.cadastroDeRepresentanteToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cadastroDeRepresentanteToolStripMenuItem.Text = "Cadastro de Representante";
            this.cadastroDeRepresentanteToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeRepresentanteToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfrmrepresentante);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnfrmcliente);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Simple System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.Button btnfrmcliente;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnfrmrepresentante;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeRepresentanteToolStripMenuItem;
    }
}

