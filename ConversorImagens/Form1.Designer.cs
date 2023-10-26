namespace ConversorImagens
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSelecionarPastaOrigem = new System.Windows.Forms.Button();
            this.btnSelecionarPastaDestino = new System.Windows.Forms.Button();
            this.txtPastaOrigem = new System.Windows.Forms.TextBox();
            this.txtPastaDestino = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionarPastaOrigem
            // 
            this.btnSelecionarPastaOrigem.Location = new System.Drawing.Point(148, 43);
            this.btnSelecionarPastaOrigem.Name = "btnSelecionarPastaOrigem";
            this.btnSelecionarPastaOrigem.Size = new System.Drawing.Size(153, 34);
            this.btnSelecionarPastaOrigem.TabIndex = 0;
            this.btnSelecionarPastaOrigem.Text = "Selecionar Pasta de Origem";
            this.btnSelecionarPastaOrigem.UseVisualStyleBackColor = true;
            this.btnSelecionarPastaOrigem.Click += new System.EventHandler(this.btnSelecionarPastaOrigem_Click);
            // 
            // btnSelecionarPastaDestino
            // 
            this.btnSelecionarPastaDestino.Location = new System.Drawing.Point(148, 118);
            this.btnSelecionarPastaDestino.Name = "btnSelecionarPastaDestino";
            this.btnSelecionarPastaDestino.Size = new System.Drawing.Size(153, 35);
            this.btnSelecionarPastaDestino.TabIndex = 1;
            this.btnSelecionarPastaDestino.Text = "Selecionar Pasta de Destino";
            this.btnSelecionarPastaDestino.UseVisualStyleBackColor = true;
            this.btnSelecionarPastaDestino.Click += new System.EventHandler(this.btnSelecionarPastaDestino_Click);
            // 
            // txtPastaOrigem
            // 
            this.txtPastaOrigem.Enabled = false;
            this.txtPastaOrigem.Location = new System.Drawing.Point(43, 83);
            this.txtPastaOrigem.Name = "txtPastaOrigem";
            this.txtPastaOrigem.Size = new System.Drawing.Size(362, 20);
            this.txtPastaOrigem.TabIndex = 2;
            // 
            // txtPastaDestino
            // 
            this.txtPastaDestino.Enabled = false;
            this.txtPastaDestino.Location = new System.Drawing.Point(43, 159);
            this.txtPastaDestino.Name = "txtPastaDestino";
            this.txtPastaDestino.Size = new System.Drawing.Size(362, 20);
            this.txtPastaDestino.TabIndex = 3;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(148, 226);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(153, 27);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(97, 259);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(255, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 316);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(443, 314);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtPastaDestino);
            this.Controls.Add(this.txtPastaOrigem);
            this.Controls.Add(this.btnSelecionarPastaDestino);
            this.Controls.Add(this.btnSelecionarPastaOrigem);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionarPastaOrigem;
        private System.Windows.Forms.Button btnSelecionarPastaDestino;
        private System.Windows.Forms.TextBox txtPastaOrigem;
        private System.Windows.Forms.TextBox txtPastaDestino;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

