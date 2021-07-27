using System;

namespace ejercixiosguia4
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes;
            Console.WriteLine("Ingrese un mes de la lista a continuacion:");
            Console.WriteLine(" ");
            Console.WriteLine("Enero\nMarzo\nJulio\nDiciembre");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese un mes");
            mes = Console.ReadLine();
            mes = mes.Trim();
            mes = mes.ToLower();

            switch (mes)
            {
                case "enero":
                    Console.WriteLine("\"Que comiences bien el año!!!.\"");
                    break;

                case "marzo":
                    Console.WriteLine("\"a clases!!!.\"");
                    break;

                case "julio":

                    Console.WriteLine("\"Se vienen las vacaciones!!!.\"");
                    break;

                case "diciembre":
                    Console.WriteLine("\"Felices fiestas!!!.\"");
                    break;

                default:
                    Console.WriteLine("Error de mes: No se encontro coincidencia");
                    break;

            }

        }
    }
}
