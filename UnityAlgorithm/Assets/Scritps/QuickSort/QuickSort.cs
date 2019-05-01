using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class QuickSort
{
    public static int[] ExcuteQuickSort(int[] arr, int left, int right)
    {
        int i = left;
        int j = right;
        int pivot = arr[(left + right) / 2];
        int temp;
        do
        {
            while (arr[i] < pivot)
                i++;
            while (arr[j] > pivot)
                j--;
            if (i <= j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        } while (i <= j);

        if (left < j)
            ExcuteQuickSort(arr, left, j);

        if (i < right)
            ExcuteQuickSort(arr, i, right);

        return arr;
    }
}

public static class MyUtility
{
    private static int ver;

    // static 생성자
    static MyUtility()
    {
        ver = 1;
    }

    public static string Convert(int i)
    {
        return i.ToString().ToUpper();
    }

    public static int ConvertBack(string s)
    {
        return int.Parse(s);
    }
}
