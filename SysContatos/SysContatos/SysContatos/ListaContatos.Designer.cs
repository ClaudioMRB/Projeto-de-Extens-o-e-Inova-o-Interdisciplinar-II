namespace SysContatos
{
    partial class ListaContatos
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
            tblListaContatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tblListaContatos).BeginInit();
            SuspendLayout();
            // 
            // tblListaContatos
            // 
            tblListaContatos.AllowUserToAddRows = false;
            tblListaContatos.AllowUserToDeleteRows = false;
            tblListaContatos.AllowUserToOrderColumns = true;
            tblListaContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblListaContatos.Location = new Point(12, 12);
            tblListaContatos.Name = "tblListaContatos";
            tblListaContatos.ReadOnly = true;
            tblListaContatos.RowTemplate.Height = 25;
            tblListaContatos.Size = new Size(776, 426);
            tblListaContatos.TabIndex = 0;
            // 
            // ListaContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblListaContatos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ListaContatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de contatos salvos";
            ((System.ComponentModel.ISupportInitialize)tblListaContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tblListaContatos;
    }
}