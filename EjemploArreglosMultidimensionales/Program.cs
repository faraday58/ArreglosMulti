using System;

namespace EjemploArreglosMultidimensionales
{
    class Program
    {
        static void Main()
        {
            int[,] arreglo2D = { {1,2 },{3,4 } };
            for(int i=0;i < 2; i++)
            {
                for(int j=0;j < 2; j++)
                {
                    Console.Write(" {0} ",arreglo2D[i,j]);
                }
                Console.WriteLine();
            }

            int[,,] arreglo3D = { { {2,2 },{3,4 } }, { {0,-1 },{2, 1} }  };

            for(int i=0;i<2;i++)
            {
                Console.WriteLine("Plano {0}",i+1);
                for (int j=0;j < 2;j++)
                {
                    for(int k=0;k<2;k++ )
                    {
                        Console.Write(" {0} ",arreglo3D[i,j,k]);
                    }
                    Console.WriteLine();
                }
                
            }


            Console.ReadLine();



        }
    }
}
