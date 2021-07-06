/*
    Infectado.cs
    Autor = César Calafrioli
    Data = 02/07/2021
    Última Modificação = 05/07/2021

    Classe que armazena informações sobre o respectivo infectado de COVID-19
*/

using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Api.Data.Collections
{
    public class Infectado
    {
        public Infectado(DateTime dataNascimento, string sexo, double latitude, double longitude)
        {
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }

        public DateTime DataNascimento { get; set; }

        public string Sexo { get; set; }

        public GeoJson2DGeographicCoordinates Localizacao { get; set; }
    }
}