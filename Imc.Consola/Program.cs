using Imc.Maui.Models;

Console.WriteLine("Aplicaion que calcula el indice de masa corporal de una persona");
Console.WriteLine();



decimal peso = RedDecimal("Proporcione el peso em kilogramos de la persona: ");
decimal estatura = RedDecimal("Proporcione la estatura en metros de la persona: "); 

string entrada;
bool entradaEsvalida;


decimal imc = Calculadoraimc.IndiceDeMasaCorporal(peso, estatura);
var estadoNutricional = Calculadoraimc.EstadoNutricional(imc);

Console.WriteLine($"El indece de masa corporal de la persona es {imc:F4}");
Console.WriteLine($"El estado nutricional de la persona es {estadoNutricional}");

static decimal RedDecimal(string indicacion)
{
    string entrada;
    bool entradaEsvalida;
    decimal valor;
    do
    {
        Console.WriteLine(indicacion);
        entrada = Console.ReadLine();
        entradaEsvalida = decimal.TryParse(entrada, out valor);
        if (!entradaEsvalida)
        {
            Console.WriteLine("Error: la entrada debe ser numerica");
        }
    } while (!entradaEsvalida);
    return valor;
}