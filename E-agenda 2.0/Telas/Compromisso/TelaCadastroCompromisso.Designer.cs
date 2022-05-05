namespace E_agenda_2._0.Telas.Compromisso
{
    partial class TelaCadastroCompromisso
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
            this.ListaDeContatos = new System.Windows.Forms.ListBox();
            this.textBoxTerminoHrs = new System.Windows.Forms.TextBox();
            this.textBoxHoraIhrs = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.textBoxAssunto = new System.Windows.Forms.TextBox();
            this.lblHorasTermino = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblHoraFim = new System.Windows.Forms.Label();
            this.labelHorasI = new System.Windows.Forms.Label();
            this.labelHorario = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaDeContatos
            // 
            this.ListaDeContatos.FormattingEnabled = true;
            this.ListaDeContatos.ItemHeight = 15;
            this.ListaDeContatos.Location = new System.Drawing.Point(17, 128);
            this.ListaDeContatos.Name = "ListaDeContatos";
            this.ListaDeContatos.Size = new System.Drawing.Size(391, 274);
            this.ListaDeContatos.TabIndex = 21;
            // 
            // textBoxTerminoHrs
            // 
            this.textBoxTerminoHrs.Location = new System.Drawing.Point(426, 68);
            this.textBoxTerminoHrs.Name = "textBoxTerminoHrs";
            this.textBoxTerminoHrs.Size = new System.Drawing.Size(42, 23);
            this.textBoxTerminoHrs.TabIndex = 17;
            // 
            // textBoxHoraIhrs
            // 
            this.textBoxHoraIhrs.Location = new System.Drawing.Point(268, 70);
            this.textBoxHoraIhrs.Name = "textBoxHoraIhrs";
            this.textBoxHoraIhrs.Size = new System.Drawing.Size(42, 23);
            this.textBoxHoraIhrs.TabIndex = 16;
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(89, 70);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(135, 23);
            this.textBoxData.TabIndex = 15;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(89, 41);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(411, 23);
            this.textBoxLocal.TabIndex = 20;
            // 
            // textBoxAssunto
            // 
            this.textBoxAssunto.Location = new System.Drawing.Point(89, 12);
            this.textBoxAssunto.Name = "textBoxAssunto";
            this.textBoxAssunto.Size = new System.Drawing.Size(411, 23);
            this.textBoxAssunto.TabIndex = 14;
            // 
            // lblHorasTermino
            // 
            this.lblHorasTermino.AutoSize = true;
            this.lblHorasTermino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHorasTermino.Location = new System.Drawing.Point(474, 68);
            this.lblHorasTermino.Name = "lblHorasTermino";
            this.lblHorasTermino.Size = new System.Drawing.Size(32, 21);
            this.lblHorasTermino.TabIndex = 11;
            this.lblHorasTermino.Text = "hrs";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContato.Location = new System.Drawing.Point(17, 104);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(189, 21);
            this.lblContato.TabIndex = 9;
            this.lblContato.Text = "Contato do Compromisso";
            // 
            // lblHoraFim
            // 
            this.lblHoraFim.AutoSize = true;
            this.lblHoraFim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraFim.Location = new System.Drawing.Point(354, 68);
            this.lblHoraFim.Name = "lblHoraFim";
            this.lblHoraFim.Size = new System.Drawing.Size(66, 21);
            this.lblHoraFim.TabIndex = 8;
            this.lblHoraFim.Text = "Término";
            // 
            // labelHorasI
            // 
            this.labelHorasI.AutoSize = true;
            this.labelHorasI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHorasI.Location = new System.Drawing.Point(316, 68);
            this.labelHorasI.Name = "labelHorasI";
            this.labelHorasI.Size = new System.Drawing.Size(46, 21);
            this.labelHorasI.TabIndex = 7;
            this.labelHorasI.Text = "hrs - ";
            // 
            // labelHorario
            // 
            this.labelHorario.AutoSize = true;
            this.labelHorario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHorario.Location = new System.Drawing.Point(224, 68);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(47, 21);
            this.labelHorario.TabIndex = 6;
            this.labelHorario.Text = "Início";
            this.labelHorario.Click += new System.EventHandler(this.labelHorario_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.Location = new System.Drawing.Point(17, 68);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 21);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocal.Location = new System.Drawing.Point(17, 39);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(46, 21);
            this.lblLocal.TabIndex = 12;
            this.lblLocal.Text = "Local";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAssunto.Location = new System.Drawing.Point(17, 10);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(66, 21);
            this.lblAssunto.TabIndex = 13;
            this.lblAssunto.Text = "Assunto";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(507, 377);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(74, 42);
            this.BtnSair.TabIndex = 22;
            this.BtnSair.Text = "Voltar";
            this.BtnSair.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaCadastroCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.ListaDeContatos);
            this.Controls.Add(this.textBoxTerminoHrs);
            this.Controls.Add(this.textBoxHoraIhrs);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.textBoxAssunto);
            this.Controls.Add(this.lblHorasTermino);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblHoraFim);
            this.Controls.Add(this.labelHorasI);
            this.Controls.Add(this.labelHorario);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblAssunto);
            this.Name = "TelaCadastroCompromisso";
            this.Text = "TelaCadastroCompromisso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListaDeContatos;
        private System.Windows.Forms.TextBox textBoxTerminoHrs;
        private System.Windows.Forms.TextBox textBoxHoraIhrs;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.TextBox textBoxAssunto;
        private System.Windows.Forms.Label lblHorasTermino;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Label lblHoraFim;
        private System.Windows.Forms.Label labelHorasI;
        private System.Windows.Forms.Label labelHorario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button button1;
    }
}