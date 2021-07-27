using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var estadia = 15000;
            string estacion;
            string localidad;
            double descuento;
            double aumento;
            double total;

            Console.WriteLine($"Costo de la estadia: {estadia}$");
            Console.WriteLine("ingrese una estacion del año");
            Console.WriteLine(" ");
            Console.WriteLine("Invierno, Verano, Otoño, Primavera");

            estacion = Console.ReadLine();
            estacion = estacion.Trim();
            estacion = estacion.ToLower();

            Console.WriteLine(" ");
            Console.WriteLine("ingrese una localidad");
            Console.WriteLine(" ");
            Console.WriteLine("Bariloche, Cataratas, Cordoba, Mar de Plata");

            localidad = Console.ReadLine();
            localidad = localidad.Trim();
            localidad = localidad.ToLower();

            switch (estacion)
            {
                case "invierno":
                    if (localidad == "cordoba" || localidad == "cataratas")
                    {
                        Console.WriteLine($"{estadia}");
                        descuento= (estadia * 0.10);
                        Console.WriteLine($"{descuento}");
                        total = estadia - descuento;
                        Console.WriteLine($"El monto total a abonar es:{total}");
                    }
                    else if (localidad == "bariloche")
                    {
                        Console.WriteLine($"{estadia}");
                        aumento = (estadia * 0.20);
                        Console.WriteLine($"{aumento}");
                        total = estadia + aumento;
                        Console.WriteLine($"El monto total a abonar es:{total}");
                    }
                    else
                    {
                        Console.WriteLine($"{estadia}");
                        descuento = (estadia * 0.20);
                        Console.WriteLine($"{descuento}");
                        total = estadia - descuento;
                        Console.WriteLine($"El monto total a abonar es:{total}");
                    }
                    break;
                case "verano":
                    if (localidad == "cordoba" || localidad == "cataratas")
                    {
                        Console.WriteLine($"{estadia}");
                        aumento = (estadia * 0.10);
                        Console.WriteLine($"{aumento}");
                        total = estadia + aumento;
                        Console.WriteLine($"El monto total a abonar es:{total}");
                    }
                    else if(localidad == "bariloche")
                    {
                        Console.WriteLine($"{estadia}");
                        descuento = (estadia * 0.20);
                        Console.WriteLine($"{descuento}");
                        total = estadia - descuento;
                        Console.WriteLine($"El monto total a abonar es:{total}");
                    }
                    else
                    {
                        Console.WriteLine($"{estadia}");
                        aumento = (estadia * 0.20);
                        Console.WriteLine($"{aumento}");
                        total = estadia + aumento;
                        Console.WriteLine($"El monto total a abonar es:{total}");
                    }
                    break;
                case "otoño":     
                case "primavera":
                    if (localidad=="bariloche" || localidad == "cataratas" || localidad == "mar de plata")
                    {
                        Console.WriteLine($"{estadia}");
                        aumento = (estadia * 0.10);
                        Console.WriteLine($"{aumento}");
                        total = estadia + aumento;
                        Console.WriteLine($"El monto total a abonar es:{total}");
                    }
                    else
                    {
                        total = estadia;
                        Console.WriteLine($"El monto total a abonar es:{total}");
                    }
                    break;
                default:
                    Console.WriteLine("Error en elementos ingresados");
                    break;
            }



        }
    }
}
