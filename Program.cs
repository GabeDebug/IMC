using System;
using System.Globalization;

namespace CALCIMC
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Qual e a sua altura?");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual e seu peso? ");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imc = peso / (altura * altura);


            if (imc < 16)
            {
                Console.WriteLine($"Classificação: Magreza grave {imc:F2}");
            }
            else if (imc < 17)
            {
                Console.WriteLine($"Classificação: Magreza moderada {imc:F2}");
            }
            else if (imc < 18.5)
            {
                Console.WriteLine($"Classificação: Magreza leve {imc:F2}");
            }
            else if (imc < 25)
            {
                Console.WriteLine($"Classificação: Peso normal {imc:F2}");
            }
            else if (imc < 30)
            {
                Console.WriteLine($"Classificação: Sobrepeso {imc:F2}");
            }
            else if (imc < 35)
            {
                Console.WriteLine($"Classificação: Obesidade Grau I {imc:F2}");
            }
            else if (imc < 40)
            {
                Console.WriteLine($"Classificação: Obesidade Grau II {imc:F2}");
            }
            else
            {
                Console.WriteLine($"Classificação: Obesidade Grau III {imc:F2}");
            }
        }
    }
}