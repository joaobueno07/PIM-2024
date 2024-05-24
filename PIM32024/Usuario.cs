using System;
namespace PIM32024
{

    // Definição da classe Usuario
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public NivelAcesso NivelAcesso { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public Cargos Cargo { get; set; }

        public Usuario(string nome, string email, string senha, NivelAcesso nivelAcesso, DateTime dataNascimento, string endereco, string telefone, Cargos cargo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            NivelAcesso = nivelAcesso;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Telefone = telefone;
            Cargo = cargo;
        }

        // Método para realizar o cadastro de um usuário
        public void Cadastro(){
            Console.WriteLine($"{Nome} | {Email} | {Senha, -5} | {Cargo.Descricao} | {NivelAcesso.Descricao,-15} | {DataNascimento,-10} | {Endereco} | {Telefone}");
            // Console.WriteLine($"Oberservacao");
            // foreach (var item in NivelAcesso.Permissoes)
            // {
            //     Console.WriteLine($"||\tPermissoes {item}");
            // }
            // Console.WriteLine("\n==========================================================================================");
            // Console.WriteLine("|||||||||||||||||||||||||||||||Cadastrado com Sucesso!||||||||||||||||||||||||||||||||||||");
            // Console.WriteLine("\n==========================================================================================");

        }

        public void Login( string email, string senha)
        {
            Console.WriteLine("############################# Login realizado com sucesso! ############################## ");
        }
    }
}