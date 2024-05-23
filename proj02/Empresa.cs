namespace proj02{

    public class Empresa{

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Telefone{ get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        
        public Empresa (string razaoSocial, string cnpj, string telefone, string endereco, string email, bool status){
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.Email = email;
            this.Status = status;
        }
    }
}
