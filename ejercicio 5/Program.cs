using System;

namespace ejercicio_5
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int hora;
            string tiempo = (""); 
            Console.WriteLine("Ingrese una hora");
            Console.WriteLine("Ingrese la hora en este formato: 7 o 17");
            Console.WriteLine("!Hasta un minimo de 0 o un maximo de 24¡");
            hora = int.Parse(Console.ReadLine());
            
            if (hora >= 7 && hora <= 11)
            {
                tiempo = "mañana";
            }
            else if (hora >= 12 && hora <=19)
            {
                tiempo = "tarde";
            }
            else if (hora <= 6 || hora >= 20 && hora <= 24)
            {
                tiempo = "noche";
            }
            
            switch (tiempo)
            {
                case "mañana":
                    Console.WriteLine("Es de mañana");
                    break;
                case "tarde":
                    Console.WriteLine("Es de tarde");
                    break;
                case "noche":
                    Console.WriteLine("Es de noche");
                    break;
                default:
                    Console.WriteLine($"Error: Las {hora}hr no existe");
                    break;

            }
        }
    }
}
