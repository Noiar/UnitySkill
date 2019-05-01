using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text;
using UnityEngine;

public class BFSaveLoadManager {
    public static void SavePlayer(BFPlayer player)
    {
        BinaryFormatter bf = new BinaryFormatter();
        using(FileStream file = new FileStream(Application.dataPath + "/Save/Binary Files/player.sav", FileMode.Create))
        {
            PlayerData playerData = new PlayerData(player);
            bf.Serialize(file, playerData);
        }
    }

    public static PlayerData LoadPlayer()
    {
        BinaryFormatter bf = new BinaryFormatter();
        using(FileStream file = new FileStream(Application.dataPath + "/Save/Binary Files/player.sav", FileMode.Open))
        {
            PlayerData playerData = bf.Deserialize(file) as PlayerData;
            return playerData;
        }
    }
}

[Serializable]
public class PlayerData
{
    public int[] stats;

    public PlayerData(BFPlayer player)
    {
        stats = new int[4];
        stats[0] = player.level;
        stats[1] = player.health;
        stats[2] = player.attack;
        stats[3] = player.defense;
    }
}