namespace SysContatos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage1 = new TabPage();
            telefone = new MaskedTextBox();
            celular = new MaskedTextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            txtTipo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            tabControl1 = new TabControl();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(telefone);
            tabPage1.Controls.Add(celular);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtTipo);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(657, 325);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // telefone
            // 
            telefone.Location = new Point(126, 73);
            telefone.Mask = "(00) 0000-0000";
            telefone.Name = "telefone";
            telefone.Size = new Size(234, 23);
            telefone.TabIndex = 14;
            // 
            // celular
            // 
            celular.Location = new Point(124, 117);
            celular.Mask = "(00) 00000-0000";
            celular.Name = "celular";
            celular.Size = new Size(234, 23);
            celular.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(350, 265);
            button3.Name = "button3";
            button3.Size = new Size(162, 23);
            button3.TabIndex = 12;
            button3.Text = "Exibir lista de contatos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(269, 265);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(179, 265);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 197);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 9;
            label5.Text = "Tipo:";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(122, 194);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(236, 23);
            txtTipo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 154);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 114);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Celular:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 73);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Telefone:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(124, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(236, 23);
            txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 33);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(122, 33);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(236, 23);
            txtNome.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(665, 353);
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 377);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de contatos";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private TabControl tabControl1;
        private Label label5;
        private TextBox txtTipo;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtNome;
        private Button button3;
        private Button button2;
        private Button button1;
        private MaskedTextBox telefone;
        private MaskedTextBox celular;
    }
}