

namespace proj02
{
    public class Pix : Pagamento
    {
        public string Chave { get; set; }
        public string Nome { get; set; }

        public Pix (string chave, string nome, double valor) : base(valor){
            this.Chave = chave;
            this.Nome = nome;
        }

    }
}
