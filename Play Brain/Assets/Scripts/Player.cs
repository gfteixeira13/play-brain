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
    public void MudarScore(int s)
    {
        Score += s;
    }
    public void MudarLevel(int l)
    {
        Level += l;     
    }
  
}
