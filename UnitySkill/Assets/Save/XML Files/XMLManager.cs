using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using UnityEngine;


public class XMLManager : MonoBehaviour
{

    public static XMLManager instance;

    private void Awake()
    {
        instance = this;
    }

    public ItemDatabase itemDB;

    public void SaveItems()
    {
        using (StreamWriter sw = new StreamWriter(new FileStream(Application.dataPath +
            "/Save/XML Files/StreamingFiles/item_data.xml", FileMode.Create), Encoding.UTF8))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ItemDatabase));
            serializer.Serialize(sw, itemDB);
        }
    }

    public void LoadItems()
    {
        using(StreamReader sr = new StreamReader(new FileStream(Application.dataPath +
            "/Save/XML Files/StreamingFiles/item_data.xml", FileMode.Open), Encoding.UTF8))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ItemDatabase));
            itemDB = serializer.Deserialize(sr) as ItemDatabase;
        }
    }

}

[System.Serializable]
public class ItemEntry
{
    public string itemName;
    public Material material;
    public int value;
}

[System.Serializable]
public class ItemDatabase
{
    [XmlArray("CombatEquiptment")]
    public List<ItemEntry> list = new List<ItemEntry>();
}

public enum Material
{
    Wood,
    Copper,
    Iron,
    Steel,
    Obsidan
}