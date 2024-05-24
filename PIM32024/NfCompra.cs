

namespace PIM32024
{
    public class NfCompra : NotaFiscal
    {
        public string Comprador { get; set; }
        
        public NfCompra (string comprador, string numeroNf,  DateTime dataPedido,  Cliente cliente,  double valorTot,  string status,  Pagamento formasPagamento,  Produtos produto,  int quantidade) : base( numeroNf, dataPedido, cliente, valorTot, status, formasPagamento, produto, quantidade)
        {
            this.Comprador = comprador;
        }

        // public void AcompanharStatus(){

        // }

        
    } 
}
