namespace ControleEAgenda
{
    partial class TelaPrincipal
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
            this.BtnTelaPrincipal = new System.Windows.Forms.Button();
            this.btnTelaCompromisso = new System.Windows.Forms.Button();
            this.btnTelaContatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnTelaPrincipal
            // 
            this.BtnTelaPrincipal.Location = new System.Drawing.Point(85, 124);
            this.BtnTelaPrincipal.Name = "BtnTelaPrincipal";
            this.BtnTelaPrincipal.Size = new System.Drawing.Size(105, 46);
            this.BtnTelaPrincipal.TabIndex = 0;
            this.BtnTelaPrincipal.Text = "Tarefas";
            this.BtnTelaPrincipal.UseVisualStyleBackColor = true;
            this.BtnTelaPrincipal.Click += new System.EventHandler(this.BtnTelaPrincipal_Click);
            // 
            // btnTelaCompromisso
            // 
            this.btnTelaCompromisso.Location = new System.Drawing.Point(85, 218);
            this.btnTelaCompromisso.Name = "btnTelaCompromisso";
            this.btnTelaCompromisso.Size = new System.Drawing.Size(105, 46);
            this.btnTelaCompromisso.TabIndex = 1;
            this.btnTelaCompromisso.Text = "Compromissos";
            this.btnTelaCompromisso.UseVisualStyleBackColor = true;
            this.btnTelaCompromisso.Click += new System.EventHandler(this.btnTelaCompromisso_Click);
            // 
            // btnTelaContatos
            // 
            this.btnTelaContatos.Location = new System.Drawing.Point(85, 316);
            this.btnTelaContatos.Name = "btnTelaContatos";
            this.btnTelaContatos.Size = new System.Drawing.Size(105, 46);
            this.btnTelaContatos.TabIndex = 2;
            this.btnTelaContatos.Text = "Contatos";
            this.btnTelaContatos.UseVisualStyleBackColor = true;
            this.btnTelaContatos.Click += new System.EventHandler(this.btnTelaContatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "E-Agenda Menu";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTelaContatos);
            this.Controls.Add(this.btnTelaCompromisso);
            this.Controls.Add(this.BtnTelaPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTelaPrincipal;
        private System.Windows.Forms.Button btnTelaCompromisso;
        private System.Windows.Forms.Button btnTelaContatos;
        private System.Windows.Forms.Label label1;
    }
}