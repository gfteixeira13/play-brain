using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class comandosbasicos : MonoBehaviour {

	// Use this for initialization
	public void carregaCena(string nomeCena)
	{

		
        SceneManager.LoadScene(nomeCena);

    }
}
