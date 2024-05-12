

namespace proj02
{
    public class NotaFiscal
    {
        public string NumeroNf { get; set; }
        public DateTime DataPedido { get; set; }
        public string Cliente { get; set; }
        public double ValorTot { get; set; }

        public string Status { get; set; }
        public Pagamento FormasPagamento { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }


        public NotaFiscal(string produto, int quantidade, string cliente, string numeroNf)
        {
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.Cliente = cliente;
            this.NumeroNf = numeroNf;

        }

        //public void CriarNotaFiscal(string produto, int quantidade, string cliente, string numeroNf)

        public void GerarRelatorio()
        {

        }

        // public override string ToString()
        // {
        //     return "[ produto:  " + this.Produto + ", quantidade: " + this.Quantidade + 
        //         ", cliente: " + this.Cliente + ", numeroNf" + this.NumeroNf + " ] "; 
        // }
    } 
}
