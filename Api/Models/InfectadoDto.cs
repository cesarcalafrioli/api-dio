/* 
InfectadoDto.cs

Autor = César Calafrioli
Data = 05/07/2021
Última modificação = 05/07/2021

*/

namespace Api.Models
{
    public class InfectadoDto
    {
        
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}