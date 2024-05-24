

namespace PIM32024
{
    public class Boleto : Pagamento
    {
        public long Numero { get; set; }
        public int Parcelas { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }
        public string Destinatario { get; set; }
        public string Remetente { get; set; }

        public Boleto (long numero, int parcelas, string razaoSocial, string endereco, string destinatario, string remetente, double valor) : base(valor){
            this.Numero = numero;
            this.Parcelas = parcelas;
            this.RazaoSocial = razaoSocial;
            this.Endereco = endereco;
            this.Destinatario = destinatario;
            this.Remetente = remetente;
        }
    }
}
