namespace E_agenda_2._0.Telas
{
    partial class TelaTarefas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TarefasPendentes = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TarefasConcluidas = new System.Windows.Forms.ListBox();
            this.BtnEditarItem = new System.Windows.Forms.Button();
            this.BtnInserirItem = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 356);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TarefasPendentes);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tarefas Pendentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TarefasPendentes
            // 
            this.TarefasPendentes.FormattingEnabled = true;
            this.TarefasPendentes.ItemHeight = 21;
            this.TarefasPendentes.Location = new System.Drawing.Point(6, 6);
            this.TarefasPendentes.Name = "TarefasPendentes";
            this.TarefasPendentes.Size = new System.Drawing.Size(812, 319);
            this.TarefasPendentes.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TarefasConcluidas);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas Concluídas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TarefasConcluidas
            // 
            this.TarefasConcluidas.FormattingEnabled = true;
            this.TarefasConcluidas.ItemHeight = 21;
            this.TarefasConcluidas.Location = new System.Drawing.Point(6, 8);
            this.TarefasConcluidas.Name = "TarefasConcluidas";
            this.TarefasConcluidas.Size = new System.Drawing.Size(812, 319);
            this.TarefasConcluidas.TabIndex = 7;
            // 
            // BtnEditarItem
            // 
            this.BtnEditarItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEditarItem.Location = new System.Drawing.Point(586, 12);
            this.BtnEditarItem.Name = "BtnEditarItem";
            this.BtnEditarItem.Size = new System.Drawing.Size(131, 42);
            this.BtnEditarItem.TabIndex = 12;
            this.BtnEditarItem.Text = "Atualizar Itens";
            this.BtnEditarItem.UseVisualStyleBackColor = true;
            // 
            // BtnInserirItem
            // 
            this.BtnInserirItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnInserirItem.Location = new System.Drawing.Point(445, 12);
            this.BtnInserirItem.Name = "BtnInserirItem";
            this.BtnInserirItem.Size = new System.Drawing.Size(131, 42);
            this.BtnInserirItem.TabIndex = 11;
            this.BtnInserirItem.Text = "Inserir Itens";
            this.BtnInserirItem.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluir.Location = new System.Drawing.Point(258, 12);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(112, 42);
            this.BtnExcluir.TabIndex = 10;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.Location = new System.Drawing.Point(140, 12);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(112, 42);
            this.BtnEditar.TabIndex = 9;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnInserir
            // 
            this.BtnInserir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnInserir.Location = new System.Drawing.Point(22, 12);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(112, 42);
            this.BtnInserir.TabIndex = 8;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSair.Location = new System.Drawing.Point(781, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(63, 42);
            this.BtnSair.TabIndex = 14;
            this.BtnSair.Text = "Voltar";
            this.BtnSair.UseVisualStyleBackColor = true;
            // 
            // TelaTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 437);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtnEditarItem);
            this.Controls.Add(this.BtnInserirItem);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnInserir);
            this.Name = "TelaTarefas";
            this.Text = "MenuTarefas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox TarefasPendentes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox TarefasConcluidas;
        private System.Windows.Forms.Button BtnEditarItem;
        private System.Windows.Forms.Button BtnInserirItem;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnSair;
    }
}