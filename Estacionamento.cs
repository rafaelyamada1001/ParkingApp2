using System;

namespace ParkingAppContext.Domain.Entities
{


    public class Estacionamento
    {
        public decimal ValorHora { get; private set; }
        public int Vagas { get; private set; }

        public Estacionamento(decimal valorHora, int vagas)
        {
            ValorHora = valorHora;
            Vagas = vagas;
        }
    }

}