using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Hacer un programa que solicite 10  números enteros y los guarde en un vector.
            //  Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores
            //   que son mayores al promedio.
            int acu = 0, promedio;
            int[] vnum = new int [10];
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Escriba un nro: ");
                vnum[x] = int.Parse(Console.ReadLine());
            }
            
            for (int x = 0; x < 10; x++)
            {
                acu += vnum[x];
            }
            promedio = acu / 10;
            for (int x = 0; x < 10; x++)
            {
                if(vnum[x] > promedio)
                Console.WriteLine("Mayor que promedio " + vnum[x]);
            }
        }
    }
}
