using System;

class Program
{
    static void Merge(int[] a, int l, int m, int r)
    {
        int a1 = m - l + 1;
        int a2 = r - m;

        int[] L = new int[a1];
        int[] R = new int[a2];

        for (int j = 0; j < a1; j++)
        {
            L[j] = a[l + j];
        }
        for (int k = 0; k < a2; k++)
        {
            R[k] = a[m + 1 + k];
        }

        int i = 0;
        int jIndex = 0;
        int kIndex = l;

        while (i < a1 && jIndex < a2)
        {
            if (L[i] <= R[jIndex])
            {
                a[kIndex] = L[i];
                i = i + 1;
            }
            else
            {
                a[kIndex] = R[jIndex];
                jIndex = jIndex + 1;
            }
            kIndex = kIndex + 1;
        }

        // copiar los elem restantes de L[], si hay alguno
        while (i < a1)
        {
            a[kIndex] = L[i];
            i = i + 1;
            kIndex = kIndex + 1;
        }

        // copiar los elem restantes de R[], si hay alguno
        while (jIndex < a2)
        {
            a[kIndex] = R[jIndex];
            jIndex = jIndex + 1;
            kIndex = kIndex + 1;
        }
    }

    static void MergeSort(int[] a, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;
            MergeSort(a, l, m);
            MergeSort(a, m + 1, r);
            Merge(a, l, m, r);
        }
    }

    static void Main()
    {
        int[] a = { 39, 28, 44, 11 };
        int s = a.Length;

        Console.WriteLine("Antes de ordenar el arreglo: ");
        for (int j = 0; j < s; j++)
        {
            Console.Write(a[j] + " ");
        }

        MergeSort(a, 0, s - 1);

        Console.WriteLine("\nDespues de ordenar el arreglo: ");
        for (int j = 0; j < s; j++)
        {
            Console.Write(a[j] + " ");
        }
    }
}
