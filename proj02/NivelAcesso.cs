using System;
using System.Collections.Generic;

namespace proj02
{
    // Definição da classe NivelUsuario
    public class NivelAcesso
    {
        public string Descricao { get; set; }
        public List<string> Permissoes { get; set; }
        // public Cargo cargo { get; set; }

        public NivelAcesso(string descricao, List<string> permissoes)
        {
            Descricao = descricao;
            Permissoes = permissoes ?? new List<string>(); 
        }

        public int GerarNivel(Cargos cargo){

            switch (cargo.Descricao.ToLower())
            {
                case "dono":
                    return 0;
                case "administrativo":
                    return 1;
                case "agricultor":
                    return 2;
                case "vendedor":
                    return 3;
                default:
                    throw new ArgumentOutOfRangeException(nameof(cargo), "Cargo inválido");
            }
        }
    }
}