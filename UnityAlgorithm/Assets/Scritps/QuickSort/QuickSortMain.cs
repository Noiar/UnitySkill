using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSortMain : MonoBehaviour
{
    public int[] arr;

    public void Sort()
    {
        int[] SortArr = arr;
        string Text = null;
        foreach (var item in SortArr)
        {
            Text += item + " ";
        }
        Debug.Log("Before Sort : " + Text);
        Text = null;
        SortArr = QuickSort.ExcuteQuickSort(SortArr, 0, SortArr.Length - 1);
        foreach (var item in SortArr)
        {
            Text += item + " ";
        }

        Debug.Log("After Sort : " + Text);
    }
}
