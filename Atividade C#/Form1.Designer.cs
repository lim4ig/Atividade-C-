namespace Atividade_C_
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
            this.components = new System.ComponentModel.Container();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.btNumMaior = new System.Windows.Forms.Button();
            this.btNegPosi = new System.Windows.Forms.Button();
            this.btVogConso = new System.Windows.Forms.Button();
            this.btMes = new System.Windows.Forms.Button();
            this.btMedia = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtCampo2 = new System.Windows.Forms.TextBox();
            this.txtCampo3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(43, 107);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(261, 20);
            this.txtCampo.TabIndex = 0;
            this.txtCampo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(9, 10);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btNumMaior
            // 
            this.btNumMaior.Location = new System.Drawing.Point(643, 83);
            this.btNumMaior.Name = "btNumMaior";
            this.btNumMaior.Size = new System.Drawing.Size(124, 66);
            this.btNumMaior.TabIndex = 4;
            this.btNumMaior.Text = " Numero Maior";
            this.btNumMaior.UseVisualStyleBackColor = true;
            this.btNumMaior.Click += new System.EventHandler(this.btNumMaior_Click);
            // 
            // btNegPosi
            // 
            this.btNegPosi.Location = new System.Drawing.Point(506, 83);
            this.btNegPosi.Name = "btNegPosi";
            this.btNegPosi.Size = new System.Drawing.Size(124, 66);
            this.btNegPosi.TabIndex = 7;
            this.btNegPosi.Text = "Negativo ou Positivo";
            this.btNegPosi.UseVisualStyleBackColor = true;
            this.btNegPosi.Click += new System.EventHandler(this.btNegPosi_Click);
            // 
            // btVogConso
            // 
            this.btVogConso.Location = new System.Drawing.Point(506, 171);
            this.btVogConso.Name = "btVogConso";
            this.btVogConso.Size = new System.Drawing.Size(124, 66);
            this.btVogConso.TabIndex = 8;
            this.btVogConso.Text = "Vogal ou Consoante";
            this.btVogConso.UseVisualStyleBackColor = true;
            this.btVogConso.Click += new System.EventHandler(this.btVogConso_Click);
            // 
            // btMes
            // 
            this.btMes.Location = new System.Drawing.Point(643, 171);
            this.btMes.Name = "btMes";
            this.btMes.Size = new System.Drawing.Size(124, 66);
            this.btMes.TabIndex = 9;
            this.btMes.Text = "Mês";
            this.btMes.UseVisualStyleBackColor = true;
            // 
            // btMedia
            // 
            this.btMedia.Location = new System.Drawing.Point(506, 265);
            this.btMedia.Name = "btMedia";
            this.btMedia.Size = new System.Drawing.Size(124, 66);
            this.btMedia.TabIndex = 10;
            this.btMedia.Text = "Média";
            this.btMedia.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(643, 265);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 66);
            this.button7.TabIndex = 11;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // txtCampo2
            // 
            this.txtCampo2.Location = new System.Drawing.Point(43, 195);
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.Size = new System.Drawing.Size(261, 20);
            this.txtCampo2.TabIndex = 12;
            // 
            // txtCampo3
            // 
            this.txtCampo3.Location = new System.Drawing.Point(43, 289);
            this.txtCampo3.Name = "txtCampo3";
            this.txtCampo3.Size = new System.Drawing.Size(261, 20);
            this.txtCampo3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 436);
            this.Controls.Add(this.txtCampo3);
            this.Controls.Add(this.txtCampo2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btMedia);
            this.Controls.Add(this.btMes);
            this.Controls.Add(this.btVogConso);
            this.Controls.Add(this.btNegPosi);
            this.Controls.Add(this.btNumMaior);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCampo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btNumMaior;
        private System.Windows.Forms.Button btNegPosi;
        private System.Windows.Forms.Button btVogConso;
        private System.Windows.Forms.Button btMes;
        private System.Windows.Forms.Button btMedia;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtCampo2;
        private System.Windows.Forms.TextBox txtCampo3;
    }
}

