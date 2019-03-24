using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    // Start is called before the first frame update

       public int Pontuacao;
       public int Score;
       public int Level;
    public bool SalvouAlgumaVez;

    void Start()
    {
        SalvouAlgumaVez = false;
        Level = 0;

    }
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
        if (Level < GC.idFase + 1)
        {
            Level = GC.idFase + 1;
            Debug.Log("Level desbloqueado(some+1):" + Level);
        }
;
    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        Level = data.level;
        SalvouAlgumaVez = data.salvouAlgumaVez;
    }

}
