using System;

namespace Colecoes.Helper
{
    public class OperacoesArrays
    {
        //Metodo para ordenar o array pelo algoritmo Bubble sort
        public void ordenarBubbleSort(ref int[] array)
        {
            //variável temporaria para realizar a troca sem perder a informação armazenada anterior
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //tem que ter o N -1 para que o array no final não compare com uma posição que não existe
                for (int j = 0;j < array.Length -1 ; j++)
                {
                    //Se o array atual for maior que o proximo >>> Esse +1 indica a proxima posição de j
                    if (array[j] > array[j +1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void imprimirArray(int[] array)
        {
            //Concatenar em uma linha só, exibindo todos os elementos em uma mesma linha
            var linha = string.Join(", ", array);
            
                System.Console.WriteLine(linha);
            
        }

        //Metodo Sort da Classe Array
        public void ordenar(ref int[] array)
        {
            Array.Sort(array);
        }
    }
}