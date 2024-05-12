using System;
namespace proj02
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
        public NivelAcesso nivelAcesso { get; set; }


        public Usuario(string nome, string email, string senha, NivelAcesso nivelAcesso, DateTime dataNascimento, string endereco, string telefone, NivelAcesso nivelAcesso)
        {
<<<<<<< Updated upstream
            Nome = nome;
            Email = email;
            Senha = senha;
            NivelAcesso = nivelAcesso;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Telefone = telefone;
        }

        // Método para realizar o cadastro de um usuário
        public void Cadastro()
=======
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.NivelAcesso = nivelAcesso;
            this.DataNascimento = dataNascimento;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.NivelAcesso = nivelAcesso;
            
        }

        public void Login( string email, string senha)
>>>>>>> Stashed changes
        {

            // Console.WriteLine("Login realizado com sucesso!");
        }
    }
}