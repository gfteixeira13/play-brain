using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
       public int[] Points;
       public int Level;
       public bool GameWasSaved;

    void Start()
    {
        GameWasSaved = false;
        Level = 0;
       

    }
    /// <summary>
    /// Função responsável por anexar a pontuação do jogo à pontuação do Player
    /// </summary>
    /// <param name="GC">Responsável por trazer dados do GameController</param>
    public void ChangePoints(GameController GC)
    {
        if(Points[GC.phaseId] < GC.points)
        {
            Points[GC.phaseId] = GC.points;
            Debug.Log("BATEU O RECORD DA FASE " + GC.phaseId + "Pontuação: " + Points[GC.phaseId]);
        }
 
       // Debug.Log(ThePoints[GC.phaseId] = GC.points);
       // Debug.Log("Pontuação Classe Player: " + ThePoints[GC.phaseId] + "Fase" + GC.phaseId);
    
    }
    /// <summary>
    /// Função responsável por anexar o último level desbloqueado ao Player
    /// </summary>
    /// <param name="GC">Responsável por trazer dados do GameController</param>
    public void setLevel(GameController GC)
    {
        if (Level < GC.phaseId)
        {
            Level = GC.phaseId+1;
            Debug.Log("Level desbloqueado(some+1):" + Level);
        }

    }
    /// <summary>
    /// Salva os dados do Player
    /// </summary>
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    /// <summary>
    /// Carrega os dados do Player a partir do arquivo Binário
    /// </summary>
    public void LoadPlayer()
    {
 
        PlayerData data = SaveSystem.LoadPlayer();
        Level = data.level;
      //  for(int i=0; i <= 4; i++)
       // {  
       //     Points[i] = data.points[i];
       //     Debug.Log("Points["+i+"]: " + Points[i] + " = " + "data.points["+i+"]: " +data.points[i]);
       // }
        // ThePoints[data.level] = data.thePoints[data.level];
        GameWasSaved = data.gameWasSaved;
    }

}
