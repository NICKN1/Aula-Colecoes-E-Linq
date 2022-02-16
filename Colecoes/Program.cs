using System;
using Colecoes.Helper;
using static System.Console;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar a classe
            OperacoesArrays op = new OperacoesArrays();
            int[] array = new int[5] {3 , 24, 33, 8, 9};
            
            WriteLine("Array Original");
            op.imprimirArray(array);

            //Ordenando pelo BubbleSort
            //op.ordenarBubbleSort(ref array);

            //ordenado pela a classe Array utilizando o metodo Sort
            op.ordenar(ref array);

            WriteLine("Array ordenado");
            op.imprimirArray(array);
            /*
            //Array multidimensional (Matriz) >>> E para instanciar a matriz com valores
            int[,] arrayIntMatriz = new int[4,2]
            {
                //essa é a representação das linhas e colunas da matriz
                {8, 8 },
                {7, 7},
                {6, 6},
                {4, 5}
            };

            //Para percorrer as os dados da matriz, criando dois for
            //getLength é da classe Array, pois pega a dimensão do Array
            for (int i = 0; i < arrayIntMatriz.GetLength(0); i++)
            {
                //outro for para percorrer a coluna
                for (int j = 0; j < arrayIntMatriz.GetLength(1); j++)
                {
                    //Para imprimir os valores das linhas e colunas da matriz
                    WriteLine(arrayIntMatriz[i, j]);
                }
            }
            

            //Array para capacitar apenas 3 numeros inteiros
            int[] arrayInteiros = new int[3];

            //Acessando o array através de posições
            arrayInteiros[0] = 50;
            arrayInteiros[1] = 70;
            //Para converter uma string para int
            arrayInteiros[2] = int.Parse("80");

            //Percorrer o array para imprimir os elementos pelo for
            /*WriteLine("Imprimindo pelo for");
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                WriteLine(arrayInteiros[i]);
            }
            //Percorrer o Array com foreach
            WriteLine("Imprimindo pelo foreach");
            foreach (int item in arrayInteiros)
            {
                WriteLine(item);
            }
            */
        }
    }
}
