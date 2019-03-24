using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class GameController : MonoBehaviour
{
    public Animator abrirCadeado1;
    public Animator abrirCadeado2;

    public bool cadeadoAberto = false;
    //public void ResetTrigger(fechaCadeado1);
    //public void ResetTrigger(int id);
    public GameObject imgMenuT;
    public GameManager GameManager;

    public GameObject btnConfirmar; //Botão de Confirmar Tentativa


    //Botões das Alternativas:
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
    public GameObject certo; //Símbolo de certo
    public GameObject meio; //Símbolo de Meio certo
    public GameObject meio2;

  

    public TextMeshProUGUI txtFase;
    public TextMeshProUGUI tentativas;
    public TextMeshProUGUI textX1; //Objeto de Texto (Simboliza uma textBox1)
    public TextMeshProUGUI textX2; //Objeto de Texto(Simboliza uma textBox2)
    public TextMeshProUGUI clique1txt;
    public TextMeshProUGUI clique2txt;
    

    public AudioSource SomGanhou;
    public string[] resultado;



    ////////////Strings das Alternativas e dos números corretos(são definidos no gameObject na interface da Unity)
    public string[] alternativaA;
    public string[] alternativaB;
    public string[] alternativaC;
    public string[] alternativaD;
    public string[] corretaN1;
    public string[] corretaN2;

    ///////////Número da Fase:
   public int idFase; 

    private bool txt1; //serve para verificar se o textX1 está vazio
    private bool txt2; //serve para verificar se o textX2 está vazio;
    
    //booleanas que nos dão o resultado
    public bool correta1;
    public bool correta2;
    public bool posicaoE1;
    public bool posicaoE2;


    public int ttentativas;
    public string[] clique1; //o parâmetro receberá o número da tentativa
    public string[] clique2; // ||
    //-------------------------------//
    //Váriaveis relacionadas ao Score e Level do Usuário
    public Text pontuacao;
    public int pontos;
    //-----------//
    public GameObject btnMenu;
    void Start()
    {
        idFase = PlayerPrefs.GetInt("LevelClicado"); 
        Debug.Log("Level clicado recebido: " + idFase);
        //Alocação de objetos e variáveis:

        ttentativas = 0; //nenhuma tentativa ainda
        pontos = 0;
        tentativas.text = "";
        txtFase.text = " " + (idFase+1); 

        certo.SetActive(false);
        meio.SetActive(false);
        meio2.SetActive(false);
        btnConfirmar.SetActive(false);
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

        //Todos os botões estão invisiveis 
        txt1 = false;
        txt2 = false;
        //As booleanas acimas estão falsas pois os 'TextBox1' e 'TextBox2' não foram preenchidos
        //Abaixo os botões são alocados em suas devidas posições:

        //Alternativa A -------------------------------Alternativa A----------------Alternativa A-----------------//
        if (alternativaA[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(-90, 9, 0);
            btn0.SetActive(true);


        }
        if (alternativaA[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(-90, 9, 0);
            btn1.SetActive(true);

        }
        if (alternativaA[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(-90, 9, 0);
            btn2.SetActive(true);

        }
        if (alternativaA[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(-90, 9, 0);
            btn3.SetActive(true);

        }
        if (alternativaA[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(-90, 9, 0);
            btn4.SetActive(true);



        }
        if (alternativaA[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(-90, 9, 0);
            btn5.SetActive(true);

        }
        if (alternativaA[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(-90, 9, 0);
            btn6.SetActive(true);

        }
        if (alternativaA[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(-90, 9, 0);
            btn7.SetActive(true);

        }
        if (alternativaA[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(-90, 9, 0);
            btn8.SetActive(true);

        }
        if (alternativaA[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(-90, 9, 0);
            btn9.SetActive(true);

        }

////Alternativa B -------------------------------Alternativa B----------------Alternativa B-----------------
        if (alternativaB[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(90, 9, 0);
            btn0.SetActive(true);


        }
        if (alternativaB[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(90, 9, 0);
            btn1.SetActive(true);

        }
        if (alternativaB[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(90, 9, 0);
            btn2.SetActive(true);

        }
        if (alternativaB[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(90, 9, 0);
            btn3.SetActive(true);

        }
        if (alternativaB[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(90, 9, 0);
            btn4.SetActive(true);

        }
        if (alternativaB[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(90, 9, 0);
            btn5.SetActive(true);

        }
        if (alternativaB[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(90, 9, 0);
            btn6.SetActive(true);

        }
        if (alternativaB[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(90, 9, 0);
            btn7.SetActive(true);

        }
        if (alternativaB[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(90, 9, 0);
            btn8.SetActive(true);

        }
        if (alternativaB[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(90, 9, 0);
            btn9.SetActive(true);

        }
////Alternativa C -------------------------------Alternativa C----------------Alternativa C------------------
        if (alternativaC[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(-90, -171, 0);
            btn0.SetActive(true);


        }
        if (alternativaC[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(-90, -171, 0);
            btn1.SetActive(true);

        }
        if (alternativaC[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(-90, -171, 0);
            btn2.SetActive(true);

        }
        if (alternativaC[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(-90, -171, 0);
            btn3.SetActive(true);

        }
        if (alternativaC[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(-90, -171, 0);
            btn4.SetActive(true);

        }
        if (alternativaC[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(-90, -171, 0);
            btn5.SetActive(true);

        }
        if (alternativaC[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(-90, -171, 0);
            btn6.SetActive(true);

        }
        if (alternativaC[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(-90, -171, 0);
            btn7.SetActive(true);

        }
        if (alternativaC[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(-90, -171, 0);
            btn8.SetActive(true);

        }
        if (alternativaC[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(-90, -171, 0);
            btn9.SetActive(true);

        }
////Alternativa D-------------------------------Alternativa D----------------Alternativa D-----------------
        if (alternativaD[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(90, -171, 0);
            btn0.SetActive(true);


        }
        if (alternativaD[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(90, -171, 0);
            btn1.SetActive(true);

        }
        if (alternativaD[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(90, -171, 0);
            btn2.SetActive(true);

        }
        if (alternativaD[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(90, -171, 0);
            btn3.SetActive(true);

        }
        if (alternativaD[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(90, -171, 0);
            btn4.SetActive(true);

        }
        if (alternativaD[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(90, -171, 0);
            btn5.SetActive(true);

        }
        if (alternativaD[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(90, -171, 0);
            btn6.SetActive(true);

        }
        if (alternativaD[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(90, -171, 0);
            btn7.SetActive(true);

        }
        if (alternativaD[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(90, -171, 0);
            btn8.SetActive(true);

        }
        if (alternativaD[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(90, -171, 0);
            btn9.SetActive(true);

        }
    }





    public void click(string number)
    {

       
        if (txt1 == false) //primeiro número clicado
        {
            clique1[ttentativas] = number;


            if (number == alternativaA[idFase]) //Compara se o number clicado foi igual ao número da alternativaA[fase X] 
            {
                textX1.text = alternativaA[idFase]; //textX1 recebe o número do button que foi clicado - nesse caso o nº da alternativa A
                txt1 = true; //agora o textx1 tem algo, então o txt1 recebe true;
                if (alternativaA[idFase] == corretaN1[idFase]) //se a alternativa A for igual ao número1 escondido
                {
                    correta1 = true; //assim o usuário acertou o primeiro número
                    posicaoE1 = false; //Ele acertou, logo a posição está correta
                }
                else if (alternativaA[idFase] == corretaN2[idFase]) //se a alternativa A for igual ao segundo número escondido
                {
                    posicaoE1 = true;  //posição errada recebe verdadeiro.
                    correta1 = false; 
                }
                else if ((alternativaA[idFase] != corretaN1[idFase]) && (alternativaA[idFase] != corretaN2[idFase]))
                {
                    //errou por completo o primeiro número
                    correta1 = false; 
                    posicaoE1 = false;
                }
            }                //AS MESMAS COMPARAÇÕES SÃO FEITAS COM AS OUTRAS ALTERNATIVAS(B,C E D)            

            else if (number == alternativaB[idFase])
            {
                textX1.text = alternativaB[idFase];
                txt1 = true;
                if (alternativaB[idFase] == corretaN1[idFase])
                {
                    correta1 = true;
                    posicaoE1 = false;
                }
                else if (alternativaB[idFase] == corretaN2[idFase])
                {
                    posicaoE1 = true;
                    correta1 = false;
                }
                else if ((alternativaB[idFase] != corretaN1[idFase]) && (alternativaB[idFase] != corretaN2[idFase]))
                {
                    correta1 = false;
                    posicaoE1 = false;

                }
            }
            else if (number == alternativaC[idFase])
            {
                textX1.text = alternativaC[idFase];
                txt1 = true;
                if (alternativaC[idFase] == corretaN1[idFase])
                {
                    correta1 = true;
                    posicaoE1 = false;
                }
                else if (alternativaC[idFase] == corretaN2[idFase])
                {
                    posicaoE1 = true;
                    correta1 = false;
                }
                else if((alternativaC[idFase] != corretaN1[idFase]) && (alternativaC[idFase] != corretaN2[idFase]))
                {
                    correta1 = false;
                    posicaoE1 = false;
                }
            }
            else if (number == alternativaD[idFase])
            {
                textX1.text = alternativaD[idFase];
                txt1 = true;
                if (alternativaD[idFase] == corretaN1[idFase])
                {
                    correta1 = true;
                    posicaoE1 = false;
                }
                else if (alternativaD[idFase] == corretaN2[idFase])
                {
                    posicaoE1 = true;
                    correta1 = false;
                }
                else if ((alternativaD[idFase] != corretaN1[idFase]) && (alternativaD[idFase] != corretaN2[idFase]))
                {
                    correta1 = false;
                    posicaoE1 = false;
                }
            }





        }///////////////////////////////////////////////////////////////
        
      
        else if (txt2 == false) //segundo número clicado
        {

            clique2[ttentativas] = number;
            if (number == alternativaA[idFase])
            {
                textX2.text = alternativaA[idFase];
                txt2 = true;
                btnConfirmar.SetActive(true);
                if (alternativaA[idFase] == corretaN2[idFase]) 
                {
                        correta2 = true;
                        posicaoE2 = false;

         
               
                }
                else if (alternativaA[idFase] == corretaN1[idFase])
                {
                        posicaoE2 = true;
                        correta2 = false;

                }
                else if (alternativaA[idFase] != corretaN2[idFase] && alternativaA[idFase] != corretaN1[idFase])
                {
                        correta2 = false;
                        posicaoE2 = false;              
                }

            }//////////////////////////////////////////////////////////// -- ///////// -- ////// --//////////////////---- ///////////////////////////
            else if (number == alternativaB[idFase])
            {
                textX2.text = alternativaB[idFase];
                txt2 = true;
                btnConfirmar.SetActive(true);

                    if (alternativaB[idFase] == corretaN2[idFase]) //acertou o segundo número
                    {
                        correta2 = true;
                        posicaoE2 = false;
            
                    }
                else if (alternativaB[idFase] == corretaN1[idFase])
                {
                    posicaoE2 = true;
                    correta2 = false;

               
                }
                else if (alternativaB[idFase] != corretaN2[idFase] && alternativaB[idFase] != corretaN1[idFase])
                {
                        correta2= false;
                        posicaoE2 = false;

                }
            }////////////////////////// ----- /////////////////////// ---- ///////////////////// ----- //////////////////////////////// ---- ///////////////////////////
            else if (number == alternativaC[idFase])
            {
                textX2.text = alternativaC[idFase];
                txt2 = true;
                btnConfirmar.SetActive(true);

                if (alternativaC[idFase] == corretaN2[idFase]) //acertou o segundo número
                {
                  correta2= true;
                  posicaoE2 = false;

                }
                else if (alternativaC[idFase] == corretaN1[idFase])
                {
                    posicaoE2= true;
                    correta2 = false;

               
                }
                else if (alternativaC[idFase] != corretaN2[idFase] && alternativaC[idFase] != corretaN1[idFase])
                {
                        correta2 = false;
                        posicaoE2 = false;

                }
            }///////////////----------//////////////---------------/////////////--------------/////////////------------////////////----------/////////////
            else if (number == alternativaD[idFase])
            {
                textX2.text = alternativaD[idFase];
                txt2 = true;
                btnConfirmar.SetActive(true);

                if (alternativaD[idFase] == corretaN2[idFase]) //acertou o segundo número
                {
                    correta2 = true;
                    posicaoE2 = false;
               

                }
                else if (alternativaD[idFase] == corretaN1[idFase])
                {
                    posicaoE2 = true;
                    correta2 = false;

              
                }
                else if (alternativaD[idFase] != corretaN2[idFase] && alternativaD[idFase] != corretaN1[idFase])
                {
                        correta2 = false;
                        posicaoE2 = false;

                }
            }

        } //Comparações referente ao segundo número clicado se encerram aqui
    } //Aqui encerra a função clique

    IEnumerator TransitionFase()
    {
        yield return new WaitForSeconds(3f);
        GameManager.completeLevel();
    }

    public void confirmarTentativa() //Esta Função é chamada quando o botão CONFIRMAR é clicado
    {  //Nessa função os resultados são gerados baseados nas booleanas da função anterior, no momento em que o usuário clica na alternativa 
        //a booleana já é marcada como true ou falsa

        btnConfirmar.SetActive(false);


        if (ttentativas == 4 && (correta1 ==false || correta2 == false))
        {
            //Stop the GAME
            GameManager.endGame();
            

        }
        else {

            if (correta1 == true && correta2 == true) //Bolinha cheia e bolinha Cheia
            {
                pontuacaoResposta();

                if (cadeadoAberto == false)
                {
                    abrirCadeado1.speed = 1;
                    abrirCadeado2.speed = 1;
                    abrirCadeado1.Play("CadeadoAbrindo", 0, 0f);
                    abrirCadeado2.Play("CadeadoAbrindo2", 0, 0f);
                    cadeadoAberto = true;


                }


                SomGanhou.Play();
                certo.SetActive(false);
                meio.SetActive(false);
                btnConfirmar.SetActive(false);
                meio2.SetActive(false);

                StartCoroutine(TransitionFase());
                //-----------------------------------//
                

            }
            else
            {
               
            
                if (correta1 == true && correta2 == false && posicaoE2 == false && posicaoE1 == false) //bolinha cheia e Bolinha vazia
                {
                    certo.SetActive(true);
                    resultado[ttentativas] = "C";
                    certo.transform.localPosition = new Vector3(-164, -457, 0);
                    meio.SetActive(false);
                    meio2.SetActive(false);



                }
                else if ((correta1 == true && posicaoE2 == true) || (posicaoE1 == true && correta2 == true))
                {
                    meio.transform.localPosition = new Vector3(-164, -457, 0);
                    meio.SetActive(true);
                    resultado[ttentativas] = "M";
                    certo.SetActive(false);
                    meio2.SetActive(false);

                }
                else if (posicaoE1 == true && correta2 == false && correta1 == false && posicaoE2 == false)
                {
                    meio.SetActive(true);
                    resultado[ttentativas] = "M";
                    meio.transform.localPosition = new Vector3(-164, -457, 0);
                    meio2.SetActive(false);

                }
                else if (posicaoE1 == true && posicaoE2 == true && correta1 == false && correta2 == false)
                {
                    meio.SetActive(true);
                    meio2.SetActive(true);
                    resultado[ttentativas] = "MM";
                    meio.transform.localPosition = new Vector3(-164, -457, 0);
                    meio2.transform.localPosition = new Vector3(-248, -457, 0);

                }
                else if (correta1 == false && correta2 == true && posicaoE1 == false && posicaoE2 == false)
                {
                    certo.SetActive(true);
                    certo.transform.localPosition = new Vector3(-164, -457, 0);
                    resultado[ttentativas] = "C";
                    meio2.SetActive(false);
                    meio.SetActive(false);

                }
                else if (correta1 == false && correta2 == false && posicaoE1 == false && posicaoE2 == false)
                {
                    certo.SetActive(false);
                    meio.SetActive(false);
                    meio2.SetActive(false);

                    resultado[ttentativas] = "E";

                }
                else if (posicaoE2 == true && posicaoE1 == false && correta1 == false && correta1 == false)
                {
                    meio.transform.localPosition = new Vector3(-164, -457, 0);

                    meio.SetActive(true);
                    resultado[ttentativas] = "M";
                    certo.SetActive(false);
                    meio2.SetActive(false);


                }

              
            }
            clique1txt.text = clique1[ttentativas];
            clique2txt.text = clique2[ttentativas];
            ttentativas++;
            tentativas.text = "" + ttentativas;



            txt1 = false;
            txt2 = false;
            textX1.text = " ";
            textX2.text = " ";
        }


        if (ttentativas > 0)
        {
            btnMenu.SetActive(true);
        }



    }
    public int pontuacaoResposta()
    {
        if (correta1 == true && correta2 == true)
        {
            if (ttentativas == 0)
            {
                pontos += 10;
            }
            else if (ttentativas == 1)
            {
                pontos += 8;
            }
            else if (ttentativas == 2)
            {
                pontos += 6;
            }
            else if (ttentativas == 3)
            {
                pontos += 4;
            }
            else if (ttentativas == 4)
            {
                pontos += 2;
            }
           
            
        }
        else
        {
            pontos += 0;
        }
        pontuacao.text = "" + pontos;
        Debug.Log(pontos);
       
        return pontos;
        
    }

    public void proximaFase()
    {
        idFase++;

        GameManager.closeCompleteLevel();
       
          
        clique1txt.text = " ";
        clique2txt.text = " ";
        btnConfirmar.SetActive(false);
        certo.SetActive(false);
        meio.SetActive(false);
        meio2.SetActive(false);
        ttentativas = 0;
        tentativas.text = "";

        txtFase.text = "" + (idFase+1);


        correta1 = false;
        correta2 = false;
        posicaoE1 = false;
        posicaoE2 = false;

        txt1 = false;
        txt2 = false;

        //Referente à animação:
        abrirCadeado1.speed = -1;
        abrirCadeado2.speed = -1;
        abrirCadeado1.Play("CadeadoAbrindo", 0, 0f);
        abrirCadeado2.Play("CadeadoAbrindo2", 0, 0f);
        cadeadoAberto = false;
 
           
        if (alternativaA[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(-90, 9, 0);
            btn0.SetActive(true);


        }
        if (alternativaA[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(-90, 9, 0);
            btn1.SetActive(true);

        }
        if (alternativaA[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(-90, 9, 0);
            btn2.SetActive(true);

        }
        if (alternativaA[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(-90, 9, 0);
            btn3.SetActive(true);

        }
        if (alternativaA[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(-90, 9, 0);
            btn4.SetActive(true);



        }
        if (alternativaA[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(-90, 9, 0);
            btn5.SetActive(true);

        }
        if (alternativaA[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(-90, 9, 0);
            btn6.SetActive(true);

        }
        if (alternativaA[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(-90, 9, 0);
            btn7.SetActive(true);

        }
        if (alternativaA[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(-90, 9, 0);
            btn8.SetActive(true);

        }
        if (alternativaA[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(-90, 9, 0);
            btn9.SetActive(true);

        }
        /////////////////////////////////////////
       
        if (alternativaB[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(90, 9, 0);
            btn0.SetActive(true);


        }
        if (alternativaB[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(90, 9, 0);
            btn1.SetActive(true);

        }
        if (alternativaB[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(90, 9, 0);
            btn2.SetActive(true);

        }
        if (alternativaB[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(90, 9, 0);
            btn3.SetActive(true);

        }
        if (alternativaB[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(90, 9, 0);
            btn4.SetActive(true);

        }
        if (alternativaB[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(90, 9, 0);
            btn5.SetActive(true);

        }
        if (alternativaB[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(90, 9, 0);
            btn6.SetActive(true);

        }
        if (alternativaB[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(90, 9, 0);
            btn7.SetActive(true);

        }
        if (alternativaB[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(90, 9, 0);
            btn8.SetActive(true);

        }
        if (alternativaB[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(90, 9, 0);
            btn9.SetActive(true);

        }
        ////////////////////////////////////////
        
        if (alternativaC[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(-90, -171, 0);
            btn0.SetActive(true);


        }
        if (alternativaC[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(-90, -171, 0);
            btn1.SetActive(true);

        }
        if (alternativaC[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(-90, -171, 0);
            btn2.SetActive(true);

        }
        if (alternativaC[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(-90, -171, 0);
            btn3.SetActive(true);

        }
        if (alternativaC[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(-90, -171, 0);
            btn4.SetActive(true);

        }
        if (alternativaC[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(-90, -171, 0);
            btn5.SetActive(true);

        }
        if (alternativaC[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(-90, -171, 0);
            btn6.SetActive(true);

        }
        if (alternativaC[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(-90, -171, 0);
            btn7.SetActive(true);

        }
        if (alternativaC[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(-90, -171, 0);
            btn8.SetActive(true);

        }
        if (alternativaC[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(-90, -171, 0);
            btn9.SetActive(true);

        }
        //////////////////////////////////////////////////
       

        if (alternativaD[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(90, -171, 0);
            btn0.SetActive(true);


        }
        if (alternativaD[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(90, -171, 0);
            btn1.SetActive(true);

        }
        if (alternativaD[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(90, -171, 0);
            btn2.SetActive(true);

        }
        if (alternativaD[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(90, -171, 0);
            btn3.SetActive(true);

        }
        if (alternativaD[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(90, -171, 0);
            btn4.SetActive(true);

        }
        if (alternativaD[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(90, -171, 0);
            btn5.SetActive(true);

        }
        if (alternativaD[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(90, -171, 0);
            btn6.SetActive(true);

        }
        if (alternativaD[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(90, -171, 0);
            btn7.SetActive(true);

        }
        if (alternativaD[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(90, -171, 0);
            btn8.SetActive(true);

        }
        if (alternativaD[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(90, -171, 0);
            btn9.SetActive(true);

        }

        textX1.text = " ";
        textX2.text = " ";

        }
    


    

    //criar script Menu() com métodos/funções abrir/fechar menu;
}

    


