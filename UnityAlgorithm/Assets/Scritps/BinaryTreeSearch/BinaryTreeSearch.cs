using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinaryTreeSearch : MonoBehaviour
{
    //Node root = null;
    //Tree bst = new Tree();
    //int Size = 200000;
    //int[] a;
    //private void Awake()
    //{
    //    a = new int[Size];
    //}

    public int FoundItem;
    public List<int> intList;

    private void Start()
    {
        Node root = null;
        Tree bst = new Tree();
        int SIZE = 100;
        int[] a = new int[SIZE];
        for(int i = 0; i < SIZE; i++)
        {
            intList.Add(i);
        }

        for (int i = 0; i < 100; i++)
        {
            int index = intList[Random.Range(0, intList.Count)];
            root = bst.Insert(root, index);
            intList.Remove(index);
        }

        bst.Search(root, FoundItem);

        bst.BST_print(root);
    }
}

public class Node
{
    public int value;
    public Node right;
    public Node left;
}

public class Tree
{

    public Node Insert(Node root, int v)
    {
        if (root == null)
        {
            root = new Node();
            root.value = v;
        }
        else if (v < root.value)
        {
            root.left = Insert(root.left, v);
        }
        else
        {
            root.right = Insert(root.right, v);
        }

        return root;
    }

    public void traverse(Node root)
    {
        if (root == null)
        {
            return;
        }

        traverse(root.left);
        traverse(root.right);
    }

    public void Search(Node root, int find)
    {
        int Count = 0;

        Find(root, find, ref Count);
    }

    private void Find(Node node, int findItem, ref int Count)
    {
        Count++;

        if (node == null)
            return;

        if (node.value == findItem)
        {
            UnityEngine.Debug.LogFormat("{0}을 {1}번의 탐색 끝에 찾았습니다.", findItem, Count);
            return;
        }
        else if (findItem < node.value)
        {
            Find(node.left, findItem, ref Count);
        }
        else
        {
            Find(node.right, findItem, ref Count);
        }
    }

    public void BST_print(Node root)
    {
        if (root == null)
            return;

        Debug.LogFormat("{0}", root.value);
        BST_print(root.left);
        BST_print(root.right);
    }

}
