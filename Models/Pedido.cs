namespace ProjetoCrudMVC.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public decimal ValorTotal { get; set; }

        public string Status { get; set; }

        public string FormaPagamento { get; set; }

        public string Observacao { get; set; }
    }
}
