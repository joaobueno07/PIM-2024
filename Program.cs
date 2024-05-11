using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de uso das classes

        // Criando um nível de usuário com suas permissões
        var nivel = new NivelUsuario("Administrador", new List<string> { "Criar usuário", "Editar usuário", "Excluir usuário" });

        // Criando um usuário com o nível de acesso definido
        var usuario = new Usuario("Fulano", "fulano@example.com", "senha123", nivel, new DateTime(1990, 5, 11), "Rua A, 123", "123456789");

        // Realizando o cadastro do usuário
        usuario.Cadastro();

        // Realizando o login do usuário
        usuario.Login();
    }
}
