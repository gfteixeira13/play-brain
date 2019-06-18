using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerData 
{
    public int level;
    public bool gameWasSaved;

    public PlayerData(Player player)
    {
        level = player.Level;
      //  thePoints[player.Level] = player.ThePoints[player.Level];
        gameWasSaved = true;
       // Debug.Log(thePoints[player.Level] + "e " + player.Level);
    }
}
