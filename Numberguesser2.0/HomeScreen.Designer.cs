namespace Numberguesser2._0
{
    partial class HomeScreen
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
            this.lblBV = new System.Windows.Forms.Label();
            this.lblNG = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBV
            // 
            this.lblBV.AutoSize = true;
            this.lblBV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBV.Location = new System.Drawing.Point(263, 53);
            this.lblBV.Name = "lblBV";
            this.lblBV.Size = new System.Drawing.Size(146, 25);
            this.lblBV.TabIndex = 0;
            this.lblBV.Text = "Bem-Vindo a";
            // 
            // lblNG
            // 
            this.lblNG.AutoSize = true;
            this.lblNG.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNG.Location = new System.Drawing.Point(224, 78);
            this.lblNG.Name = "lblNG";
            this.lblNG.Size = new System.Drawing.Size(234, 39);
            this.lblNG.TabIndex = 1;
            this.lblNG.Text = "Number Guesser";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(268, 161);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(141, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(253, 142);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(177, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Digite seu nome para iniciar:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(268, 200);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(141, 41);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Começar!!";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 300);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNG);
            this.Controls.Add(this.lblBV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBV;
        private System.Windows.Forms.Label lblNG;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnIniciar;
    }
}

