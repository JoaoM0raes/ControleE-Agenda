namespace ControleEAgenda.ControleDeCompromissos
{
    partial class AdicionarNovoCompromisso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataCompromisso = new System.Windows.Forms.DateTimePicker();
            this.textLocal = new System.Windows.Forms.TextBox();
            this.textAssunto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textHoraIncial = new System.Windows.Forms.TextBox();
            this.textHoraFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listContatos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionando Novo Contato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assunto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data";
            // 
            // dataCompromisso
            // 
            this.dataCompromisso.Location = new System.Drawing.Point(22, 209);
            this.dataCompromisso.Name = "dataCompromisso";
            this.dataCompromisso.Size = new System.Drawing.Size(205, 23);
            this.dataCompromisso.TabIndex = 4;
            // 
            // textLocal
            // 
            this.textLocal.Location = new System.Drawing.Point(22, 148);
            this.textLocal.Name = "textLocal";
            this.textLocal.Size = new System.Drawing.Size(205, 23);
            this.textLocal.TabIndex = 5;
            // 
            // textAssunto
            // 
            this.textAssunto.Location = new System.Drawing.Point(22, 88);
            this.textAssunto.Name = "textAssunto";
            this.textAssunto.Size = new System.Drawing.Size(205, 23);
            this.textAssunto.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Horario Inicial / Término";
            // 
            // textHoraIncial
            // 
            this.textHoraIncial.Location = new System.Drawing.Point(22, 277);
            this.textHoraIncial.Name = "textHoraIncial";
            this.textHoraIncial.Size = new System.Drawing.Size(76, 23);
            this.textHoraIncial.TabIndex = 8;
            // 
            // textHoraFinal
            // 
            this.textHoraFinal.Location = new System.Drawing.Point(104, 277);
            this.textHoraFinal.Name = "textHoraFinal";
            this.textHoraFinal.Size = new System.Drawing.Size(85, 23);
            this.textHoraFinal.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lista Contatos";
            // 
            // listContatos
            // 
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 15;
            this.listContatos.Location = new System.Drawing.Point(22, 335);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(205, 139);
            this.listContatos.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(22, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Gravar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(152, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AdicionarNovoContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 550);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listContatos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textHoraFinal);
            this.Controls.Add(this.textHoraIncial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textAssunto);
            this.Controls.Add(this.textLocal);
            this.Controls.Add(this.dataCompromisso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarNovoContato";
            this.Text = "AdicionarNovoContato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dataCompromisso;
        private System.Windows.Forms.TextBox textLocal;
        private System.Windows.Forms.TextBox textAssunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textHoraIncial;
        private System.Windows.Forms.TextBox textHoraFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listContatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}