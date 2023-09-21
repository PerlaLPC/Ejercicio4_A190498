using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraAreaWS
{
    public class CalcularArea
    {
        public decimal Lado { get; set; }
        public decimal Base { get; set; }
        public decimal Altura { get; set; }
        public decimal Radio { get; set; }

        public decimal Areacuadrado(decimal Lado)
        {
            return Lado * Lado;
        }
        public decimal Areatriangulo(decimal Base, decimal Altura)
        {
            return (Base * Altura) / 2;
        }
        public double Areacirculo(double Radio)
        {
            double pi = 3.1416;
            var resultado = pi * (Radio * Radio);
            return resultado;
            
        }
 
    } 
}