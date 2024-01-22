namespace Projeto_Hotel.Models
{
    public class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
        public Suite() { }
        public Suite(string tipoSuite, int capacidade, decimal valorDiario)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiario;
        }
    }
}
