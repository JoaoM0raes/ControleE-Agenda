namespace ControleTarefas
{
    partial class items
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.tiutlo = new System.Windows.Forms.Label();
            this.listItemsDaTarefa = new System.Windows.Forms.ListBox();
            this.Labeltitulo = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.labelTituloTarefa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(301, 184);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancel";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(208, 184);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(87, 23);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar ";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // tiutlo
            // 
            this.tiutlo.AutoSize = true;
            this.tiutlo.Location = new System.Drawing.Point(12, 23);
            this.tiutlo.Name = "tiutlo";
            this.tiutlo.Size = new System.Drawing.Size(35, 15);
            this.tiutlo.TabIndex = 8;
            this.tiutlo.Text = "titulo";
            // 
            // listItemsDaTarefa
            // 
            this.listItemsDaTarefa.FormattingEnabled = true;
            this.listItemsDaTarefa.ItemHeight = 15;
            this.listItemsDaTarefa.Location = new System.Drawing.Point(12, 84);
            this.listItemsDaTarefa.Name = "listItemsDaTarefa";
            this.listItemsDaTarefa.Size = new System.Drawing.Size(376, 94);
            this.listItemsDaTarefa.TabIndex = 9;
            // 
            // Labeltitulo
            // 
            this.Labeltitulo.Location = new System.Drawing.Point(12, 51);
            this.Labeltitulo.Name = "Labeltitulo";
            this.Labeltitulo.Size = new System.Drawing.Size(283, 23);
            this.Labeltitulo.TabIndex = 10;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(301, 50);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(87, 23);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // labelTituloTarefa
            // 
            this.labelTituloTarefa.AutoSize = true;
            this.labelTituloTarefa.Location = new System.Drawing.Point(53, 23);
            this.labelTituloTarefa.Name = "labelTituloTarefa";
            this.labelTituloTarefa.Size = new System.Drawing.Size(79, 15);
            this.labelTituloTarefa.TabIndex = 12;
            this.labelTituloTarefa.Text = "{Titulo Tarefa}";
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 258);
            this.Controls.Add(this.labelTituloTarefa);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.Labeltitulo);
            this.Controls.Add(this.listItemsDaTarefa);
            this.Controls.Add(this.tiutlo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Name = "items";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label tiutlo;
        private System.Windows.Forms.ListBox listItemsDaTarefa;
        private System.Windows.Forms.TextBox Labeltitulo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label labelTituloTarefa;
    }
}