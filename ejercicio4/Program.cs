using System;

namespace ejercicio4
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
                    Console.WriteLine("Este mes tiene 28 a 29 dias");
                    break;
                case "abril":
                case "junio":
                case "septiembre":
                case "noviembre":
                    Console.WriteLine("Este mes tiene 30 dias");
                    break;

                   
                default:
                    Console.WriteLine("Este mes tiene 31 dias");
                    break;

            }
        }
    }
}
