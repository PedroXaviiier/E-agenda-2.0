namespace E_agenda_2._0.Telas.Contato
{
    partial class TelaContato
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
            this.Contatos = new System.Windows.Forms.ListBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Contatos
            // 
            this.Contatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contatos.FormattingEnabled = true;
            this.Contatos.ItemHeight = 21;
            this.Contatos.Location = new System.Drawing.Point(8, 94);
            this.Contatos.Name = "Contatos";
            this.Contatos.Size = new System.Drawing.Size(824, 319);
            this.Contatos.TabIndex = 22;
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSair.Location = new System.Drawing.Point(769, 21);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(63, 42);
            this.BtnSair.TabIndex = 26;
            this.BtnSair.Text = "Voltar";
            this.BtnSair.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluir.Location = new System.Drawing.Point(504, 21);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(242, 42);
            this.BtnExcluir.TabIndex = 25;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.Location = new System.Drawing.Point(256, 21);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(242, 42);
            this.BtnEditar.TabIndex = 24;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnInserir
            // 
            this.BtnInserir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnInserir.Location = new System.Drawing.Point(8, 21);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(242, 42);
            this.BtnInserir.TabIndex = 23;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            // 
            // TelaContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 429);
            this.Controls.Add(this.Contatos);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnInserir);
            this.Name = "TelaContato";
            this.Text = "TelaCadastroContato";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Contatos;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnInserir;
    }
}