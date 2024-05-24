namespace PIM32024{

    public class Cliente : Empresa{

        public Cliente(string razaoSocial, string cnpj, string telefone, string endereco, string email, bool status) : base (razaoSocial, cnpj, telefone, endereco, email, status)
        {

        }

        public void ListaClientes(){
            Console.WriteLine($"{RazaoSocial} | {Cnpj} | {Telefone} | {Endereco} | {Email} | {(Status == true ? "Ativo" : "Desativado")} ");
        }

    }
}

//colocar mais atributos;
