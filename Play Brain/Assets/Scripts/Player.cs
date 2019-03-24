using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    // Start is called before the first frame update

       public int Pontuacao;
       public int Score;
       public int Level;

  
    public void MudarPontuacao(GameController GC)
    {
        Pontuacao = GC.pontos;
        Debug.Log("Pontuação Classe Player: " + Pontuacao);
      
    }
    public void setScore(int s)
    {
        Score += s;
    }
    public void setLevel(GameController GC)
    {
        //se o usuário chegou em um level mais alto que antes, o level é alterado.
        if((GC.level+1) > Level)
        {
            Level = GC.level+1;
            Debug.Log("Leveis desbloqueados=:"+Level);
        }


    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        Level = data.level;
    }

}
