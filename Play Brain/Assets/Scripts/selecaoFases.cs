using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class selecaoFases : MonoBehaviour {

    public int idfase;
    public Button btnPlay;
    public TextMeshProUGUI txtFase;
    public string[] NomeFase;
    public Button Level2, Level3, Level4, Level5;
    public static bool primeiraVez = true;

    // Use this for initialization
    void Start () {

        try
        {
            Player player = new Player();

            if (File.Exists(Application.persistentDataPath + "/player.dat"))
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

                txtFase.text = "Seleciona a fase:";
                idfase = 0;
            }
                    
            else
            {
                Debug.Log("Não tem nada salvo ainda");
            txtFase.text = "Seleciona a fase:";
            idfase = 0;
            }
      

                                  
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }
	public void SelecioneFase(int i)
    {
        PlayerPrefs.SetInt("LevelClicado", (i-1));
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
