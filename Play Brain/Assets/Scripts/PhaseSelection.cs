using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PhaseSelection : MonoBehaviour {

 
    public Button btnPlay; //Botão para Inciar o Game
    public TextMeshProUGUI txtPhase; //Text que mostra a fase Selecionada
    public Button Level2, Level3, Level4, Level5; 
   /// <summary>
   /// É verificado se já houve algum salvamento, a partir disso é mostrado as fases desbloqueadas
   /// </summary>
    void Start () {
        
            Player player = new Player();

            if (File.Exists(Application.persistentDataPath + "//player.dat"))
            {
                player.LoadPlayer();
                Debug.Log("Level desbloqueado na selecao de fase: " + player.Level);
          
                if (player.Level >= 1)
                {
                    Level2.interactable = true;
                   
                }
                if (player.Level >= 2)
                {
                    Level3.interactable = true;
                }
                if (player.Level >= 3)
                {
                    Level4.interactable = true;
                }
                if (player.Level >= 4)
                {
                    Level5.interactable = true;
                }

                txtPhase.text = "Seleciona a fase:";
              
            }
                    
            else
            {
                Debug.Log("Não tem nada salvo ainda");
                txtPhase.text = "Seleciona a fase:";
              
            }
                                  
        
      
    }
    /// <summary>
    /// Desbloqueia o botão Play a partir da seleção da fase
    /// </summary>
    /// <param name="i">Fase Selecionada</param>
	public void SelectPhase(int i)
    {
        PlayerPrefs.SetInt("LevelClicado", (i-1));
        btnPlay.interactable = true;
        txtPhase.text = "Fase: " + i;
    }
    /// <summary>
    /// Inicia o Jogo
    /// </summary>
    public void Play()
    {
        SceneManager.LoadScene("Fases");

    }
    /// <summary>
    /// Avança o Level
    /// </summary>
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	
}
