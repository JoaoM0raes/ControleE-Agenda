namespace ControleEAgenda.ControleDeCompromissos
{
    partial class Vizualizar_compormissos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listCompormissosFuturos = new System.Windows.Forms.ListBox();
            this.listCompromissosPassados = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePrimeiraData = new System.Windows.Forms.DateTimePicker();
            this.dateTimeSegundaData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Compromissos Futuros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Compromissos Passados";
            // 
            // listCompormissosFuturos
            // 
            this.listCompormissosFuturos.FormattingEnabled = true;
            this.listCompormissosFuturos.ItemHeight = 15;
            this.listCompormissosFuturos.Location = new System.Drawing.Point(12, 334);
            this.listCompormissosFuturos.Name = "listCompormissosFuturos";
            this.listCompormissosFuturos.Size = new System.Drawing.Size(598, 169);
            this.listCompormissosFuturos.TabIndex = 12;
            // 
            // listCompromissosPassados
            // 
            this.listCompromissosPassados.FormattingEnabled = true;
            this.listCompromissosPassados.ItemHeight = 15;
            this.listCompromissosPassados.Location = new System.Drawing.Point(12, 60);
            this.listCompromissosPassados.Name = "listCompromissosPassados";
            this.listCompromissosPassados.Size = new System.Drawing.Size(598, 169);
            this.listCompromissosPassados.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vizualizar Compromissos";
            // 
            // dateTimePrimeiraData
            // 
            this.dateTimePrimeiraData.Location = new System.Drawing.Point(67, 305);
            this.dateTimePrimeiraData.Name = "dateTimePrimeiraData";
            this.dateTimePrimeiraData.Size = new System.Drawing.Size(200, 23);
            this.dateTimePrimeiraData.TabIndex = 17;
            // 
            // dateTimeSegundaData
            // 
            this.dateTimeSegundaData.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimeSegundaData.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimeSegundaData.Location = new System.Drawing.Point(309, 305);
            this.dateTimeSegundaData.Name = "dateTimeSegundaData";
            this.dateTimeSegundaData.Size = new System.Drawing.Size(200, 23);
            this.dateTimeSegundaData.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(273, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Para";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "De";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.button1.Location = new System.Drawing.Point(491, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(538, 304);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(72, 24);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Vizualizar_compormissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 582);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeSegundaData);
            this.Controls.Add(this.dateTimePrimeiraData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCompormissosFuturos);
            this.Controls.Add(this.listCompromissosPassados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vizualizar_compormissos";
            this.Text = "Vizualizar_compormissos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCompormissosFuturos;
        private System.Windows.Forms.ListBox listCompromissosPassados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePrimeiraData;
        private System.Windows.Forms.DateTimePicker dateTimeSegundaData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPesquisar;
    }
}