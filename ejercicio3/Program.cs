using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes;
            Console.WriteLine("Ingrese un mes del año:");
            Console.WriteLine(" ");
            mes = Console.ReadLine();
            mes = mes.Trim();
            mes = mes.ToLower();
            switch (mes)
            {
                case "febrero":
                    Console.WriteLine("Este mes no tiene más de 29 días.");
                    break;
                case "enero":
                case "marzo":
                case "abril":
                case "mayo":
                case "junio":
                case "julio":
                case "agosto":
                case "septiembre":
                case "octubre":
                case "noviembre":
                case "diciembre":
                    Console.WriteLine("Este mes tiene 30 o más días");
                    break;

                default:
                    Console.WriteLine("Error mes no reconocido");

                    break;
            }
        }
    }
}
