using System;

namespace EjecicioSWITCH2
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
                case "julio":    
                case "agosto":
                    Console.WriteLine("\"abrigate que hace frio\"");
                    break;

                case "septiembre":
                case "octubre":
                case "noviembre":
                case "diciembre":
                    Console.WriteLine("\"Ya pasamos el frio, ahora calor!!!\"");
                    break;

                default:
                    Console.WriteLine("Falta para el invierno");
                    break;

            }
        }
    }
}
