using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class responder : MonoBehaviour
{
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




    public TextMeshProUGUI txtFase;
    public TextMeshProUGUI tentativas;
    public TextMeshProUGUI textX1; //Objeto de Texto (Simboliza uma textBox1)
    public TextMeshProUGUI textX2; //Objeto de Texto(Simboliza uma textBox2)



    ////////////Strings das Alternativas e dos números corretos(são definidos no gameObject na interface da Unity)
    public string[] alternativaA;
    public string[] alternativaB;
    public string[] alternativaC;
    public string[] alternativaD;
    public string[] corretaN1;
    public string[] corretaN2;

    ///////////Número da Fase:
   public int idFase; 

    private int c1, c2;
    private bool txt1; //serve para verificar se o textX1 está vazio
    private bool txt2; //serve para verificar se o textX2 está vazio;
    
    //booleanas que nos dão o resultado
    public bool correta1;
    public bool correta2;
    public bool posicaoE1;
    public bool posicaoE2;


    private int ttentativas;

    void Start() 
    {
        ttentativas = 5; //nenhuma tentativa ainda
        idFase = 0;
        tentativas.text = ""+ttentativas;
        txtFase.text = " " + (idFase+1); //mostra fase 1 na tela
        btnAvancar.SetActive(false); 
        certo.SetActive(false);
        meio.SetActive(false);
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
        
        //Todos os botões estão invisiveis 
        txt1 = false;
        txt2 = false;
        //As booleanas acimas estão falsas pois os 'TextBox1' e 'TextBox2' não foram preenchidos



        //Abaixo os botçoes são alocados em suas devidas posições:

////Alternativa A -------------------------------Alternativa A----------------Alternativa A-----------------
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
            if (numero == alternativaA[idFase]) //Compara se o numero clicado foi igual ao número da alternativaA[fase X] 
            {
                textX1.text = alternativaA[idFase]; //textX1 recebe o número do button que foi clicado - nesse cado o nº da alternativa A
                txt1 = true; //agora o textx1 tem algo, então o txt1 recebe true;
                if (alternativaA[idFase] == corretaN1[idFase]) //se a alternativa A for igual ao número1 escondido
                {
                    correta1 = true; //assim o usuário acertou o primeiro número
                    posicaoE1 = false;
                }
                else if (alternativaA[idFase] == corretaN2[idFase]) //se a alternativa A for igual ao segundo número escondido
                {
                    posicaoE1 = true;  //posição errada recebe verdadeiro.
                    correta1 = false;
                }
                else if ((alternativaA[idFase] != corretaN1[idFase]) && (alternativaA[idFase] != corretaN2[idFase]))
                {
                    correta1 = false;
                    posicaoE1 = false;
                }
            }                            

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

        }
    }


    public void confirmarTentativa()
    {

        btnConfirmar.SetActive(false);

            ttentativas = ttentativas - 1;
            tentativas.text = "" + ttentativas;

            txt1 = false;
            txt2 = false;
            textX1.text = " ";
            textX2.text = " ";

        if(correta1==true && correta2 == true) //Bolinha cheia e bolinha Cheia
        {
            btnAvancar.SetActive(true);
            certo.SetActive(false);
            meio.SetActive(false);
            btnConfirmar.SetActive(false);
        }
        else if(correta1==true && correta2 == false && posicaoE2==false && posicaoE1==false) //bolinha cheia e Bolinha vazia
        {
            certo.SetActive(true);
            meio.SetActive(false);
        }
        else if((correta1==true && posicaoE2 == true) || (posicaoE1==true && correta2==true))
        {
            meio.transform.localPosition = new Vector3(-247, -457, 0);

            meio.SetActive(true);
            certo.SetActive(false);
        }
        else if(posicaoE1==true && correta2==false && correta1==false && posicaoE2==false)
        {
            meio.SetActive(true);
            meio.transform.localPosition = new Vector3(-247, -457, 0);

        }
        else if(posicaoE1==true && posicaoE2 == true && correta1==false && correta2==false)
        {
            meio.SetActive(true);
            meio.transform.localPosition = new Vector3(-247, -457, 0);

        }
        else if(correta1==false && correta2==true && posicaoE1==false && posicaoE2==false)
        {
            certo.SetActive(true);
            meio.SetActive(false);
        }
        else if(correta1==false && correta2==false && posicaoE1==false && posicaoE2 == false)
        {
            certo.SetActive(false);
            meio.SetActive(false);
        }
        else if(posicaoE2==true && posicaoE1==false && correta1==false && correta1 == false)
        {
            meio.transform.localPosition = new Vector3(-247, -457, 0);

            meio.SetActive(true);
            certo.SetActive(false);
        }

    }
    public void proximaSubFase()
        {
     
        btnConfirmar.SetActive(false);
        certo.SetActive(false);
        meio.SetActive(false);
        ttentativas = 5;
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
       
        //////////////////////////////////////////
        
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
       // infoRespostaN1.text = " ";
       // infoRespostaN2.text = " ";

    }
    
  

    
}

    


