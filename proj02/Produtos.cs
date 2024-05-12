namespace proj02{

    public class Produtos : Item{

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double PrecoVenda { get; set; }
        public string Tipo { get; set; }
        public double CustoCompra { get; set; }
        public DateTime DataValidade { get; set; }
        
        public Produtos (string nome, string descricacao, double precoVenda, string tipo, double custoCompra, DateTime dataValidade) : base (quantidade, valor){
            this.Nome = nome;
            this.Descricao = descricacao;
            this.PrecoVenda = precoVenda;
            this.Tipo = tipo;
            this.CustoCompra = custoCompra;
            this.DataValidade = dataValidade;
        }
    }
}