namespace ControleTarefas
{
    partial class ControleDeTarefas
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionarItens = new System.Windows.Forms.Button();
            this.BtnAtualizarItens = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tabControlPendentes = new System.Windows.Forms.TabControl();
            this.tabelTarefas = new System.Windows.Forms.TabPage();
            this.listTarefasPendentes = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listTarefasConcluidas = new System.Windows.Forms.ListBox();
            this.tabControlPendentes.SuspendLayout();
            this.tabelTarefas.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 61);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(93, 61);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar ";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(174, 61);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionarItens
            // 
            this.btnAdicionarItens.Location = new System.Drawing.Point(255, 61);
            this.btnAdicionarItens.Name = "btnAdicionarItens";
            this.btnAdicionarItens.Size = new System.Drawing.Size(135, 23);
            this.btnAdicionarItens.TabIndex = 3;
            this.btnAdicionarItens.Text = "Adicionar Itens";
            this.btnAdicionarItens.UseVisualStyleBackColor = true;
            this.btnAdicionarItens.Click += new System.EventHandler(this.btnAdicionarItens_Click);
            // 
            // BtnAtualizarItens
            // 
            this.BtnAtualizarItens.Location = new System.Drawing.Point(396, 61);
            this.BtnAtualizarItens.Name = "BtnAtualizarItens";
            this.BtnAtualizarItens.Size = new System.Drawing.Size(205, 23);
            this.BtnAtualizarItens.TabIndex = 4;
            this.BtnAtualizarItens.Text = "Atualizar Itens";
            this.BtnAtualizarItens.UseVisualStyleBackColor = true;
            this.BtnAtualizarItens.Click += new System.EventHandler(this.BtnAtualizarItens_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnVoltar.Location = new System.Drawing.Point(688, 405);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(99, 33);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // tabControlPendentes
            // 
            this.tabControlPendentes.Controls.Add(this.tabelTarefas);
            this.tabControlPendentes.Controls.Add(this.tabPage2);
            this.tabControlPendentes.Location = new System.Drawing.Point(12, 90);
            this.tabControlPendentes.Name = "tabControlPendentes";
            this.tabControlPendentes.SelectedIndex = 0;
            this.tabControlPendentes.Size = new System.Drawing.Size(775, 320);
            this.tabControlPendentes.TabIndex = 7;
            // 
            // tabelTarefas
            // 
            this.tabelTarefas.Controls.Add(this.listTarefasPendentes);
            this.tabelTarefas.Location = new System.Drawing.Point(4, 24);
            this.tabelTarefas.Name = "tabelTarefas";
            this.tabelTarefas.Padding = new System.Windows.Forms.Padding(3);
            this.tabelTarefas.Size = new System.Drawing.Size(767, 292);
            this.tabelTarefas.TabIndex = 0;
            this.tabelTarefas.Text = "Tarefas Pendentes";
            this.tabelTarefas.UseVisualStyleBackColor = true;
            // 
            // listTarefasPendentes
            // 
            this.listTarefasPendentes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listTarefasPendentes.FormattingEnabled = true;
            this.listTarefasPendentes.ItemHeight = 15;
            this.listTarefasPendentes.Location = new System.Drawing.Point(0, 0);
            this.listTarefasPendentes.Name = "listTarefasPendentes";
            this.listTarefasPendentes.Size = new System.Drawing.Size(764, 289);
            this.listTarefasPendentes.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listTarefasConcluidas);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas Concluidas ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listTarefasConcluidas
            // 
            this.listTarefasConcluidas.FormattingEnabled = true;
            this.listTarefasConcluidas.ItemHeight = 15;
            this.listTarefasConcluidas.Location = new System.Drawing.Point(0, 0);
            this.listTarefasConcluidas.Name = "listTarefasConcluidas";
            this.listTarefasConcluidas.Size = new System.Drawing.Size(764, 289);
            this.listTarefasConcluidas.TabIndex = 8;
            // 
            // ControleDeTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.tabControlPendentes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.BtnAtualizarItens);
            this.Controls.Add(this.btnAdicionarItens);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Name = "ControleDeTarefas";
            this.Text = "Form1";
            this.tabControlPendentes.ResumeLayout(false);
            this.tabelTarefas.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionarItens;
        private System.Windows.Forms.Button BtnAtualizarItens;
        public System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TabControl tabControlPendentes;
        private System.Windows.Forms.TabPage tabelTarefas;
        private System.Windows.Forms.ListBox listTarefasPendentes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listTarefasConcluidas;
    }
}