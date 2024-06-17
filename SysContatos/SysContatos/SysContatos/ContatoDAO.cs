using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SysContatos
{
    public class ContatoDAO
    {


        string connectionString = "Server=127.0.0.1;Database=contatos;Uid=admin;Pwd=admin;";

        public ContatoDAO()
        {

        }

        public void CadastrarContato(Contato contato)
        {
            string query = "INSERT INTO contatos (nome, telefone, celular, email, tipo) VALUES (@Nome, @Telefone, @Celular, @Email, @Tipo)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Adicione os parâmetros da consulta
                    command.Parameters.AddWithValue("@Nome", contato.Nome);
                    command.Parameters.AddWithValue("@Telefone", contato.Telefone);
                    command.Parameters.AddWithValue("@Celular", contato.Celular);
                    command.Parameters.AddWithValue("@Email", contato.Email);
                    command.Parameters.AddWithValue("@Tipo", contato.Tipo);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} contato inserido com sucesso.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar contato: " + ex.Message);
                    }
                }
            }
        }

        public List<Contato> ObterContatos()
        {
            List<Contato> contatos = new List<Contato>();

            string query = "SELECT * FROM contatos";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Contato contato = new Contato
                                {
                                    Id = reader.GetInt32("id"),
                                    Nome = reader.GetString("nome"),
                                    Telefone = reader.IsDBNull(reader.GetOrdinal("telefone")) ? null : reader.GetString("telefone"),
                                    Celular = reader.IsDBNull(reader.GetOrdinal("celular")) ? null : reader.GetString("celular"),
                                    Email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email"),
                                    Tipo = reader.GetString("tipo")
                                };
                                contatos.Add(contato);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao obter contatos: " + ex.Message);
                    }
                }
            }

            return contatos;
        }
    }
}
