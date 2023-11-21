using System;

public class SumarDiagonales
{
    public static void CalcularYSumarDiagonales(int[,] matriz)
    {
        // Imprimir la matriz
        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);

        // Calcular y sumar las diagonales
        int sumaDiagonalIzquierdaDerecha = 0;
        int sumaDiagonalArribaAbajo = 0;

        for (int i = 0; i < 10; i++)
        {
            sumaDiagonalIzquierdaDerecha += matriz[i, i];
            sumaDiagonalArribaAbajo += matriz[i, 9 - i];
        }

        Console.WriteLine("Suma diagonal de izquierda a derecha " + sumaDiagonalIzquierdaDerecha);
        Console.WriteLine("Suma diagonal de arriba a abajo: " + sumaDiagonalArribaAbajo);
    }

    public static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int belgrano = 0; belgrano < matriz.GetLength(1); belgrano++)
            {
                Console.Write(matriz[i, belgrano]);
            }
            Console.WriteLine();
        }
    }
}