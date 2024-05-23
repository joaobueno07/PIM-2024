
namespace proj02
{
    public class Cargos
    {
        public bool Status { get; set; }
        public string Descricao { get; set; }
        public double Salario { get; set; }
        
        public Cargos (bool status , string descricao , double salario)
        {
            this.Status = status;
            this.Descricao = descricao;
            this.Salario = salario;
            // Console.WriteLine(descricao);
        }
 
    } 
}
