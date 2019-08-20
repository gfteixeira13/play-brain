using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerData 
{
    public int level;
    public bool gameWasSaved;
    public int[] points = new int[10];

    public PlayerData(Player player)
    {
        level = player.Level;
        for (int i = 0; i <= 9; i++)
        {
            points[i] = player.Points[i];
        }
        gameWasSaved = true;
    Debug.Log("Pontuação no PlayerData: "+points[player.Level] + "e level no PlayerData:" + player.Level);
    }
}
