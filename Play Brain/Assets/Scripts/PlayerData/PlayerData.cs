using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerData 
{
    public int level;
    public int thePoints;
    public bool gameWasSaved;

    public PlayerData(Player player)
    {
        level = player.Level;
        thePoints = player.ThePoints;
        gameWasSaved = true;
    }
}
