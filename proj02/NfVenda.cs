
namespace proj02
{
    public class NfVenda : NotaFiscal
    {
        public string Vendedor { get; set; }
        
        public NfVenda (string vendedor) : base( produto, quantidade, cliente, numeroNf)
        {
            this.Vendedor = vendedor;
        }

        public bool ReceberVenda(){

        }
        
    } 
}
