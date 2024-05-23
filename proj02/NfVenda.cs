
namespace proj02
{
    public class NfVenda : NotaFiscal
    {
        public string Vendedor { get; set; }// vendedor vendedor
        
        public NfVenda (string vendedor, string numeroNf,  DateTime dataPedido,  Cliente cliente,  double valorTot,  string status,  Pagamento formasPagamento,  Produtos produto,  int quantidade) : base( numeroNf, dataPedido, cliente, valorTot, status, formasPagamento, produto, quantidade)
        {
            this.Vendedor = vendedor;
        }

        // public bool ReceberVenda(){

        // }
        
    } 
}
