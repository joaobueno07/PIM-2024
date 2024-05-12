

namespace proj02
{
    public class Cartao : Pagamento
    {
        public long Numero { get; set; }
        public string Bandeira { get; set; }

        public Cartao (long numero, string bandeira) : base(dadosNf){
            this.Numero = numero;
            this.Bandeira = bandeira;
        }
    }
}
