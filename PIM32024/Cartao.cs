

namespace PIM32024
{
    public class Cartao : Pagamento
    {
        public long Numero { get; set; }
        public string Bandeira { get; set; }

        public Cartao (long numero, string bandeira, double valor) : base(valor){
            this.Numero = numero;
            this.Bandeira = bandeira;
        }
    }
}
