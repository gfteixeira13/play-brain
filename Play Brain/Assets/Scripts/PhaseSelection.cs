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
    public Button Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9, Level10, Level11, Level12, Level13, Level14, Level15;
    //public int testeFase1Record;
    //public GameObject StarOn1, StarOn2, StarOn3;
   /// <summary>
   /// É verificado se já houve algum salvamento, a partir disso é mostrado as fases desbloqueadas
   /// </summary>
    void Start () {
        
            Player player = new Player();

            if (File.Exists(Application.persistentDataPath + "//player.dat"))
            {
                player.LoadPlayer();
                Debug.Log("Level desbloqueado na selecao de fase: " + player.Level);
          
                if (player.Level > 0)
                {
                    Level2.interactable = true;
               // testeFase1Record = player.Points[0];
                 /*   if(player.Points[0] >= 8)
                    {
                        StarOn1.SetActive(true);
                        StarOn2.SetActive(true);
                        StarOn3.SetActive(true);
                    }*/
                   
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
                if (player.Level >= 5)
                {
                    Level6.interactable = true;
                }
                if (player.Level >= 6)
                {
                    Level7.interactable = true;
                }
                if (player.Level >= 7)
                {
                    Level8.interactable = true;
                }
                if (player.Level >= 8)
                {
                    Level9.interactable = true;
                }
                if (player.Level >= 9)
                {
                    Level10.interactable = true;
                }
                if(player.Level >= 10)
                {
                Level11.interactable = true;
                }
                if(player.Level >= 11)
                {
                Level12.interactable = true;
                }
            if (player.Level >= 12)
            {
                Level13.interactable = true;
            }
            if (player.Level >= 13)
            {
                Level14.interactable = true;
            }
            if (player.Level >= 14)
            {
                Level15.interactable = true;
            }

            txtPhase.text = "Selecione a fase:";
              
            }
                    
            else
            {
                Debug.Log("Não tem nada salvo ainda");
                txtPhase.text = "Selecione a fase:";
              
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
