using System;
using System.Collections;
using System.Collections.Generic;

class Programon
{
    static void Main()
    {
        //bubble sort
        ArrayList arrayList = new ArrayList() { 5, 2, 9, 1, 5, 6 };
        Console.WriteLine("ArrayList Original:");
        ImprimirArrayList(arrayList);
        BubbleSort.OrdenarArrayList(arrayList);
        Console.WriteLine("ArrayList Ordenado:");
        ImprimirArrayList(arrayList);

        //Sum Border 
        int[,] matriz = new int[10, 10];
        LlenarMatriz(matriz);
        Console.WriteLine("Matriz Original:");
        ImprimirMatriz(matriz);
        int sumaBordes = SumBorders.SumarBordes(matriz);
        Console.WriteLine("La suma de los bordes es" + sumaBordes);

        // suma diagonales
        int[,] matriz2 = new int[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int belgrano = 0; belgrano < 10; belgrano++)
            {
                matriz2[i, belgrano] = i * 10 + belgrano + 1;
            }
        }
        SumarDiagonales.CalcularYSumarDiagonales(matriz2);
        Console.ReadLine();
    }
    //bubble sort
        static void ImprimirArrayList(ArrayList arrayList)
    {
        foreach (var elemento in arrayList)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }

        //sumBorders
        static void LlenarMatriz(int[,] matriz)
    {
        Random random = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = random.Next(1, 100);
            }
        }
    }
//sumBorders
    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}