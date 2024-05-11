using System;
using System.Collections.Generic;

// Definição da classe Usuario
public class Usuario
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public NivelUsuario NivelAcesso { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }

    public Usuario(string nome, string email, string senha, NivelUsuario nivelAcesso, DateTime dataNascimento, string endereco, string telefone)
    {
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
    {
        // Aqui você pode implementar a lógica para salvar os dados do usuário em algum lugar, como um banco de dados
        Console.WriteLine("Usuário cadastrado com sucesso!");
    }

    // Método para realizar o login de um usuário
    public void Login()
    {
        // Aqui você pode implementar a lógica para verificar as credenciais do usuário e permitir o login
        Console.WriteLine("Login realizado com sucesso!");
    }
}