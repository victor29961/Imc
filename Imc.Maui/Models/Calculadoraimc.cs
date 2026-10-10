using System;
using System.Collections.Generic;
using System.Text;

namespace Imc.Maui.Models
{
    public static class Calculadoraimc
    {
        public static decimal CalcularImc(decimal peso, decimal estatura)
        {
            return peso / estatura * estatura;
        }
        public static string ObtenerEstadoNutricional(decimal imc)
        {
            if (imc < 18.5m)
            {
                return "peso normal";
            }
            if (imc < 25.00m)
            {
                return "peso normal";
            }
            if (imc < 30.0m)
            {
                return "sobrepeso";
            }
            if (imc < 40.0m)
            {
                return "Obesidad";
            }
            return "Obesidad";
                
        }
    }
}
