public class Contato
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Celular { get; set; }
    public string Email { get; set; }
    public string Tipo { get; set; }

    // Construtor vazio
    public Contato() { }

    // Construtor com parâmetros
    public Contato(string nome, string telefone, string celular, string email, string tipo)
    {
        Nome = nome;
        Telefone = telefone;
        Celular = celular;
        Email = email;
        Tipo = tipo;
    }
}
