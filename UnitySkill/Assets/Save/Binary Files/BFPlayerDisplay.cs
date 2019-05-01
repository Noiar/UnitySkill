using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BFPlayerDisplay : MonoBehaviour {

    public Text level, health, attack, defense;

    public void UpDateDisplay()
    {
        BFPlayer player = GetComponent<BFPlayer>();

        level.text = player.level.ToString();
        health.text = player.health.ToString();
        attack.text = player.attack.ToString();
        defense.text = player.defense.ToString();
    }
}
