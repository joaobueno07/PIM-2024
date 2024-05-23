namespace proj02{

    public class Fornecedor : Empresa{

        public Fornecedor(string razaoSocial, string cnpj, string telefone, string endereco, string email, bool status) : base (razaoSocial, cnpj, telefone, endereco, email, status){

        }

        public void ListaFornecedor(){
            Console.WriteLine($"{RazaoSocial} | {Cnpj} | {Telefone} | {Endereco} | {Email} | {(Status == true ? "Ativo" : "Desativado")} ");
        }
    }
}