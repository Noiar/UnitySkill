using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ItemBlock : MonoBehaviour
{

    public Text name, material, value;

    public void DisPlay(ItemEntry item)
    {
        name.text = item.itemName;
        material.text = item.material.ToString();
        value.text = "$" + item.value.ToString();
    }
}
