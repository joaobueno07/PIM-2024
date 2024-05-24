using System;


namespace PIM32024
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n\n_____________________________________________________________________________________________________________________________________");
            Console.WriteLine("\t\t\t\t\t\t\t\tIniciando o programa...");
            Console.WriteLine($"_____________________________________________________________________________________________________________________________________\n\n");

            Cargos cargo = new Cargos(true, "administrativo", 3000.00);
            NivelAcesso nivelAcesso = new NivelAcesso("Administrador", new List<string> { "Ler", "Escrever", "Excluir" });
            DateTime dataNascimento = new DateTime(1990, 5, 24);
            List<Usuario> usuarios = new List<Usuario>();
            for (int i = 0; i < 5; i++)
            {
                string nome = $"Usuario {i+1}";
                string email = $"usuario{i+1}@example.com";
                string senha = "senha123";
                string endereco = $"Rua {i+1}, Cidade";
                string telefone = $"(00) 1234-567{i+1}";

                usuarios.Add(new Usuario(nome, email, senha, nivelAcesso, dataNascimento, endereco, telefone, cargo));
            }
            Console.WriteLine("\n============================================================= Usuario ===============================================================");
            Console.WriteLine($"{"Nome", -9} | {"Email", -20} | {"Senha", -8} | {"Cargo", -14} | {"Nivel Descricao", -15} | {"DataNascimento", -19} | {"Endereco",-13} | {"Telefone", -15}");
            Console.WriteLine($"_____________________________________________________________________________________________________________________________________");
            foreach(var item in usuarios){
                item.Cadastro();
            }
            Console.WriteLine($"_____________________________________________________________________________________________________________________________________");

            // usuarios.Cadastro();

            // usuarios.Login("Maria@gmail.com", "1230");

            Console.WriteLine("\n================================== Produtos ==============================================");
            List<Produtos> produto = new List<Produtos>();
            DateTime dataValidade = new DateTime(2024, 6, 25);

            produto.Add(new Produtos("Alface", "Hidroponica", 3.99, "crespa", 0.55, dataValidade, 500, 2000));
            produto.Add(new Produtos("Alface", "Hidroponica", 4.29, "Lisa", 0.50, dataValidade, 300, 2001));
            produto.Add(new Produtos("Rúcula", "Orgânica", 2.99, "Comum", 0.35, dataValidade, 400, 2002));
            produto.Add(new Produtos("Espinafre", "Orgânico", 3.49, "Comum", 0.45, dataValidade, 250, 2003));
            produto.Add(new Produtos("Couve", "Convencional", 2.79, "Manteiga", 0.60, dataValidade, 600, 2004));
            produto.Add(new Produtos("Agrião", "Orgânico", 2.49, "Comum", 0.30, dataValidade, 350, 2005));
            Console.WriteLine($"{"Nome", -13}| {"Descricao", -11}   | {"PrecoVenda", -10} | {"Tipo", -7}   | {"CustoCompra",-5} | DataValidade ");
            Console.WriteLine($"__________________________________________________________________________________________");
            foreach (var item in produto)
            {
                Console.WriteLine($"{item.Nome,-9}    | {item.Descricao, -13} | {item.PrecoVenda}       | {item.Tipo, -9} | {item.CustoCompra, -5}        | {item.DataValidade}");
            }
            Console.WriteLine("\n============================================================================================");
            
            Console.WriteLine("\n==================================== Clientes ==============================================");
            List<Cliente> clientes = new List<Cliente>();
            List<Fornecedor> Fornecedores = new List<Fornecedor>();

            for(int i = 0; i<8; i++){
                string razaoSocial = $"razaoSocial{i}";
                string cnpj = $"03 1{i+1} 0001/0{i}";
                string telefone = $"(16) 33{i}5 123{i+1}";
                string email1 = $"Cliente{i}@gmail.com";
                string email2 = $"Fornec{i}@gmail.com";
                string endereco = $"rua nome{i}, N{i}2{i+1}";
                bool status = true;
                clientes.Add(new Cliente(razaoSocial, cnpj, telefone, endereco, email1, status));
                Fornecedores.Add(new Fornecedor(razaoSocial, cnpj, telefone, endereco, email2, status));
            }
            Console.WriteLine($"{"RazaoSocial",-12} | {"Cnpj",-13} | {"Telefone",-14} | {"Endereco",-15} | {"Email",-18} | {"Status"}");
            Console.WriteLine($"____________________________________________________________________________________________");

            foreach(var item in clientes){
                item.ListaClientes();
            }
            Console.WriteLine($"____________________________________________________________________________________________");
             Console.WriteLine("\n================================== Fornecedores =============================================");
             Console.WriteLine($"{"RazaoSocial",-12} | {"Cnpj",-13} | {"Telefone",-14} | {"Endereco",-15} | {"Email",-17} | {"Status"}");
            Console.WriteLine($"____________________________________________________________________________________________");
            foreach(var item in Fornecedores){
                item.ListaFornecedor();
            }
            Console.WriteLine($"____________________________________________________________________________________________");
            

            /*NotaFiscal nf = new NotaFiscal("alface", 1, "Giovana", "123");
            Console.WriteLine(nf);*/
        }
    }
    
}