using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class responder : MonoBehaviour
{
    public Animator abrirCadeado1;
    public Animator abrirCadeado2;
    public GameObject imgMenuT;
    public GameManager GameManager;

    public GameObject btnConfirmar; //Botão de Confirmar Tentativa
    public GameObject btnAvancar; // Botão de Avançar de Fase

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
    // Variaveis referente ao menu tentativa
    public GameObject btnMenuT;
    
    public GameObject C1, M1,M11, C2, M2, M22, C3, M3, M33, C4, M4, M44, C5, M5, M55;
    public TextMeshProUGUI cli1_1, cli2_1, cli1_2, cli2_2, cli1_3, cli2_3, cli1_4, cli2_4, cli1_5, cli2_5;

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
    


    void Start() 
    {
        ttentativas = 0; //nenhuma tentativa ainda
        idFase = 0;
        tentativas.text = "";
        txtFase.text = " " + (idFase+1); //mostra fase 1 na tela
        btnAvancar.SetActive(false); 
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

        btnMenuT.SetActive(false);

        //Todos os botões estão invisiveis 
        txt1 = false;
        txt2 = false;
        //As booleanas acimas estão falsas pois os 'TextBox1' e 'TextBox2' não foram preenchidos
        //Objetos referente ao menuTentativa:
        cli1_1.text = "";
        cli2_1.text = "";
        cli1_2.text = "";
        cli2_2.text = "";
        cli1_3.text = "";
        cli2_3.text = "";
        cli1_4.text = "";
        cli2_4.text = "";
        cli1_5.text = "";
        cli2_5.text = "";
        C1.SetActive(false);
        M1.SetActive(false);
        C2.SetActive(false);
        M2.SetActive(false);
        C3.SetActive(false);
        M3.SetActive(false);
        C4.SetActive(false);
        M4.SetActive(false);
        C5.SetActive(false);
        M5.SetActive(false);

        //abrirCadeado1.gameObject.GetComponent<Animator>().enabled = false;


        //Abaixo os botões são alocados em suas devidas posições:

        //Alternativa A -------------------------------Alternativa A----------------Alternativa A-----------------//
        if (alternativaA[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(-90, -21, 0);
            btn0.SetActive(true);


        }
        if (alternativaA[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(-90, -21, 0);
            btn1.SetActive(true);

        }
        if (alternativaA[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(-90, -21, 0);
            btn2.SetActive(true);

        }
        if (alternativaA[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(-90, -21, 0);
            btn3.SetActive(true);

        }
        if (alternativaA[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(-90, -21, 0);
            btn4.SetActive(true);



        }
        if (alternativaA[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(-90, -21, 0);
            btn5.SetActive(true);

        }
        if (alternativaA[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(-90, -21, 0);
            btn6.SetActive(true);

        }
        if (alternativaA[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(-90, -21, 0);
            btn7.SetActive(true);

        }
        if (alternativaA[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(-90, -21, 0);
            btn8.SetActive(true);

        }
        if (alternativaA[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(-90, -21, 0);
            btn9.SetActive(true);

        }

////Alternativa B -------------------------------Alternativa B----------------Alternativa B-----------------
        if (alternativaB[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(90, -21, 0);
            btn0.SetActive(true);


        }
        if (alternativaB[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(90, -21, 0);
            btn1.SetActive(true);

        }
        if (alternativaB[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(90, -21, 0);
            btn2.SetActive(true);

        }
        if (alternativaB[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(90, -21, 0);
            btn3.SetActive(true);

        }
        if (alternativaB[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(90, -21, 0);
            btn4.SetActive(true);

        }
        if (alternativaB[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(90, -21, 0);
            btn5.SetActive(true);

        }
        if (alternativaB[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(90, -21, 0);
            btn6.SetActive(true);

        }
        if (alternativaB[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(90, -21, 0);
            btn7.SetActive(true);

        }
        if (alternativaB[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(90, -21, 0);
            btn8.SetActive(true);

        }
        if (alternativaB[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(90, -21, 0);
            btn9.SetActive(true);

        }
////Alternativa C -------------------------------Alternativa C----------------Alternativa C------------------
        if (alternativaC[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(-90, -200, 0);
            btn0.SetActive(true);


        }
        if (alternativaC[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(-90, -200, 0);
            btn1.SetActive(true);

        }
        if (alternativaC[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(-90, -200, 0);
            btn2.SetActive(true);

        }
        if (alternativaC[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(-90, -200, 0);
            btn3.SetActive(true);

        }
        if (alternativaC[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(-90, -200, 0);
            btn4.SetActive(true);

        }
        if (alternativaC[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(-90, -200, 0);
            btn5.SetActive(true);

        }
        if (alternativaC[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(-90, -200, 0);
            btn6.SetActive(true);

        }
        if (alternativaC[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(-90, -200, 0);
            btn7.SetActive(true);

        }
        if (alternativaC[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(-90, -200, 0);
            btn8.SetActive(true);

        }
        if (alternativaC[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(-90, -200, 0);
            btn9.SetActive(true);

        }
////Alternativa D-------------------------------Alternativa D----------------Alternativa D-----------------
        if (alternativaD[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(90, -200, 0);
            btn0.SetActive(true);


        }
        if (alternativaD[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(90, -200, 0);
            btn1.SetActive(true);

        }
        if (alternativaD[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(90, -200, 0);
            btn2.SetActive(true);

        }
        if (alternativaD[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(90, -200, 0);
            btn3.SetActive(true);

        }
        if (alternativaD[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(90, -200, 0);
            btn4.SetActive(true);

        }
        if (alternativaD[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(90, -200, 0);
            btn5.SetActive(true);

        }
        if (alternativaD[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(90, -200, 0);
            btn6.SetActive(true);

        }
        if (alternativaD[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(90, -200, 0);
            btn7.SetActive(true);

        }
        if (alternativaD[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(90, -200, 0);
            btn8.SetActive(true);

        }
        if (alternativaD[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(90, -200, 0);
            btn9.SetActive(true);

        }
    }





    public void clique(string numero)
    {

       
        if (txt1 == false) //primeiro número clicado
        {
            clique1[ttentativas] = numero;


            if (numero == alternativaA[idFase]) //Compara se o numero clicado foi igual ao número da alternativaA[fase X] 
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

            else if (numero == alternativaB[idFase])
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
            else if (numero == alternativaC[idFase])
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
            else if (numero == alternativaD[idFase])
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

            clique2[ttentativas] = numero;
            if (numero == alternativaA[idFase])
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
            else if (numero == alternativaB[idFase])
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
            else if (numero == alternativaC[idFase])
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
            else if (numero == alternativaD[idFase])
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

    IEnumerator TransitionSubFase()
    {
        yield return new WaitForSeconds(2f);
        btnAvancar.SetActive(true);
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

            if(correta1==true && correta2 == true) //Bolinha cheia e bolinha Cheia
            {
                
                abrirCadeado1.Play("CadeadoAbrindo");
                abrirCadeado2.Play("CadeadoAbrindo2");
                SomGanhou.Play();
                certo.SetActive(false);
                meio.SetActive(false);
                btnConfirmar.SetActive(false);
                meio2.SetActive(false);

                StartCoroutine(TransitionSubFase());




            }
            else if(correta1==true && correta2 == false && posicaoE2==false && posicaoE1==false) //bolinha cheia e Bolinha vazia
            {
                certo.SetActive(true);
                resultado[ttentativas] = "C";
                certo.transform.localPosition = new Vector3(-164, -457, 0);
                meio.SetActive(false);
                meio2.SetActive(false);



            }
            else if((correta1==true && posicaoE2 == true) || (posicaoE1==true && correta2==true))
            {
                meio.transform.localPosition = new Vector3(-164, -457, 0);
                meio.SetActive(true);
                resultado[ttentativas] = "M";
                certo.SetActive(false);
                meio2.SetActive(false);

            }
            else if(posicaoE1==true && correta2==false && correta1==false && posicaoE2==false)
            {
                meio.SetActive(true);
                resultado[ttentativas] = "M";
                meio.transform.localPosition = new Vector3(-164, -457, 0);
                meio2.SetActive(false);

            }
            else if(posicaoE1==true && posicaoE2 == true && correta1==false && correta2==false)
            {
                meio.SetActive(true);
                meio2.SetActive(true);
                resultado[ttentativas] = "MM";
                meio.transform.localPosition = new Vector3(-164, -457, 0);
                meio2.transform.localPosition = new Vector3(-248, -457, 0);

            }
            else if(correta1==false && correta2==true && posicaoE1==false && posicaoE2==false)
            {
                certo.SetActive(true);
                certo.transform.localPosition = new Vector3(-164, -457, 0);
                resultado[ttentativas] = "C";
                meio2.SetActive(false);
                meio.SetActive(false);

            }
            else if(correta1==false && correta2==false && posicaoE1==false && posicaoE2 == false)
            {
                certo.SetActive(false);
                meio.SetActive(false);
                meio2.SetActive(false);
              
                resultado[ttentativas] = "E";

            }
            else if(posicaoE2==true && posicaoE1==false && correta1==false && correta1 == false)
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
        ttentativas = ttentativas + 1;
        tentativas.text = "" + ttentativas;

        txt1 = false;
        txt2 = false;
        textX1.text = " ";
        textX2.text = " ";

        if (ttentativas > 0)
        {
            btnMenuT.SetActive(true);
        }



    }

    public void proximaSubFase()
    {
        if (idFase == 4)
        {
            GameManager.completeLevel();
        }
        else
        {

        
        clique1txt.text = " ";
        clique2txt.text = " ";
        btnConfirmar.SetActive(false);
        certo.SetActive(false);
        meio.SetActive(false);
        meio2.SetActive(false);
        ttentativas = 0;
        tentativas.text = "";
        btnAvancar.SetActive(false);
        idFase++;
        txtFase.text = "" + (idFase+1);


        correta1 = false;
        correta2 = false;
        posicaoE1 = false;
        posicaoE2 = false;

        txt1 = false;
        txt2 = false;

        //--------------------------//
        cli1_1.text = "";
        cli2_1.text = "";
        cli1_2.text = "";
        cli2_2.text = "";
        cli1_3.text = "";
        cli2_3.text = "";
        cli1_4.text = "";
        cli2_4.text = "";
        cli1_5.text = "";
        cli2_5.text = "";

       
        C1.SetActive(false);
        M1.SetActive(false);
        M11.SetActive(false);
        C2.SetActive(false);
        M2.SetActive(false);
        M22.SetActive(false);
        C3.SetActive(false);
        M3.SetActive(false);
        M33.SetActive(false);
        C4.SetActive(false);
        M4.SetActive(false);
        M44.SetActive(false);
        C5.SetActive(false);
        M5.SetActive(false);
        M55.SetActive(false);

        //for para zerar os resultados:
       
     
        
        if (alternativaA[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(-90, -21, 0);
            btn0.SetActive(true);


        }
        if (alternativaA[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(-90, -21, 0);
            btn1.SetActive(true);

        }
        if (alternativaA[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(-90, -21, 0);
            btn2.SetActive(true);

        }
        if (alternativaA[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(-90, -21, 0);
            btn3.SetActive(true);

        }
        if (alternativaA[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(-90, -21, 0);
            btn4.SetActive(true);



        }
        if (alternativaA[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(-90, -21, 0);
            btn5.SetActive(true);

        }
        if (alternativaA[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(-90, -21, 0);
            btn6.SetActive(true);

        }
        if (alternativaA[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(-90, -21, 0);
            btn7.SetActive(true);

        }
        if (alternativaA[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(-90, -21, 0);
            btn8.SetActive(true);

        }
        if (alternativaA[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(-90, -21, 0);
            btn9.SetActive(true);

        }
        /////////////////////////////////////////
       
        if (alternativaB[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(90, -21, 0);
            btn0.SetActive(true);


        }
        if (alternativaB[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(90, -21, 0);
            btn1.SetActive(true);

        }
        if (alternativaB[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(90, -21, 0);
            btn2.SetActive(true);

        }
        if (alternativaB[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(90, -21, 0);
            btn3.SetActive(true);

        }
        if (alternativaB[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(90, -21, 0);
            btn4.SetActive(true);

        }
        if (alternativaB[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(90, -21, 0);
            btn5.SetActive(true);

        }
        if (alternativaB[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(90, -21, 0);
            btn6.SetActive(true);

        }
        if (alternativaB[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(90, -21, 0);
            btn7.SetActive(true);

        }
        if (alternativaB[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(90, -21, 0);
            btn8.SetActive(true);

        }
        if (alternativaB[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(90, -21, 0);
            btn9.SetActive(true);

        }
        ////////////////////////////////////////
        
        if (alternativaC[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(-90, -200, 0);
            btn0.SetActive(true);


        }
        if (alternativaC[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(-90, -200, 0);
            btn1.SetActive(true);

        }
        if (alternativaC[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(-90, -200, 0);
            btn2.SetActive(true);

        }
        if (alternativaC[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(-90, -200, 0);
            btn3.SetActive(true);

        }
        if (alternativaC[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(-90, -200, 0);
            btn4.SetActive(true);

        }
        if (alternativaC[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(-90, -200, 0);
            btn5.SetActive(true);

        }
        if (alternativaC[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(-90, -200, 0);
            btn6.SetActive(true);

        }
        if (alternativaC[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(-90, -200, 0);
            btn7.SetActive(true);

        }
        if (alternativaC[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(-90, -200, 0);
            btn8.SetActive(true);

        }
        if (alternativaC[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(-90, -200, 0);
            btn9.SetActive(true);

        }
        //////////////////////////////////////////////////
       

        if (alternativaD[idFase] == "0")
        {
            btn0.transform.localPosition = new Vector3(90, -200, 0);
            btn0.SetActive(true);


        }
        if (alternativaD[idFase] == "1")
        {
            btn1.transform.localPosition = new Vector3(90, -200, 0);
            btn1.SetActive(true);

        }
        if (alternativaD[idFase] == "2")
        {
            btn2.transform.localPosition = new Vector3(90, -200, 0);
            btn2.SetActive(true);

        }
        if (alternativaD[idFase] == "3")
        {
            btn3.transform.localPosition = new Vector3(90, -200, 0);
            btn3.SetActive(true);

        }
        if (alternativaD[idFase] == "4")
        {
            btn4.transform.localPosition = new Vector3(90, -200, 0);
            btn4.SetActive(true);

        }
        if (alternativaD[idFase] == "5")
        {
            btn5.transform.localPosition = new Vector3(90, -200, 0);
            btn5.SetActive(true);

        }
        if (alternativaD[idFase] == "6")
        {
            btn6.transform.localPosition = new Vector3(90, -200, 0);
            btn6.SetActive(true);

        }
        if (alternativaD[idFase] == "7")
        {
            btn7.transform.localPosition = new Vector3(90, -200, 0);
            btn7.SetActive(true);

        }
        if (alternativaD[idFase] == "8")
        {
            btn8.transform.localPosition = new Vector3(90, -200, 0);
            btn8.SetActive(true);

        }
        if (alternativaD[idFase] == "9")
        {
            btn9.transform.localPosition = new Vector3(90, -200, 0);
            btn9.SetActive(true);

        }

        textX1.text = " ";
        textX2.text = " ";

        }
    }


    public void menuTentativa() //Função referente à "tela" de tentativas
    {
        if (ttentativas != 0)
        {
            imgMenuT.SetActive(true);

            ///------------------/// ///------------------///  ///------------------///
            if (ttentativas == 1)
            {
                cli1_1.text = clique1[0];
                cli2_1.text = clique2[0];


                if (resultado[0] == "C")
                {
                    C1.SetActive(true);
                    C1.transform.localPosition = new Vector3(-112, 231, 0);

                    M1.SetActive(false);
                }
               
                if (resultado[0] == "M")
                {
                    M1.SetActive(true);
                    M1.transform.localPosition = new Vector3(-112, 231, 0);

                    C1.SetActive(false);
                }
                else if (resultado[0] == "MM")
                {
                    M1.SetActive(true);
                    M11.SetActive(true);
                    M1.transform.localPosition = new Vector3(-201, 231, 0);
                    M11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
            }
            else if (ttentativas == 2)
            {
               
                //--------------//
                cli1_1.text = clique1[0];
                cli2_1.text = clique2[0];
                ///------------------///
                cli1_2.text = clique1[1];
                cli2_2.text = clique2[1];


                if (resultado[0] == "C")
                {
                    C1.SetActive(true);
                    C1.transform.localPosition = new Vector3(-112, 231, 0);
                    M11.SetActive(false);

                    M1.SetActive(false);
                }
                if (resultado[0] == "M")
                {
                    M1.SetActive(true);
                    M1.transform.localPosition = new Vector3(-112, 231, 0);
                    M11.SetActive(false);
                    C1.SetActive(false);
                }
                else if (resultado[0] == "MM")
                {
                    M1.SetActive(true);
                    M11.SetActive(true);
                    M1.transform.localPosition = new Vector3(-201, 231, 0);
                    M11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
                ///------------------///
                if (resultado[1] == "C")
                {
                    C2.SetActive(true);
                    C2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);

                    M2.SetActive(false);
                }
                if (resultado[1] == "M")
                {
                    M2.SetActive(true);
                    M2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);
                    C2.SetActive(false);
                }
                else if (resultado[1] == "MM")
                {
                    M2.SetActive(true);
                    M22.SetActive(true);
                    M2.transform.localPosition = new Vector3(-201, 127, 0);
                    M22.transform.localPosition = new Vector3(-112, 127, 0);
                }

            }
            else if (ttentativas == 3)
            {
               
                //--------------//
                cli1_1.text = clique1[0];
                cli2_1.text = clique2[0];
                ///------------------///
                cli1_2.text = clique1[1];
                cli2_2.text = clique2[1];
                ///------------------///
                cli1_3.text = clique1[2];
                cli2_3.text = clique2[2];

                if (resultado[0] == "C")
                {
                    C1.SetActive(true);
                    C1.transform.localPosition = new Vector3(-112, 231, 0);

                    M1.SetActive(false);
                }
                if (resultado[0] == "M")
                {
                    M1.SetActive(true);
                    M1.transform.localPosition = new Vector3(-112, 231, 0);

                    C1.SetActive(false);
                }
                else if (resultado[0] == "MM")
                {
                    M1.SetActive(true);
                    M11.SetActive(true);
                    M1.transform.localPosition = new Vector3(-201, 231, 0);
                    M11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
                ///------------------///
                if (resultado[1] == "C")
                {
                    C2.SetActive(true);
                    C2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);
                    M2.SetActive(false);
                }
                if (resultado[1] == "M")
                {
                    M2.SetActive(true);
                    M2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);

                    C2.SetActive(false);
                }
                else if (resultado[1] == "MM")
                {
                    M2.SetActive(true);
                    M22.SetActive(true);
                    M2.transform.localPosition = new Vector3(-201, 127, 0);
                    M22.transform.localPosition = new Vector3(-112, 127, 0);
                }
                ///------------------///

                if (resultado[2] == "C")
                {
                    C3.SetActive(true);
                    C3.transform.localPosition = new Vector3(-112, 26, 0);
                    M33.SetActive(false);
                    M3.SetActive(false);

                }
                if (resultado[2] == "M")
                {
                    M3.SetActive(true);
                    M3.transform.localPosition = new Vector3(-112, 26, 0);
                    M33.SetActive(false);

                    C3.SetActive(false);
                }
                else if (resultado[2] == "MM")
                {
                    M3.SetActive(true);
                    M33.SetActive(true);
                    M3.transform.localPosition = new Vector3(-201, 26, 0);
                    M33.transform.localPosition = new Vector3(-112, 26, 0);
                }
            }
            //**************************//
            else if (ttentativas == 4)
            {
               
                cli1_1.text = clique1[0];
                cli2_1.text = clique2[0];
                ///------------------///
                cli1_2.text = clique1[1];
                cli2_2.text = clique2[1];
                ///------------------///
                cli1_3.text = clique1[2];
                cli2_3.text = clique2[2];
                ///------------------///
                cli1_4.text = clique1[3];
                cli2_4.text = clique2[3];

                /// ///------------------//////------------------//////------------------///
                if (resultado[0] == "C")
                {
                    C1.SetActive(true);
                    C1.transform.localPosition = new Vector3(-112, 231, 0);
                    M11.SetActive(false);
                    M1.SetActive(false);
                }
                if (resultado[0] == "M")
                {
                    M1.SetActive(true);
                    M1.transform.localPosition = new Vector3(-112, 231, 0);
                    M11.SetActive(false);

                    C1.SetActive(false);
                }
                else if (resultado[0] == "MM")
                {
                    M1.SetActive(true);
                    M11.SetActive(true);
                    M1.transform.localPosition = new Vector3(-201, 231, 0);
                    M11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
                ///------------------///
                if (resultado[1] == "C")
                {
                    C2.SetActive(true);
                    C2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);
                    M2.SetActive(false);
                }
                if (resultado[1] == "M")
                {
                    M2.SetActive(true);
                    M2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);

                    C2.SetActive(false);
                }
                else if (resultado[1] == "MM")
                {
                    M2.SetActive(true);
                    M22.SetActive(true);
                    M2.transform.localPosition = new Vector3(-201, 127, 0);
                    M22.transform.localPosition = new Vector3(-112, 127, 0);
                }
                ///------------------///
              
                if (resultado[2] == "C")
                {
                    C3.SetActive(true);
                    C3.transform.localPosition = new Vector3(-112, 26, 0);
                    M33.SetActive(false);
                    M3.SetActive(false);

                }
                if (resultado[2] == "M")
                {
                    M3.SetActive(true);
                    M3.transform.localPosition = new Vector3(-112, 26, 0);
                    M33.SetActive(false);
                    C3.SetActive(false);
                }
                else if (resultado[2] == "MM")
                {
                    M3.SetActive(true);
                    M33.SetActive(true);
                    M3.transform.localPosition = new Vector3(-201, 26, 0);
                    M33.transform.localPosition = new Vector3(-112, 26, 0);
                }

                ///------------------///
                if (resultado[3] == "C")
                {
                    C4.SetActive(true);
                    C4.transform.localPosition = new Vector3(-112, -70, 0);
                    M44.SetActive(false);
                    M4.SetActive(false);
                }
                if (resultado[3] == "M")
                {
                    M4.SetActive(true);
                    M4.transform.localPosition = new Vector3(-112, -70, 0);
                    M44.SetActive(false);
                    C4.SetActive(false);
                }
                else if (resultado[3] == "MM")
                {
                    M4.SetActive(true);
                    M4.transform.localPosition = new Vector3(-201, -70, 0);
                    M44.SetActive(true);
                    M44.transform.localPosition = new Vector3(-112, -70, 0);
                }
                ///------------------///

            }
            ///------------------//////------------------//////------------------//////------------------//////------------------///
            else if (ttentativas == 5)
            {
               

                cli1_1.text = clique1[0];
                cli2_1.text = clique2[0];
                ///------------------///
                cli1_2.text = clique1[1];
                cli2_2.text = clique2[1];
                ///------------------///
                cli1_3.text = clique1[2];
                cli2_3.text = clique2[2];
                ///------------------///
                cli1_4.text = clique1[3];
                cli2_4.text = clique2[3];
                ///------------------///
                cli1_5.text = clique1[4];
                cli2_5.text = clique2[4];
                ///------------------/// ///------------------//////------------------//////------------------///
                if (resultado[0] == "C")
                {
                    C1.SetActive(true);
                    C1.transform.localPosition = new Vector3(-112, 231, 0);
                    M11.SetActive(false);
                    M1.SetActive(false);
                }
                if (resultado[0] == "M")
                {
                    M1.SetActive(true);
                    M1.transform.localPosition = new Vector3(-112, 231, 0);
                    M11.SetActive(false);

                    C1.SetActive(false);
                }
               else if (resultado[0] == "MM")
                {
                    M1.SetActive(true);
                    M11.SetActive(true);
                    M1.transform.localPosition = new Vector3(-201, 231, 0);
                    M11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
                ///------------------///
                if (resultado[1] == "C")
                {
                    C2.SetActive(true);
                    C2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);
                    M2.SetActive(false);
                }
                if (resultado[1] == "M")
                {
                    M2.SetActive(true);
                    M2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);

                    C2.SetActive(false);
                }
              else  if (resultado[1] == "MM")
                {
                    M2.SetActive(true);
                    M22.SetActive(true);
                    M2.transform.localPosition = new Vector3(-201, 127, 0);
                    M22.transform.localPosition = new Vector3(-112, 127, 0);
                }
                ///------------------///
                ///------------------///
                if (resultado[2] == "C")
                {
                    C3.SetActive(true);
                    C3.transform.localPosition = new Vector3(-112, 26, 0);
                    M33.SetActive(false);
                    M3.SetActive(false);

                }
                if (resultado[2] == "M")
                {
                    M3.SetActive(true);
                    M3.transform.localPosition = new Vector3(-112, 26, 0);
                    M33.SetActive(false);

                    C3.SetActive(false);
                }
              else  if (resultado[2] == "MM")
                {
                    M3.SetActive(true);
                    M33.SetActive(true);
                    M3.transform.localPosition = new Vector3(-201, 26, 0);
                    M33.transform.localPosition = new Vector3(-112, 26, 0);
                }

                ///------------------///
                if (resultado[3] == "C")
                {
                    C4.SetActive(true);
                    C4.transform.localPosition = new Vector3(-112, -70, 0);
                    M44.SetActive(false);
                    M4.SetActive(false);
                }
                if (resultado[3] == "M")
                {
                    M4.SetActive(true);
                    M4.transform.localPosition = new Vector3(-112, -70, 0);
                    M44.SetActive(false);

                    C4.SetActive(false);
                }
              else  if (resultado[3] == "MM")
                {
                    M4.SetActive(true);
                    M4.transform.localPosition = new Vector3(-201, -70, 0);
                    M44.SetActive(true);
                    M44.transform.localPosition = new Vector3(-112, -70, 0);
                }
                ///------------------///
                if (resultado[4] == "C")
                {
                    C5.SetActive(true);
                    C5.transform.localPosition = new Vector3(-112, -178, 0);
                    M55.SetActive(false);
                    M5.SetActive(false);
                }
                if (resultado[4] == "M")
                {
                    M5.SetActive(true);
                    M5.transform.localPosition = new Vector3(-112, -178, 0);
                    M55.SetActive(false);
                    C5.SetActive(false);
                }
              else  if (resultado[4] == "MM")
                {
                    M4.SetActive(true);
                    M44.SetActive(true);
                    M4.transform.localPosition = new Vector3(-201, 231, 0);
                    M44.transform.localPosition = new Vector3(-112, 231, 0);
                }
            }
        }
       
            
    }
   
    public void fecharMenuTentativa()
    {
        imgMenuT.SetActive(false);
    }

    
}

    


