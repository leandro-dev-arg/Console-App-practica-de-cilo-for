using System;

namespace U5_programa_3
{
    class Program
    {
        static void Main(string[] args)
        {   int contador,acumulador,edad,promedio;
            acumulador=0;
            contador=0;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("ingrese una edad por favor");
                edad=int.Parse(Console.ReadLine());
                if (edad>=18){
                    contador++;
                    acumulador+=edad;
                }
            }
            promedio=acumulador/contador;
            Console.WriteLine("El promedio de edades de personas masyores a 18  es "+ promedio+ " años");
        }
    }
}
