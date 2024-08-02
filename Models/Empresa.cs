namespace Atividade3.Models
{
    public class Empresa
    {
        public static string Nome = "Strogonoff Land Ltda.";
        public static List<Produto> Produtos;
        public static List<Pedido> Pedidos;

        public Empresa()
        {
            Produtos = new List<Produto>();
            Pedidos = new List<Pedido>();

            Produtos.Add(new Produto(1, "Strogonoff de Carne", 29.90f));
            Produtos.Add(new Produto(2, "Strogonoff de Frango", 27.90f));
            Produtos.Add(new Produto(3, "Strogonoff Vegano", 24.90f));
            Produtos.Add(new Produto(4, "Strogonoff de Camarão", 34.90f));
            Produtos.Add(new Produto(5, "Strogonoff de Cogumelos", 26.90f));
            Produtos.Add(new Produto(6, "Strogonoff de Linguiça", 28.90f));
            Produtos.Add(new Produto(7, "Strogonoff de Costela", 32.90f));
            Produtos.Add(new Produto(8, "Strogonoff de Peito de Peru", 30.90f));
            Produtos.Add(new Produto(9, "Strogonoff de Tofu", 25.90f));
            Produtos.Add(new Produto(10, "Strogonoff com Batata Palha", 29.90f));
            Produtos.Add(new Produto(11, "Strogonoff de Porco", 28.90f));
            Produtos.Add(new Produto(12, "Strogonoff de Berinjela", 23.90f));
            Produtos.Add(new Produto(13, "Strogonoff de Picanha", 35.90f));
            Produtos.Add(new Produto(14, "Strogonoff de Frutos do Mar", 39.90f));
            Produtos.Add(new Produto(15, "Strogonoff de Abóbora", 24.90f));
            Produtos.Add(new Produto(16, "Strogonoff de Carne Seca", 31.90f));
            Produtos.Add(new Produto(17, "Strogonoff de Atum", 27.90f));
            Produtos.Add(new Produto(18, "Strogonoff de Salsicha", 21.90f));
            Produtos.Add(new Produto(19, "Strogonoff de Carne de Sol", 33.90f));
            Produtos.Add(new Produto(20, "Strogonoff de Legumes", 22.90f));

            Cliente laura = new Cliente("Laura Mariana", 123456, "Rua dos Bobos, 0", "+55 41 99999-9999", "laura@mariana.com");

            Pedido meuPedido = new Pedido(1, "Não Enviado", DateTime.Now, "Longhi", laura);
            meuPedido.AdicionarProduto(Produtos[2]);
            meuPedido.AdicionarProduto(Produtos[5]);
            meuPedido.AdicionarProduto(Produtos[12]);
            Pedidos.Add(meuPedido);
        }
    }
}
