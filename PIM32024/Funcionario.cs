using System;
namespace PIM32024
{

    // Definição da classe Usuario
    public class Funcionario : Usuario
    {
        public string SenhaBackDoor { get; set; }
        public string NumeroCarteira { get; set; }

        public Funcionario (string senhaBackDoor, string numeroCarteira, string nome, string email, string senha, NivelAcesso nivelAcesso, DateTime dataNascimento, string endereco, string telefone, Cargos cargo) : base (nome, email, senha, nivelAcesso, dataNascimento, endereco, telefone, cargo){
            this.NumeroCarteira = numeroCarteira;
            this.SenhaBackDoor = senhaBackDoor;
        }

        // public void Cadastro(string nome, string email, string senha, NivelAcesso nivelAcesso, DateTime dataNascimento, string endereco, string telefone, NivelAcesso nivelAcesso)

        // public void RegistrarPlantio(Date dataInicio);

        // public void ConsumirItens(Item item, int quantidade);

        // public bool RegistrarColheita(produtos produto, Date dataTermino, string lote);

        // public bool AcessoBackDoor(string senhaBackDoor);

        // public void FazerVenda(Produtos produto);

        // public void FazerCompra(Produto produto);

        // public bool RegistrarFuncionario(Usuario usuario, Cargo cargo);

    }
}