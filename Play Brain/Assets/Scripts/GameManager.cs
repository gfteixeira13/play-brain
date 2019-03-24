using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    public bool gameHasEnded = false;
    public GameObject CompleteLevelUI;
    public GameObject GameOver;

    public void completeLevel()
    {
        CompleteLevelUI.SetActive(true); //Chama a tela de 'Level Complete'
    }

    public void closeCompleteLevel()
    {
        CompleteLevelUI.SetActive(false);
    }
    IEnumerator TransitionGameOVER() //pequena transição entre a animação dos cadeados e o aparecimento do botão 'Avançar'
    {
        yield return new WaitForSeconds(2f);
        GameOver.SetActive(true);
    }

    public void endGame()
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
