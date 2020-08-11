namespace Split
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
            this.txtColunaA = new System.Windows.Forms.RichTextBox();
            this.txtColunaB = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtColunaC = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtColunaA
            // 
            this.txtColunaA.Location = new System.Drawing.Point(22, 24);
            this.txtColunaA.Name = "txtColunaA";
            this.txtColunaA.Size = new System.Drawing.Size(243, 253);
            this.txtColunaA.TabIndex = 0;
            this.txtColunaA.Text = "";
            // 
            // txtColunaB
            // 
            this.txtColunaB.Location = new System.Drawing.Point(281, 24);
            this.txtColunaB.Name = "txtColunaB";
            this.txtColunaB.Size = new System.Drawing.Size(243, 253);
            this.txtColunaB.TabIndex = 1;
            this.txtColunaB.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtColunaC
            // 
            this.txtColunaC.Location = new System.Drawing.Point(22, 293);
            this.txtColunaC.Name = "txtColunaC";
            this.txtColunaC.Size = new System.Drawing.Size(502, 169);
            this.txtColunaC.TabIndex = 3;
            this.txtColunaC.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.txtColunaC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtColunaB);
            this.Controls.Add(this.txtColunaA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtColunaA;
        private System.Windows.Forms.RichTextBox txtColunaB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtColunaC;
    }
}

