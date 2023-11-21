using System;
using System.Collections;

public static class BubbleSort
{
    public static void OrdenarArrayList(ArrayList arrayList)
    {
        int n = arrayList.Count;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if ((int)arrayList[j] > (int)arrayList[j + 1])
                {
                    Intercambiar(arrayList, j, j + 1);
                }
            }
        }
    }

    private static void Intercambiar(ArrayList arrayList, int indice1, int indice2)
    {
        object temp = arrayList[indice1];
        arrayList[indice1] = arrayList[indice2];
        arrayList[indice2] = temp;
    }
}
