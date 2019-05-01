using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BFPlayer : MonoBehaviour {
    public int level;
    public int health;
    public int attack;
    public int defense;

    private void Start()
    {
        GetComponent<BFPlayerDisplay>().UpDateDisplay();
    }

    public void Save()
    {
        BFSaveLoadManager.SavePlayer(this);
    }

    public void Load()
    {
        PlayerData data = BFSaveLoadManager.LoadPlayer();
        level = data.stats[0];
        health = data.stats[1];
        attack = data.stats[2];
        defense = data.stats[3];
        GetComponent<BFPlayerDisplay>().UpDateDisplay();
    }

    public void Adjust(ref int stat, int value)
    {
        stat += value;
        if(stat < 1)
        {
            stat = 1;
        }
        GetComponent<BFPlayerDisplay>().UpDateDisplay();
    }

    public void AdjustLevel(int value)
    {
        Adjust(ref level, value);
    }

    public void AdjustHealth(int value)
    {
        Adjust(ref health, value);
    }

    public void AdjustAttack(int value)
    {
        Adjust(ref attack, value);
    }

    public void AdjustDefense(int value)
    {
        Adjust(ref defense, value);
    }
}
