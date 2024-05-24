using System;


namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definción de variables
            double numero1, numero2, resultado;
            //solicitud de datos
            Console.WriteLine("Ingrese el primer valor");
            numero1 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            numero2 = Convert.ToDouble(Console.ReadLine());

            //Menu de operaciones

            Console.WriteLine("Calculadora de operaciones básicas");
            Console.WriteLine("Selecciona una de las siguientes opciones");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("0. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());
                                                

            switch (opcion)
            {
                case 1: 
                        resultado=numero1 + numero2;
                    Console.WriteLine($"La suma de {numero1} y {numero2} es: {resultado}");
                    Console.ReadLine();
                    break;

                case 2:
                    resultado=numero1 - numero2;
                    Console.WriteLine($"La resta de {numero1} y {numero2} es: {resultado} ");
                    Console.ReadLine();
                    break;
                    
                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine($"La multiplicacíón de {numero1} y {numero2} es: {resultado} ");
                    Console.ReadLine();
                    break;
                case 4:
                    resultado = numero1 / numero2;
                    Console.WriteLine($"La división de {numero1} y {numero2} es: {resultado} ");
                    Console.ReadLine();
                    break;
                case 0:
                    Console.WriteLine("Presione cualquier tecla para salir");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("ingreso un valor no valido");
                    break;
            }

            Console.WriteLine("\n Muchas gracias por usarla calculadora del Tupac");
        }

        
        }
}
