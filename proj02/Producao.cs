using System;
namespace proj02
{

    // Definição da classe Usuario
    public class Producao{

        public string Lote { get; set; }
        public Date DataInicio {get; set;}
        public Date DataTermino {get; set;}
        public Date DataRelatorio {get; set;}
        public Funcionario Agricultor {get; set;}

        public Producao (string lote, Date dataInicio, Date dataTermino, Date dataRelatorio, Funcionario agricultor){
            this.Lote = lote;
            this.DataInicio = dataInicio;
            this.DataTermino = dataTermino;
            this.DataRelatorio = dataRelatorio;
            this.Agricultor = agricultor;
        }
        // public void GerarRelatorio();
    }
}