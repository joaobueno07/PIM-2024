

namespace proj02
{
    public class Credito : Cartao
    {
        public int Parcelas { get; set; }

        public Credito  (int parcelas): base (numero ,bandeira){
            this.Parcelas = parcelas;
        }
    }
}
