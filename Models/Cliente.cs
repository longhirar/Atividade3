using System.Runtime.CompilerServices;

namespace Atividade3.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, int cpf, string endereco, string telefone, string email)
        {
            Nome = nome;
            CPF = cpf;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }
    }
}
