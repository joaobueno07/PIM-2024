using System;
namespace proj02
{

    // Definição da classe Usuario
    public class Producao{

        public string Lote { get; set; }
        public DateTime DataInicio {get; set;}
        public DateTime DataTermino {get; set;}
        public DateTime DataRelatorio {get; set;}
        public Funcionario Agricultor {get; set;}

        public Producao (string lote, DateTime dataInicio, DateTime dataTermino, DateTime dataRelatorio, Funcionario agricultor){
            this.Lote = lote;
            this.DataInicio = dataInicio;
            this.DataTermino = dataTermino;
            this.DataRelatorio = dataRelatorio;
            this.Agricultor = agricultor;
        }
        // public void GerarRelatorio();
    }
}