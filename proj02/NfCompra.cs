

namespace proj02
{
    public class NfCompra : NotaFiscal
    {
        public string Comprador { get; set; }
        
        public NfCompra (string comprador) : base( produto, quantidade, cliente, numeroNf)
        {
            this.Comprador = comprador;
        }

        public void AcompanharStatus(){

        }

        
    } 
}
