using System;
using System.Data;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace SysContatos
{
    public partial class Form1 : Form
    {

        string connectionString = "Server=127.0.0.1;Database=contatos;Uid=admin;Pwd=admin;";



        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (email.Length > 0)
            {
                if (!IsValidEmail(email))
                {

                    // Exibir uma mensagem de erro se o endereço de e-mail não for válido
                    MessageBox.Show("Por favor, insira um endereço de e-mail válido.");
                    return;
                }
            }

            if (txtNome.Text.Length <= 3 || txtTipo.Text.Length <= 3)
            {
                MessageBox.Show("Nome e tipo do contato são obrigatórios.");
                return;
            }

            Contato contato = new Contato(txtNome.Text, telefone.Text, celular.Text, txtEmail.Text, txtTipo.Text);
            ContatoDAO contatoDAO = new ContatoDAO();
            contatoDAO.CadastrarContato(contato);
            limparCampos();

        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTipo.Text = "";
            celular.Clear();
            telefone.Clear();
            celular.Mask = "(00) 00000-0000";
            telefone.Mask = "(00) 0000-0000";


        }

        private bool IsValidEmail(string email)
        {
            try
            {
                // Esta expressão regular valida o formato básico de um endereço de e-mail
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email, pattern);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListaContatos listaContatos = new ListaContatos();
            listaContatos.ShowDialog();
        }
    }
}