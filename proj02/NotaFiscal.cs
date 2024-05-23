

namespace proj02
{
    public class NotaFiscal
    {
        public string NumeroNf { get; set; }
        public DateTime DataPedido { get; set; }
        public Cliente Cliente { get; set; }
        public double ValorTot { get; set; }
        public string Status { get; set; }
        public Pagamento FormasPagamento { get; set; }
        public Produtos Produto { get; set; }
        public int Quantidade { get; set; }


        public NotaFiscal(string numeroNf,  DateTime dataPedido,  Cliente cliente,  double valorTot,  string status,  Pagamento formasPagamento,  Produtos produto,  int quantidade)
        {
            this.NumeroNf = numeroNf;
            this.DataPedido = dataPedido;
            this.Cliente = cliente;
            this.ValorTot = valorTot;
            this.Status = status;
            this.FormasPagamento = formasPagamento;
            this.Produto = produto;
            this.Quantidade = quantidade;

        }

        //public void CriarNotaFiscal(string produto, int quantidade, string cliente, string numeroNf)

        // public void GerarRelatorio()
        // {

        // }

        // public override string ToString()
        // {
        //     return "[ produto:  " + this.Produto + ", quantidade: " + this.Quantidade + 
        //         ", cliente: " + this.Cliente + ", numeroNf" + this.NumeroNf + " ] "; 
        // }
    } 
}
