

namespace proj02
{
    public class Credito : Cartao
    {
        public int Parcelas { get; set; }

        public Credito  (int parcelas, long numero, string bandeira, double valor): base (numero ,bandeira, valor){
            this.Parcelas = parcelas;
        }
    }
}
