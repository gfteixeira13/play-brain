using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class comandosbasicos : MonoBehaviour {
    
    public void carregaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }
}
