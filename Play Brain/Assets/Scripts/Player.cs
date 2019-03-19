using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    // Start is called before the first frame update

       public int Pontuacao;
       public int Score;
       public int Level;

  
    public void MudarPontuacao(responder responder)
    {
        Pontuacao = responder.pontos;
        Debug.Log("Pontuação Classe Player: " + Pontuacao);
      
    }
    public void setScore(int s)
    {
        Score += s;
    }
    public void setLevel(responder responder)
    {
        //se o usuário chegou em um level mais alto que antes, o level é alterado.
        if(responder.level > Level)
        {
            Level = responder.level;
            Debug.Log("Leveis desbloqueados=:"+Level);
        }


    }
  
}
