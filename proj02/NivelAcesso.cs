using System;
namespace proj02
{
    // Definição da classe NivelUsuario
    public class NivelAcesso
    {
        public string Descricao { get; set; }
        public List<string> Permissoes { get; set; }

        public NivelAcesso(string descricao, List<string> permissoes)
        {
            this.Descricao = descricao;
            this.Permissoes = permissoes;
        }
    }
}