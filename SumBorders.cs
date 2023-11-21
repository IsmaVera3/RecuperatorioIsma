public static class SumBorders
{
    public static int SumarBordes(int[,] matriz)
    {
        int suma = 0;
        for (int i = 0; i < matriz.GetLength(1); i++)
        {
            suma += matriz[0, i];
        }
        for (int i = 1; i < matriz.GetLength(0); i++)
        {
            suma += matriz[i, matriz.GetLength(1) - 1];
        }

        for (int i = matriz.GetLength(1) - 2; i >= 0; i--)
        {
            suma += matriz[matriz.GetLength(0) - 1, i];
        }

        for (int i = matriz.GetLength(0) - 2; i > 0; i--)
        {
            suma += matriz[i, 0];
        }

        return suma;
    }
}
