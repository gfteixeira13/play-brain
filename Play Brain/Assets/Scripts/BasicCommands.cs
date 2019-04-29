using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicCommands : MonoBehaviour {
    
    public void LoadScene(string p_nameScene)
    {
        SceneManager.LoadScene(p_nameScene);
    }
}
