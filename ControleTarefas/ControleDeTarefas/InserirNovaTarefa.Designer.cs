namespace ControleTarefas
{
    partial class InserirNovaTarefa
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
            this.Nome = new System.Windows.Forms.TextBox();
            this.Gravar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listPrioridade = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(12, 27);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(211, 23);
            this.Nome.TabIndex = 3;
            // 
            // Gravar
            // 
            this.Gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Gravar.Location = new System.Drawing.Point(9, 149);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(87, 34);
            this.Gravar.TabIndex = 4;
            this.Gravar.Text = "Gravar ";
            this.Gravar.UseVisualStyleBackColor = true;
            this.Gravar.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(136, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prioridade";
            // 
            // listPrioridade
            // 
            this.listPrioridade.FormattingEnabled = true;
            this.listPrioridade.ItemHeight = 15;
            this.listPrioridade.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baixa"});
            this.listPrioridade.Location = new System.Drawing.Point(12, 80);
            this.listPrioridade.Name = "listPrioridade";
            this.listPrioridade.Size = new System.Drawing.Size(211, 49);
            this.listPrioridade.TabIndex = 7;
            // 
            // InserirNovaTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 195);
            this.Controls.Add(this.listPrioridade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Gravar);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InserirNovaTarefa";
            this.Text = "Inserir Nova Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Button Gravar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listPrioridade;
    }
}