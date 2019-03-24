using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class selecaoFases : MonoBehaviour {

    private int idfase;
    public Button btnPlay;
    public TextMeshProUGUI txtFase;
    public string[] NomeFase;
    public Button Level2, Level3, Level4, Level5;
	// Use this for initialization
	void Start () {


        try
        {
            Player player = new Player();
            player.LoadPlayer();
            Debug.Log("Level desbloqueado na selecao de fase: " + player.Level);
            
          if (player.Level >= 2)
          {
             Level2.interactable = true;
          }
          if (player.Level >= 3)
          {
              Level3.interactable = true;
          }
            if (player.Level >= 4)
            {
                Level4.interactable = true;
            }
            if (player.Level >= 5)
            {
                Level5.interactable = true;
            }

            idfase = 0;
            txtFase.text = NomeFase[idfase];
        }catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }
	public void SelecioneFase(int i)
    {
        PlayerPrefs.SetInt("LevelClicado", i);
        btnPlay.interactable = true;
        txtFase.text = "Fase: " + i;
    }

    public void Jogar()
    {
        SceneManager.LoadScene("Fases");

    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	
}
