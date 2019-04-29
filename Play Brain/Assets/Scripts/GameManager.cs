using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    public bool gameHasEnded = false;
    public GameObject CompleteLevelUI;
    public GameObject GameOver;
    /// <summary>
    /// Tela de 'Level Complete' é chamada.
    /// </summary>
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
    /// <summary>
    /// Fecha tela de 'Level Complete'
    /// </summary>
    public void CloseCompleteLevel()
    {
        CompleteLevelUI.SetActive(false);
    }
    /// <summary>
    /// pequena transição entre a animação dos cadeados e o aparecimento do botão 'Avançar'.
    /// </summary>
    /// <returns>Valor de 2f</returns>
    IEnumerator TransitionGameOVER() 
    {
        yield return new WaitForSeconds(2f);
        GameOver.SetActive(true);
    }
    /// <summary>
    /// Chama tela de 'Game Over'.
    /// </summary>
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            StartCoroutine(TransitionGameOVER());
        }
    }
 

    
    public void Return()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
