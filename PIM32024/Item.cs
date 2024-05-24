

namespace PIM32024
{
    public class Item
    {
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        public Item(int quantidade, double valor){
            this.Quantidade = quantidade;
            this.Valor = valor;
        }
    }
}
