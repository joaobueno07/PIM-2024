using System;
using System.Collections.Generic;

// Definição da classe NivelUsuario
public class NivelUsuario
{
    public string Descricao { get; set; }
    public List<string> Permissoes { get; set; }

    public NivelUsuario(string descricao, List<string> permissoes)
    {
        Descricao = descricao;
        Permissoes = permissoes;
    }
}