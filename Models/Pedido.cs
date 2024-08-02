using System.Net.NetworkInformation;

namespace Atividade3.Models
{
    public class Pedido
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public DateTime DataEntrada { get; set; }
        public string Responsavel { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; }

        public Pedido(int id, string status, DateTime entrada, string responsavel, Cliente cliente)
        {
            ID = id;
            Status = status;
            DataEntrada = entrada;
            Responsavel = responsavel;
            Cliente = cliente;
            Produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }
    }
}
