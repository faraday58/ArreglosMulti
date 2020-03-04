using System;
using Matrices;

namespace SobreCargaOperadores
{
    class Program
    {
        static void Main()
        {
            Matriz miMatriz = new Matriz();
            miMatriz = Matriz.Leer();
            Console.WriteLine(miMatriz.ToString());
            Matriz miMatriz2 = new Matriz();
            miMatriz2 = Matriz.Leer();
            Console.WriteLine(miMatriz2.ToString());

            Matriz sumaMatriz = miMatriz + miMatriz2;
            Console.WriteLine("La suma de la matriz {0}+{1}={2}" +
                "", miMatriz, miMatriz2, sumaMatriz);


            Console.ReadLine();

        }
    }
}
