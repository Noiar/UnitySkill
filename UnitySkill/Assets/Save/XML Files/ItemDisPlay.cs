using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDisPlay : MonoBehaviour
{
    public ItemBlock blockPrefab;

    // Use this for initialization
    void Start()
    {
        DisPlay();
    }

    public void DisPlay()
    {
        foreach(Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        foreach (ItemEntry item in XMLManager.instance.itemDB.list)
        {
            ItemBlock newBlock = Instantiate(blockPrefab) as ItemBlock;
            newBlock.transform.SetParent(transform, false);
            newBlock.DisPlay(item);
        }
    }
}
