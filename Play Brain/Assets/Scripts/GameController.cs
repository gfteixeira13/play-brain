using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class GameController : MonoBehaviour
{
    public Animator openLock1;
    public Animator openLock2;
    public bool lockHasOpen = false;

    public GameObject imgMenuT;
    public GameManager GameManager;

    public GameObject btnConfirm;
    public GameObject btn0;
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject btn4;
    public GameObject btn5;
    public GameObject btn6;
    public GameObject btn7;
    public GameObject btn8;
    public GameObject btn9;
    public GameObject full;
    public GameObject half;
    public GameObject half2;

    public TextMeshProUGUI txtPhase;
    public TextMeshProUGUI textAttempts;
    public TextMeshProUGUI textX1;
    public TextMeshProUGUI textX2;
    public TextMeshProUGUI click1txt;
    public TextMeshProUGUI click2txt;
   
    public AudioSource soundWin;
    public string[] result;
    public string[] alternativeA;
    public string[] alternativeB;
    public string[] alternativeC;
    public string[] alternativeD;
    public string[] alternativeE;
    public string[] alternativeF;
  
    public string[] correctN1;
    public string[] correctN2;

    public int phaseId;

    private bool txt1;
    private bool txt2;

    public bool correct1;
    public bool correct2;
    public bool positionE1;
    public bool positionE2;

    public int aux;
    public int attempts;
    public string[] click1; /*!< Recebe como Parâmetro a tentativa */
    public string[] click2; /*!< Recebe como Parâmetro a tentativa */

    public int points;
    public GameObject btnMenu;

    void Start()
    {
        phaseId = PlayerPrefs.GetInt("LevelClicado"); //A Fase recebe a fase clicada na seleção de fases
        Debug.Log("Level clicado recebido: " + phaseId);
        attempts = 0;
        points = 0;
        textAttempts.text = "";
        txtPhase.text = " " + (phaseId + 1);

        full.SetActive(false);
        half.SetActive(false);
        half2.SetActive(false);
        btnConfirm.SetActive(false);
        btn0.SetActive(false);
        btn1.SetActive(false);
        btn2.SetActive(false);
        btn3.SetActive(false);
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn6.SetActive(false);
        btn7.SetActive(false);
        btn8.SetActive(false);
        btn9.SetActive(false);

        btnMenu.SetActive(false);

        /**As booleanas estão falsas pois os 'TextBox1' e 'TextBox2' não foram preenchidos*/
        txt1 = false;
        txt2 = false;
        /*-------------------------------------------*/



        /**Abaixo os botões são alocados em suas devidas posições dependendo da pré-definição das alternativas*/
        if (phaseId > 9)
        {
          if(alternativeA[phaseId] == "1")
            {
                btn1.transform.localPosition = new Vector3(-145, 9, 0);
                btn1.SetActive(true);
            }
          if(alternativeB[phaseId] == "2")
            {
                btn2.transform.localPosition = new Vector3(4, 9, 0);
                btn2.SetActive(true);
            }
            if (alternativeC[phaseId] == "3")
            {
                btn3.transform.localPosition = new Vector3(152, 9, 0);
                btn3.SetActive(true);
            }
            if (alternativeD[phaseId] == "4")
            {
                btn4.transform.localPosition = new Vector3(-145, -171, 0);
                btn4.SetActive(true);
            }
            if (alternativeE[phaseId] == "5")
            {
                btn5.transform.localPosition = new Vector3(4, -171, 0);
                btn5.SetActive(true);
            }
            if (alternativeF[phaseId] == "6")
            {
                btn6.transform.localPosition = new Vector3(152, -171, 0);
                btn6.SetActive(true);
            }

        }
        else
        {

       
        if (alternativeA[phaseId] == "0")
        {
            btn0.transform.localPosition = new Vector3(-90, 9, 0);
            btn0.SetActive(true);


        }
        if (alternativeA[phaseId] == "1")
        {
            btn1.transform.localPosition = new Vector3(-90, 9, 0);
            btn1.SetActive(true);

        }
        if (alternativeA[phaseId] == "2")
        {
            btn2.transform.localPosition = new Vector3(-90, 9, 0);
            btn2.SetActive(true);

        }
        if (alternativeA[phaseId] == "3")
        {
            btn3.transform.localPosition = new Vector3(-90, 9, 0);
            btn3.SetActive(true);

        }
        if (alternativeA[phaseId] == "4")
        {
            btn4.transform.localPosition = new Vector3(-90, 9, 0);
            btn4.SetActive(true);



        }
        if (alternativeA[phaseId] == "5")
        {
            btn5.transform.localPosition = new Vector3(-90, 9, 0);
            btn5.SetActive(true);

        }
        if (alternativeA[phaseId] == "6")
        {
            btn6.transform.localPosition = new Vector3(-90, 9, 0);
            btn6.SetActive(true);

        }
        if (alternativeA[phaseId] == "7")
        {
            btn7.transform.localPosition = new Vector3(-90, 9, 0);
            btn7.SetActive(true);

        }
        if (alternativeA[phaseId] == "8")
        {
            btn8.transform.localPosition = new Vector3(-90, 9, 0);
            btn8.SetActive(true);

        }
        if (alternativeA[phaseId] == "9")
        {
            btn9.transform.localPosition = new Vector3(-90, 9, 0);
            btn9.SetActive(true);

        }

        if (alternativeB[phaseId] == "0")
        {
            btn0.transform.localPosition = new Vector3(90, 9, 0);
            btn0.SetActive(true);


        }
        if (alternativeB[phaseId] == "1")
        {
            btn1.transform.localPosition = new Vector3(90, 9, 0);
            btn1.SetActive(true);

        }
        if (alternativeB[phaseId] == "2")
        {
            btn2.transform.localPosition = new Vector3(90, 9, 0);
            btn2.SetActive(true);

        }
        if (alternativeB[phaseId] == "3")
        {
            btn3.transform.localPosition = new Vector3(90, 9, 0);
            btn3.SetActive(true);

        }
        if (alternativeB[phaseId] == "4")
        {
            btn4.transform.localPosition = new Vector3(90, 9, 0);
            btn4.SetActive(true);

        }
        if (alternativeB[phaseId] == "5")
        {
            btn5.transform.localPosition = new Vector3(90, 9, 0);
            btn5.SetActive(true);

        }
        if (alternativeB[phaseId] == "6")
        {
            btn6.transform.localPosition = new Vector3(90, 9, 0);
            btn6.SetActive(true);

        }
        if (alternativeB[phaseId] == "7")
        {
            btn7.transform.localPosition = new Vector3(90, 9, 0);
            btn7.SetActive(true);

        }
        if (alternativeB[phaseId] == "8")
        {
            btn8.transform.localPosition = new Vector3(90, 9, 0);
            btn8.SetActive(true);

        }
        if (alternativeB[phaseId] == "9")
        {
            btn9.transform.localPosition = new Vector3(90, 9, 0);
            btn9.SetActive(true);

        }
        if (alternativeC[phaseId] == "0")
        {
            btn0.transform.localPosition = new Vector3(-90, -171, 0);
            btn0.SetActive(true);


        }
        if (alternativeC[phaseId] == "1")
        {
            btn1.transform.localPosition = new Vector3(-90, -171, 0);
            btn1.SetActive(true);

        }
        if (alternativeC[phaseId] == "2")
        {
            btn2.transform.localPosition = new Vector3(-90, -171, 0);
            btn2.SetActive(true);

        }
        if (alternativeC[phaseId] == "3")
        {
            btn3.transform.localPosition = new Vector3(-90, -171, 0);
            btn3.SetActive(true);

        }
        if (alternativeC[phaseId] == "4")
        {
            btn4.transform.localPosition = new Vector3(-90, -171, 0);
            btn4.SetActive(true);

        }
        if (alternativeC[phaseId] == "5")
        {
            btn5.transform.localPosition = new Vector3(-90, -171, 0);
            btn5.SetActive(true);

        }
        if (alternativeC[phaseId] == "6")
        {
            btn6.transform.localPosition = new Vector3(-90, -171, 0);
            btn6.SetActive(true);

        }
        if (alternativeC[phaseId] == "7")
        {
            btn7.transform.localPosition = new Vector3(-90, -171, 0);
            btn7.SetActive(true);

        }
        if (alternativeC[phaseId] == "8")
        {
            btn8.transform.localPosition = new Vector3(-90, -171, 0);
            btn8.SetActive(true);

        }
        if (alternativeC[phaseId] == "9")
        {
            btn9.transform.localPosition = new Vector3(-90, -171, 0);
            btn9.SetActive(true);

        }
        if (alternativeD[phaseId] == "0")
        {
            btn0.transform.localPosition = new Vector3(90, -171, 0);
            btn0.SetActive(true);


        }
        if (alternativeD[phaseId] == "1")
        {
            btn1.transform.localPosition = new Vector3(90, -171, 0);
            btn1.SetActive(true);

        }
        if (alternativeD[phaseId] == "2")
        {
            btn2.transform.localPosition = new Vector3(90, -171, 0);
            btn2.SetActive(true);

        }
        if (alternativeD[phaseId] == "3")
        {
            btn3.transform.localPosition = new Vector3(90, -171, 0);
            btn3.SetActive(true);

        }
        if (alternativeD[phaseId] == "4")
        {
            btn4.transform.localPosition = new Vector3(90, -171, 0);
            btn4.SetActive(true);

        }
        if (alternativeD[phaseId] == "5")
        {
            btn5.transform.localPosition = new Vector3(90, -171, 0);
            btn5.SetActive(true);

        }
        if (alternativeD[phaseId] == "6")
        {
            btn6.transform.localPosition = new Vector3(90, -171, 0);
            btn6.SetActive(true);

        }
        if (alternativeD[phaseId] == "7")
        {
            btn7.transform.localPosition = new Vector3(90, -171, 0);
            btn7.SetActive(true);

        }
        if (alternativeD[phaseId] == "8")
        {
            btn8.transform.localPosition = new Vector3(90, -171, 0);
            btn8.SetActive(true);

        }
        if (alternativeD[phaseId] == "9")
        {
            btn9.transform.localPosition = new Vector3(90, -171, 0);
            btn9.SetActive(true);

        }
        }
    }

    /// <summary>
    /// Recebe o Clique do usuário  e já compara com o número escondido, preenchendo as booleanas.
    /// </summary>
    /// <param name="number">Número clicado pelo usuário.</param>
    public void Click(string number)
    {

       
        if (txt1 == false) 
        {
            click1[attempts] = number;


            if (number == alternativeA[phaseId]) 
            {
                textX1.text = alternativeA[phaseId]; 
                txt1 = true; 
                if (alternativeA[phaseId] == correctN1[phaseId]) 
                {
                    correct1 = true; 
                    positionE1 = false; 
                }
                else if (alternativeA[phaseId] == correctN2[phaseId]) 
                {
                    positionE1 = true;  
                    correct1 = false; 
                }
                else if ((alternativeA[phaseId] != correctN1[phaseId]) && (alternativeA[phaseId] != correctN2[phaseId]))
                {
                  
                    correct1 = false; 
                    positionE1 = false;
                }
            }              

            else if (number == alternativeB[phaseId])
            {
                textX1.text = alternativeB[phaseId];
                txt1 = true;
                if (alternativeB[phaseId] == correctN1[phaseId])
                {
                    correct1 = true;
                    positionE1 = false;
                }
                else if (alternativeB[phaseId] == correctN2[phaseId])
                {
                    positionE1 = true;
                    correct1 = false;
                }
                else if ((alternativeB[phaseId] != correctN1[phaseId]) && (alternativeB[phaseId] != correctN2[phaseId]))
                {
                    correct1 = false;
                    positionE1 = false;

                }
            }
            else if (number == alternativeC[phaseId])
            {
                textX1.text = alternativeC[phaseId];
                txt1 = true;
                if (alternativeC[phaseId] == correctN1[phaseId])
                {
                    correct1 = true;
                    positionE1 = false;
                }
                else if (alternativeC[phaseId] == correctN2[phaseId])
                {
                    positionE1 = true;
                    correct1 = false;
                }
                else if((alternativeC[phaseId] != correctN1[phaseId]) && (alternativeC[phaseId] != correctN2[phaseId]))
                {
                    correct1 = false;
                    positionE1 = false;
                }
            }
            else if (number == alternativeD[phaseId])
            {
                textX1.text = alternativeD[phaseId];
                txt1 = true;
                if (alternativeD[phaseId] == correctN1[phaseId])
                {
                    correct1 = true;
                    positionE1 = false;
                }
                else if (alternativeD[phaseId] == correctN2[phaseId])
                {
                    positionE1 = true;
                    correct1 = false;
                }
                else if ((alternativeD[phaseId] != correctN1[phaseId]) && (alternativeD[phaseId] != correctN2[phaseId]))
                {
                    correct1 = false;
                    positionE1 = false;
                }
            }
            else if(number == alternativeE[phaseId])
            {
                textX1.text = alternativeE[phaseId];
                txt1 = true;
                if (alternativeE[phaseId] == correctN1[phaseId])
                {
                    correct1 = true;
                    positionE1 = false;
                }
                else if (alternativeE[phaseId] == correctN2[phaseId])
                {
                    positionE1 = true;
                    correct1 = false;
                }
                else if ((alternativeE[phaseId] != correctN1[phaseId]) && (alternativeE[phaseId] != correctN2[phaseId]))
                {
                    correct1 = false;
                    positionE1 = false;
                }
            }
            else if (number == alternativeF[phaseId])
            {
                textX1.text = alternativeF[phaseId];
                txt1 = true;
                if (alternativeF[phaseId] == correctN1[phaseId])
                {
                    correct1 = true;
                    positionE1 = false;
                }
                else if (alternativeF[phaseId] == correctN2[phaseId])
                {
                    positionE1 = true;
                    correct1 = false;
                }
                else if ((alternativeF[phaseId] != correctN1[phaseId]) && (alternativeF[phaseId] != correctN2[phaseId]))
                {
                    correct1 = false;
                    positionE1 = false;
                }
            }





        }
        
      
        else if (txt2 == false) 
        {

            click2[attempts] = number;
            if (number == alternativeA[phaseId])
            {
                textX2.text = alternativeA[phaseId];
                txt2 = true;
                btnConfirm.SetActive(true);
                if (alternativeA[phaseId] == correctN2[phaseId]) 
                {
                        correct2 = true;
                        positionE2 = false;

         
               
                }
                else if (alternativeA[phaseId] == correctN1[phaseId])
                {
                        positionE2 = true;
                        correct2 = false;

                }
                else if (alternativeA[phaseId] != correctN2[phaseId] && alternativeA[phaseId] != correctN1[phaseId])
                {
                        correct2 = false;
                        positionE2 = false;              
                }

            }
            else if (number == alternativeB[phaseId])
            {
                textX2.text = alternativeB[phaseId];
                txt2 = true;
                btnConfirm.SetActive(true);

                    if (alternativeB[phaseId] == correctN2[phaseId]) 
                    {
                        correct2 = true;
                        positionE2 = false;
            
                    }
                else if (alternativeB[phaseId] == correctN1[phaseId])
                {
                    positionE2 = true;
                    correct2 = false;

               
                }
                else if (alternativeB[phaseId] != correctN2[phaseId] && alternativeB[phaseId] != correctN1[phaseId])
                {
                        correct2= false;
                        positionE2 = false;

                }
            }
            else if (number == alternativeC[phaseId])
            {
                textX2.text = alternativeC[phaseId];
                txt2 = true;
                btnConfirm.SetActive(true);

                if (alternativeC[phaseId] == correctN2[phaseId]) 
                {
                  correct2= true;
                  positionE2 = false;

                }
                else if (alternativeC[phaseId] == correctN1[phaseId])
                {
                    positionE2= true;
                    correct2 = false;

               
                }
                else if (alternativeC[phaseId] != correctN2[phaseId] && alternativeC[phaseId] != correctN1[phaseId])
                {
                        correct2 = false;
                        positionE2 = false;

                }
            }
            else if (number == alternativeD[phaseId])
            {
                textX2.text = alternativeD[phaseId];
                txt2 = true;
                btnConfirm.SetActive(true);

                if (alternativeD[phaseId] == correctN2[phaseId]) 
                {
                    correct2 = true;
                    positionE2 = false;
               

                }
                else if (alternativeD[phaseId] == correctN1[phaseId])
                {
                    positionE2 = true;
                    correct2 = false;

              
                }
                else if (alternativeD[phaseId] != correctN2[phaseId] && alternativeD[phaseId] != correctN1[phaseId])
                {
                        correct2 = false;
                        positionE2 = false;

                }
            }
            else if (number == alternativeE[phaseId])
            {
                textX2.text = alternativeE[phaseId];
                txt2 = true;
                btnConfirm.SetActive(true);

                if (alternativeE[phaseId] == correctN2[phaseId])
                {
                    correct2 = true;
                    positionE2 = false;


                }
                else if (alternativeE[phaseId] == correctN1[phaseId])
                {
                    positionE2 = true;
                    correct2 = false;


                }
                else if (alternativeE[phaseId] != correctN2[phaseId] && alternativeE[phaseId] != correctN1[phaseId])
                {
                    correct2 = false;
                    positionE2 = false;

                }
            }
            else if (number == alternativeF[phaseId])
            {
                textX2.text = alternativeF[phaseId];
                txt2 = true;
                btnConfirm.SetActive(true);

                if (alternativeF[phaseId] == correctN2[phaseId])
                {
                    correct2 = true;
                    positionE2 = false;


                }
                else if (alternativeF[phaseId] == correctN1[phaseId])
                {
                    positionE2 = true;
                    correct2 = false;


                }
                else if (alternativeF[phaseId] != correctN2[phaseId] && alternativeF[phaseId] != correctN1[phaseId])
                {
                    correct2 = false;
                    positionE2 = false;

                }
            }

        } 
    } 
    
    public void Backspace()
    {
       if(txt2 == false)
        {
            if (txt1 == true)
            {
                textX1.text = " ";
                txt1 = false;
            }
            
        }
       else if(txt1==true && txt2 == true)
        {
            textX2.text = " ";
            txt2 = false;
        }
       
    }
    IEnumerator TransitionFase()
    {
        yield return new WaitForSeconds(3f);
        GameManager.CompleteLevel();
       
    }

    /// <summary>
    /// Verifica as booleanas preenchidas na função 'Click' e mostra as dicas.
    /// </summary>
    public void ConfirmAnswer() 
    {  
        btnConfirm.SetActive(false);
        if (attempts == 4 && (correct1 ==false || correct2 == false))
        {
            GameManager.EndGame();        
        }
        else {

            if (correct1 == true && correct2 == true) 
            {
                GCScore();
                GameManager.Stars(points);
                if (lockHasOpen == false)
                {
                    openLock1.speed = 1;
                    openLock2.speed = 1;
                    openLock1.Play("CadeadoAbrindo", 0, 0f);
                    openLock2.Play("CadeadoAbrindo2", 0, 0f);
                    lockHasOpen = true;
                }
                soundWin.Play();
                full.SetActive(false);
                half.SetActive(false);
                btnConfirm.SetActive(false);
                half2.SetActive(false);
                StartCoroutine(TransitionFase());            

            }
            else
            {                          
                if (correct1 == true && correct2 == false && positionE2 == false && positionE1 == false) 
                {
                    full.SetActive(true);
                    result[attempts] = "F"; //Full
                    full.transform.localPosition = new Vector3(-164, -457, 0);
                    half.SetActive(false);
                    half2.SetActive(false);



                }
                else if ((correct1 == true && positionE2 == true) || (positionE1 == true && correct2 == true))
                {
                    half.transform.localPosition = new Vector3(-164, -457, 0);
                    half.SetActive(true);
                    result[attempts] = "H"; // Half
                    full.SetActive(false);
                    half2.SetActive(false);

                }
                else if (positionE1 == true && correct2 == false && correct1 == false && positionE2 == false)
                {
                    half.SetActive(true);
                    result[attempts] = "H";
                    half.transform.localPosition = new Vector3(-164, -457, 0);
                    half2.SetActive(false);

                }
                else if (positionE1 == true && positionE2 == true && correct1 == false && correct2 == false)
                {
                    half.SetActive(true);
                    half2.SetActive(true);
                    result[attempts] = "HH";
                    half.transform.localPosition = new Vector3(-164, -457, 0);
                    half2.transform.localPosition = new Vector3(-248, -457, 0);

                }
                else if (correct1 == false && correct2 == true && positionE1 == false && positionE2 == false)
                {
                    full.SetActive(true);
                    full.transform.localPosition = new Vector3(-164, -457, 0);
                    result[attempts] = "F";
                    half2.SetActive(false);
                    half.SetActive(false);

                }
                else if (correct1 == false && correct2 == false && positionE1 == false && positionE2 == false)
                {
                    full.SetActive(false);
                    half.SetActive(false);
                    half2.SetActive(false);

                    result[attempts] = "I"; // Incorrect

                }
                else if (positionE2 == true && positionE1 == false && correct1 == false && correct1 == false)
                {
                    half.transform.localPosition = new Vector3(-164, -457, 0);

                    half.SetActive(true);
                    result[attempts] = "H";
                    full.SetActive(false);
                    half2.SetActive(false);


                }

              
            }
            click1txt.text = click1[attempts];
            click2txt.text = click2[attempts];
            attempts++;
            textAttempts.text = "" + attempts;



            txt1 = false;
            txt2 = false;
            textX1.text = " ";
            textX2.text = " ";
        }


        if (attempts > 0)
        {
            btnMenu.SetActive(true);
        }



    }
    /// <summary>
    /// Verifica em qual tentativa o usuário acertou e dá a respectiva pontuação.
    /// </summary>
    /// <returns></returns>
    public int GCScore()
    {
        if (correct1 == true && correct2 == true)
        {
            if (attempts == 0)
            {
                points = 10;
            }
            else if (attempts == 1)
            {
                points = 8;
            }
            else if (attempts == 2)
            {
                points = 6;
            }
            else if (attempts == 3)
            {
                points = 4;
            }
            else if (attempts == 4)
            {
                points = 2;
            }
           
            
        }
        else
        {
            points = 0;
        }
        Debug.Log(points);
        
        return points;
        
    }
    /// <summary>
    /// Passa para a próxima fase "zerando" as variáveis necessárias.
    /// </summary>
    public void ProximaFase()
    {
        phaseId++;

        GameManager.CloseCompleteLevel();
       
          
        click1txt.text = " ";
        click2txt.text = " ";
        btnConfirm.SetActive(false);
        full.SetActive(false);
        half.SetActive(false);
        half2.SetActive(false);
        attempts = 0;
        textAttempts.text = "";
        
        txtPhase.text = "" + (phaseId+1);
        for(int i=0; i < phaseId; i++)
        {
            click1[i] = null;
            click2[i] = null;
            result[i] = null;
        }
   

        correct1 = false;
        correct2 = false;
        positionE1 = false;
        positionE2 = false;
        half2.SetActive(false);
        half.SetActive(false);
        full.SetActive(false);
       

        txt1 = false;
        txt2 = false;

       /**Fecha os Cadeados*/
        openLock1.speed = -1;
        openLock2.speed = -1;
        openLock1.Play("CadeadoAbrindo", 0, 0f);
        openLock2.Play("CadeadoAbrindo2", 0, 0f);
        lockHasOpen = false;

        if (phaseId > 9)
        {
            if (alternativeA[phaseId] == "1")
            {
                btn1.transform.localPosition = new Vector3(-145, 9, 0);
                btn1.SetActive(true);
            }
            if (alternativeB[phaseId] == "2")
            {
                btn2.transform.localPosition = new Vector3(4, 9, 0);
                btn2.SetActive(true);
            }
            if (alternativeC[phaseId] == "3")
            {
                btn3.transform.localPosition = new Vector3(152, 9, 0);
                btn3.SetActive(true);
            }
            if (alternativeD[phaseId] == "4")
            {
                btn4.transform.localPosition = new Vector3(-145, -171, 0);
                btn4.SetActive(true);
            }
            if (alternativeE[phaseId] == "5")
            {
                btn5.transform.localPosition = new Vector3(4, -171, 0);
                btn5.SetActive(true);
            }
            if (alternativeF[phaseId] == "6")
            {
                btn6.transform.localPosition = new Vector3(152, -171, 0);
                btn6.SetActive(true);
            }

        }
        else
        {

       
        if (alternativeA[phaseId] == "0")
        {
            btn0.transform.localPosition = new Vector3(-90, 9, 0);
            btn0.SetActive(true);


        }
        if (alternativeA[phaseId] == "1")
        {
            btn1.transform.localPosition = new Vector3(-90, 9, 0);
            btn1.SetActive(true);

        }
        if (alternativeA[phaseId] == "2")
        {
            btn2.transform.localPosition = new Vector3(-90, 9, 0);
            btn2.SetActive(true);

        }
        if (alternativeA[phaseId] == "3")
        {
            btn3.transform.localPosition = new Vector3(-90, 9, 0);
            btn3.SetActive(true);

        }
        if (alternativeA[phaseId] == "4")
        {
            btn4.transform.localPosition = new Vector3(-90, 9, 0);
            btn4.SetActive(true);



        }
        if (alternativeA[phaseId] == "5")
        {
            btn5.transform.localPosition = new Vector3(-90, 9, 0);
            btn5.SetActive(true);

        }
        if (alternativeA[phaseId] == "6")
        {
            btn6.transform.localPosition = new Vector3(-90, 9, 0);
            btn6.SetActive(true);

        }
        if (alternativeA[phaseId] == "7")
        {
            btn7.transform.localPosition = new Vector3(-90, 9, 0);
            btn7.SetActive(true);

        }
        if (alternativeA[phaseId] == "8")
        {
            btn8.transform.localPosition = new Vector3(-90, 9, 0);
            btn8.SetActive(true);

        }
        if (alternativeA[phaseId] == "9")
        {
            btn9.transform.localPosition = new Vector3(-90, 9, 0);
            btn9.SetActive(true);

        }
  
       
        if (alternativeB[phaseId] == "0")
        {
            btn0.transform.localPosition = new Vector3(90, 9, 0);
            btn0.SetActive(true);


        }
        if (alternativeB[phaseId] == "1")
        {
            btn1.transform.localPosition = new Vector3(90, 9, 0);
            btn1.SetActive(true);

        }
        if (alternativeB[phaseId] == "2")
        {
            btn2.transform.localPosition = new Vector3(90, 9, 0);
            btn2.SetActive(true);

        }
        if (alternativeB[phaseId] == "3")
        {
            btn3.transform.localPosition = new Vector3(90, 9, 0);
            btn3.SetActive(true);

        }
        if (alternativeB[phaseId] == "4")
        {
            btn4.transform.localPosition = new Vector3(90, 9, 0);
            btn4.SetActive(true);

        }
        if (alternativeB[phaseId] == "5")
        {
            btn5.transform.localPosition = new Vector3(90, 9, 0);
            btn5.SetActive(true);

        }
        if (alternativeB[phaseId] == "6")
        {
            btn6.transform.localPosition = new Vector3(90, 9, 0);
            btn6.SetActive(true);

        }
        if (alternativeB[phaseId] == "7")
        {
            btn7.transform.localPosition = new Vector3(90, 9, 0);
            btn7.SetActive(true);

        }
        if (alternativeB[phaseId] == "8")
        {
            btn8.transform.localPosition = new Vector3(90, 9, 0);
            btn8.SetActive(true);

        }
        if (alternativeB[phaseId] == "9")
        {
            btn9.transform.localPosition = new Vector3(90, 9, 0);
            btn9.SetActive(true);

        }
     
        
        if (alternativeC[phaseId] == "0")
        {
            btn0.transform.localPosition = new Vector3(-90, -171, 0);
            btn0.SetActive(true);


        }
        if (alternativeC[phaseId] == "1")
        {
            btn1.transform.localPosition = new Vector3(-90, -171, 0);
            btn1.SetActive(true);

        }
        if (alternativeC[phaseId] == "2")
        {
            btn2.transform.localPosition = new Vector3(-90, -171, 0);
            btn2.SetActive(true);

        }
        if (alternativeC[phaseId] == "3")
        {
            btn3.transform.localPosition = new Vector3(-90, -171, 0);
            btn3.SetActive(true);

        }
        if (alternativeC[phaseId] == "4")
        {
            btn4.transform.localPosition = new Vector3(-90, -171, 0);
            btn4.SetActive(true);

        }
        if (alternativeC[phaseId] == "5")
        {
            btn5.transform.localPosition = new Vector3(-90, -171, 0);
            btn5.SetActive(true);

        }
        if (alternativeC[phaseId] == "6")
        {
            btn6.transform.localPosition = new Vector3(-90, -171, 0);
            btn6.SetActive(true);

        }
        if (alternativeC[phaseId] == "7")
        {
            btn7.transform.localPosition = new Vector3(-90, -171, 0);
            btn7.SetActive(true);

        }
        if (alternativeC[phaseId] == "8")
        {
            btn8.transform.localPosition = new Vector3(-90, -171, 0);
            btn8.SetActive(true);

        }
        if (alternativeC[phaseId] == "9")
        {
            btn9.transform.localPosition = new Vector3(-90, -171, 0);
            btn9.SetActive(true);

        }
       

        if (alternativeD[phaseId] == "0")
        {
            btn0.transform.localPosition = new Vector3(90, -171, 0);
            btn0.SetActive(true);


        }
        if (alternativeD[phaseId] == "1")
        {
            btn1.transform.localPosition = new Vector3(90, -171, 0);
            btn1.SetActive(true);

        }
        if (alternativeD[phaseId] == "2")
        {
            btn2.transform.localPosition = new Vector3(90, -171, 0);
            btn2.SetActive(true);

        }
        if (alternativeD[phaseId] == "3")
        {
            btn3.transform.localPosition = new Vector3(90, -171, 0);
            btn3.SetActive(true);

        }
        if (alternativeD[phaseId] == "4")
        {
            btn4.transform.localPosition = new Vector3(90, -171, 0);
            btn4.SetActive(true);

        }
        if (alternativeD[phaseId] == "5")
        {
            btn5.transform.localPosition = new Vector3(90, -171, 0);
            btn5.SetActive(true);

        }
        if (alternativeD[phaseId] == "6")
        {
            btn6.transform.localPosition = new Vector3(90, -171, 0);
            btn6.SetActive(true);

        }
        if (alternativeD[phaseId] == "7")
        {
            btn7.transform.localPosition = new Vector3(90, -171, 0);
            btn7.SetActive(true);

        }
        if (alternativeD[phaseId] == "8")
        {
            btn8.transform.localPosition = new Vector3(90, -171, 0);
            btn8.SetActive(true);

        }
        if (alternativeD[phaseId] == "9")
        {
            btn9.transform.localPosition = new Vector3(90, -171, 0);
            btn9.SetActive(true);

        }
        }

        textX1.text = " ";
        textX2.text = " ";

        }
    
}

    


