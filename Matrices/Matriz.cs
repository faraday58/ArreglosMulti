using System;

namespace Matrices
{
    public class Matriz
    {
        #region Atributos de una matriz de n x m
        private float[,] matAux;
        private int nReng;
        private int nCol;
        #endregion

        #region Propiedades de matriz
        public int NReng { get => nReng;
            set
            {
                if(value <= 0   )
                {
                    nReng = 1;
                }else
                {
                    nReng = value;
                }                
            }
        }
        public int NCol
        {
            get => nCol;
            set
            {
                if (value <= 0)
                {
                    nCol = 1;
                }
                else
                {
                    nCol = value;
                }

            }
        }
        #endregion

        #region Constructor

        public Matriz()
        {

        }

         public Matriz(int nReng, int nCol)
        {
            NReng = nReng;
            NCol = nCol;
            matAux = new float[NReng, NCol];

        }
        #endregion

        #region Métodos de Matriz

        public static Matriz Leer()
        {
            Console.WriteLine("Ingresa la matriz de la forma:" +
                "1 2 3 4;5 6 7 8 \n donde ;" +
                "significa un cambio de renglón" +
                "y el espacio significa una coloumna distinta");
            string arreglo = Console.ReadLine();

            string[] renglones = arreglo.Split(';');
            string[] columnas = renglones[0].Split(' ');
            Matriz matriz = new Matriz(renglones.Length, columnas.Length);

            for(int i=0; i < matriz.NReng; i++)
            {
                columnas = renglones[i].Split(' ');
                for(int j=0; j < matriz.NCol; j++)
                {
                    matriz.matAux[i, j] = float.Parse(columnas[j]);
                }

            }
            return matriz;

        }




        public override string ToString()
        {
            string aux = "";

            for(int i=0; i< NReng; i++)
            {
                for(int j=0; j <NCol; j++)
                {
                    aux = aux + " " + matAux[i, j];
                }
                aux = aux + "\n";
            }
            return aux;

        }

        #endregion

        #region Operadores de Matriz
        public static Matriz operator +(Matriz m1, Matriz m2)
        {
            Matriz m3 = new Matriz(m1.NReng, m1.NCol);
            for( int i=0;  i < m2.NReng; i++)
            {
                for( int j=0; j < m2.NCol;j++)
                {
                    m3.matAux[i, j] = m1.matAux[i, j] + m2.matAux[i, j];

                }
            }
            return m3;
        }


        #endregion


    }
}
