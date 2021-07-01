
namespace NSSuiteClientCSharp.Forms
{
    partial class frmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEmitirBPe = new System.Windows.Forms.Button();
            this.btnEmitirCTe = new System.Windows.Forms.Button();
            this.btnEmitirMDFe = new System.Windows.Forms.Button();
            this.btnEmitirNFSe = new System.Windows.Forms.Button();
            this.btnEmitirNFCe = new System.Windows.Forms.Button();
            this.cmbTipoICMSNFCe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEmitirNFe = new System.Windows.Forms.Button();
            this.cmbTipoICMS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRetornoAPI = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEmitirBPe);
            this.groupBox1.Controls.Add(this.btnEmitirCTe);
            this.groupBox1.Controls.Add(this.btnEmitirMDFe);
            this.groupBox1.Controls.Add(this.btnEmitirNFSe);
            this.groupBox1.Controls.Add(this.btnEmitirNFCe);
            this.groupBox1.Controls.Add(this.cmbTipoICMSNFCe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnEmitirNFe);
            this.groupBox1.Controls.Add(this.cmbTipoICMS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnEmitirBPe
            // 
            this.btnEmitirBPe.Location = new System.Drawing.Point(439, 171);
            this.btnEmitirBPe.Name = "btnEmitirBPe";
            this.btnEmitirBPe.Size = new System.Drawing.Size(187, 77);
            this.btnEmitirBPe.TabIndex = 9;
            this.btnEmitirBPe.Text = "Emitir BPe";
            this.btnEmitirBPe.UseVisualStyleBackColor = true;
            this.btnEmitirBPe.Click += new System.EventHandler(this.btnEmitirBPe_Click);
            // 
            // btnEmitirCTe
            // 
            this.btnEmitirCTe.Location = new System.Drawing.Point(224, 171);
            this.btnEmitirCTe.Name = "btnEmitirCTe";
            this.btnEmitirCTe.Size = new System.Drawing.Size(177, 77);
            this.btnEmitirCTe.TabIndex = 8;
            this.btnEmitirCTe.Text = "Emitir CTe";
            this.btnEmitirCTe.UseVisualStyleBackColor = true;
            this.btnEmitirCTe.Click += new System.EventHandler(this.btnEmitirCTe_Click);
            // 
            // btnEmitirMDFe
            // 
            this.btnEmitirMDFe.Location = new System.Drawing.Point(9, 171);
            this.btnEmitirMDFe.Name = "btnEmitirMDFe";
            this.btnEmitirMDFe.Size = new System.Drawing.Size(177, 77);
            this.btnEmitirMDFe.TabIndex = 7;
            this.btnEmitirMDFe.Text = "Emitir MDFe";
            this.btnEmitirMDFe.UseVisualStyleBackColor = true;
            this.btnEmitirMDFe.Click += new System.EventHandler(this.btnEmitirMDFe_Click);
            // 
            // btnEmitirNFSe
            // 
            this.btnEmitirNFSe.Location = new System.Drawing.Point(439, 59);
            this.btnEmitirNFSe.Name = "btnEmitirNFSe";
            this.btnEmitirNFSe.Size = new System.Drawing.Size(187, 77);
            this.btnEmitirNFSe.TabIndex = 6;
            this.btnEmitirNFSe.Text = "Emitir NFSe";
            this.btnEmitirNFSe.UseVisualStyleBackColor = true;
            this.btnEmitirNFSe.Click += new System.EventHandler(this.btnEmitirNFSe_Click);
            // 
            // btnEmitirNFCe
            // 
            this.btnEmitirNFCe.Location = new System.Drawing.Point(224, 59);
            this.btnEmitirNFCe.Name = "btnEmitirNFCe";
            this.btnEmitirNFCe.Size = new System.Drawing.Size(177, 77);
            this.btnEmitirNFCe.TabIndex = 5;
            this.btnEmitirNFCe.Text = "Emitir NFCe";
            this.btnEmitirNFCe.UseVisualStyleBackColor = true;
            this.btnEmitirNFCe.Click += new System.EventHandler(this.btnEmitirNFCe_Click);
            // 
            // cmbTipoICMSNFCe
            // 
            this.cmbTipoICMSNFCe.FormattingEnabled = true;
            this.cmbTipoICMSNFCe.Items.AddRange(new object[] {
            "NotaNFCeICMS102"});
            this.cmbTipoICMSNFCe.Location = new System.Drawing.Point(221, 32);
            this.cmbTipoICMSNFCe.Name = "cmbTipoICMSNFCe";
            this.cmbTipoICMSNFCe.Size = new System.Drawing.Size(180, 21);
            this.cmbTipoICMSNFCe.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de ICMS para NFCe:";
            // 
            // btnEmitirNFe
            // 
            this.btnEmitirNFe.Location = new System.Drawing.Point(9, 59);
            this.btnEmitirNFe.Name = "btnEmitirNFe";
            this.btnEmitirNFe.Size = new System.Drawing.Size(177, 77);
            this.btnEmitirNFe.TabIndex = 2;
            this.btnEmitirNFe.Text = "Emitir NFe";
            this.btnEmitirNFe.UseVisualStyleBackColor = true;
            this.btnEmitirNFe.Click += new System.EventHandler(this.btnEmitirNFe_Click);
            // 
            // cmbTipoICMS
            // 
            this.cmbTipoICMS.FormattingEnabled = true;
            this.cmbTipoICMS.Items.AddRange(new object[] {
            "NotaICMS102",
            "NotaICMSSN500"});
            this.cmbTipoICMS.Location = new System.Drawing.Point(6, 32);
            this.cmbTipoICMS.Name = "cmbTipoICMS";
            this.cmbTipoICMS.Size = new System.Drawing.Size(180, 21);
            this.cmbTipoICMS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de ICMS para NFe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emissão de DFes via API da NS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Retornos API:";
            // 
            // txtRetornoAPI
            // 
            this.txtRetornoAPI.Location = new System.Drawing.Point(12, 419);
            this.txtRetornoAPI.Multiline = true;
            this.txtRetornoAPI.Name = "txtRetornoAPI";
            this.txtRetornoAPI.Size = new System.Drawing.Size(890, 246);
            this.txtRetornoAPI.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(891, 360);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(883, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Via Objeto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(883, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Via JSON Gerado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 672);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtRetornoAPI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEmitirBPe;
        private System.Windows.Forms.Button btnEmitirCTe;
        private System.Windows.Forms.Button btnEmitirMDFe;
        private System.Windows.Forms.Button btnEmitirNFSe;
        private System.Windows.Forms.Button btnEmitirNFCe;
        private System.Windows.Forms.ComboBox cmbTipoICMSNFCe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEmitirNFe;
        private System.Windows.Forms.ComboBox cmbTipoICMS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRetornoAPI;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

