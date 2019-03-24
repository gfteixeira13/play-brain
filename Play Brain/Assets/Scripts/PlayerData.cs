using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public int level;
    public int pontuacao;
    public bool salvouAlgumaVez;

    public PlayerData(Player player)
    {
        level = player.Level;
        pontuacao = player.Pontuacao;
        salvouAlgumaVez = true;
    }
}
