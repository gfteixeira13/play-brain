using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FasesJogo : MonoBehaviour {

   private int idfase;
    public Button btnPlay;
    public TextMeshProUGUI txtFase;
    public string[] NomeFase;
	// Use this for initialization
	void Start () {
        idfase = 0;
        txtFase.text = NomeFase[idfase];
      
	}
	public void SelecioneFase(int i)
    {
        idfase = i;
        btnPlay.interactable = true;
        txtFase.text = "Fase: " + i;
    }

    public void Jogar()
    {
        SceneManager.LoadScene("Fase" + idfase.ToString());

    }
	
}
