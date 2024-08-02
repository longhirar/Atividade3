namespace Atividade3.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Desc { get; set; }
        public float Valor { get; set; }

        public Produto(int id, string desc, float valor)
        {
            ID = id;
            Desc = desc;
            Valor = valor;
        }
    }
}
