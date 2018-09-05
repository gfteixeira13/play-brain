﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class responder : MonoBehaviour
{
	public GameObject btnReiniciar;
    public GameObject btnAvancar;
    
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
    public GameObject certo;
    public GameObject meio;
    

   

    public TextMeshProUGUI txtFase;
    

    public TextMeshProUGUI textX1;
    public TextMeshProUGUI textX2;
    
   

    ////////////
    public string[] alternativaA;
    public string[] alternativaB;
    public string[] alternativaC;
    public string[] alternativaD;
    public string[] corretaN1;
    public string[] corretaN2;
    ///////////   
    private int idFase;

    private int c1, c2;
    private bool txt1; //serve para verificar se o textX1 está vazio
    private bool txt2; //serve para verificar se o textX2 está vazio;
    private bool correta1; //recebe true quando o usuário adivinhar o primeiro número escondido
    private bool correta2; //recebe true quando o usuário adivinhar o segundo número escondido

    private bool posicaoE1; //recebe true quando o usuário acerta porém na posição errada
    private bool posicaoE2; //recebe true quando o usuário acerta porém na posição errada

    private int tentativas;

    void Start()
    {
        tentativas = 0;
        idFase = 0;      
        txtFase.text =""+(idFase+1);
        

        btnAvancar.SetActive(false);
        btnReiniciar.SetActive(false);
        certo.SetActive(false);
        meio.SetActive(false);


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

        correta1 = false;
        correta2 = false;
        posicaoE1 = false;
        posicaoE2 = false;
        txt1 = false;
        txt2 = false;

        

      
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
        if(txt1 == false) //primeiro número clicado
        {         
             if(numero == alternativaA[idFase]) //se o numero clicado for igual ao número da alternativaA[fase X] 
             {
                    textX1.text = alternativaA[idFase]; //textX1 recebe o número do button que foi clicado
                    txt1 = true; //agora o textx1 tem algo, então o txt1 recebe true;
                    if (alternativaA[idFase] == corretaN1[idFase]) //se a alternativa A for igual ao número1 escondido
                    {
                        correta1 = true; //assim o usuário acertou o primeiro número
                    }
                    else if (alternativaA[idFase] == corretaN2[idFase]) //se a alternativa A for igual ao número2 escondido
                    {
                        posicaoE1 = true;  //posição errada recebe verdadeiro.
                    }                     //pois esse foi o primeiro clique, 
             }                            //sendo assim o número1 era pra ser adivinhado, não o número2;

            else if(numero == alternativaB[idFase]) 
            {
                textX1.text = alternativaB[idFase];
                txt1 = true;
                if (alternativaB[idFase] == corretaN1[idFase]) 
                {
                    correta1 = true; 
                }
                else if (alternativaB[idFase] == corretaN2[idFase])
                {
                    posicaoE1 = true;  
                }
            }
            else if (numero == alternativaC[idFase])
            {
                textX1.text = alternativaC[idFase];
                txt1 = true;
                if (alternativaC[idFase] == corretaN1[idFase])
                {
                    correta1 = true;
                }
                else if (alternativaC[idFase] == corretaN2[idFase])
                {
                    posicaoE1 = true;
                }
            }
            else if (numero == alternativaD[idFase])
            {
                textX1.text = alternativaD[idFase];
                txt1 = true;
                if (alternativaD[idFase] == corretaN1[idFase])
                {
                    correta1 = true;
                }
                else if (alternativaD[idFase] == corretaN2[idFase])
                {
                    posicaoE1 = true;
                }
            }





        }///////////////////////////////////////////////////////////////
        else if (txt2 == false) //segundo número clicado
        {
            tentativas = tentativas + 1;
            if(tentativas == 5)
            {
                //Você atingiu o limite de tentativas.

                btnAvancar.SetActive(false);
                btnReiniciar.SetActive(false);

            }
           else if(numero == alternativaA[idFase])
            {
                textX2.text = alternativaA[idFase];
                txt2 = true;
                if(alternativaA[idFase] == corretaN2[idFase]) //acertou o segundo número
                {
                    correta2 = true;

                    if(correta1 == true) //acertou o primeiro número
                    {
                        //infoRespostaN1.text = "Bolinha Cheia";
                       
                      
                            btnAvancar.SetActive(true);
                       
                        btnReiniciar.SetActive(false);
                       
                    }
                    else if(posicaoE1 == true) //errou a posição do primeiro clique
                    {
                        meio.SetActive(true);
                        certo.SetActive(true); 
                        btnReiniciar.SetActive(true);
                    }
                    else if (correta1 == false)
                    {
                        certo.SetActive(true);
                      
                         btnReiniciar.SetActive(true);
                    }
                }
                else if(alternativaA[idFase] == corretaN1[idFase])
                {
                    posicaoE2 = true;
                    
                    if(posicaoE1 == true)
                    {
                        meio.SetActive(true);
                       // infoRespostaN1.text = "Bolinha Metade";
                        //infoRespostaN2.text = "Bolinha Metade";
                         btnReiniciar.SetActive(true);
                    }
                    else if (correta1 == false)
                    {
                        meio.SetActive(true);
                       // infoRespostaN1.text = "Bolinha Vazia";
                       // infoRespostaN2.text = "Bolinha Metade";
                         btnReiniciar.SetActive(true);
                    }
                    else if(correta1 == true)
                    {
                        certo.SetActive(true);
                        meio.SetActive(true);
                       // infoRespostaN1.text = "Bolinha Cheia";
                        //infoRespostaN2.text = "Bolinha Metade";
                         btnReiniciar.SetActive(true);
                    }

                }
                else if(alternativaA[idFase]  != corretaN2[idFase] && alternativaA[idFase] != corretaN1[idFase])
                {
                    if (correta1 == false)
                    {
                       // infoRespostaN1.text = "Bolinha Vazia";
                       // infoRespostaN2.text = "Bolinha Vazia";
                         btnReiniciar.SetActive(true);
                    }
                    if (posicaoE1 == true)
                    {
                        meio.SetActive(true);
                       // infoRespostaN1.text = "Bolinha Metade";
                       // infoRespostaN2.text = "Bolinha Vazia";
                         btnReiniciar.SetActive(true);
                    }
                    else if(correta1 == true)
                    {
                        certo.SetActive(true);
                       // infoRespostaN1.text = "Bolinha Cheia";
                       // infoRespostaN2.text = "Bolinha Vazia";
                         btnReiniciar.SetActive(true);
                    }
                    
                }

             

            }//////////////////////////////////////////////////////////// -- ///////// -- ////// --//////////////////---- ///////////////////////////
            else if (numero == alternativaB[idFase])
            {
                textX2.text = alternativaB[idFase];
                txt2 = true;
                if (alternativaB[idFase] == corretaN2[idFase]) //acertou o segundo número
                {
                    correta2 = true;

                    if (correta1 == true) //acertou o primeiro número
                    {
                       // infoRespostaN1.text = "Bolinha Cheia";
                     
                        
                       
                        
                            btnAvancar.SetActive(true);
                       
                        btnReiniciar.SetActive(false);
                       
                    }
                    else if (posicaoE1 == true) //errou a posição do primeiro clique
                    {
                        certo.SetActive(true);
                        meio.SetActive(true);
                       // infoRespostaN1.text = "Bolinha Metade";
                       // infoRespostaN2.text = "Bolinha cheia";
                         btnReiniciar.SetActive(true);
                    }
                    else if (correta1 == false)
                    {
                        certo.SetActive(true);
                       // infoRespostaN1.text = "Bolinha Vazia";
                       // infoRespostaN2.text = "Bolinha Cheia";
                         btnReiniciar.SetActive(true);
                    }
                }
                else if (alternativaB[idFase] == corretaN1[idFase])
                {
                    posicaoE2 = true;

                    if (posicaoE1 == true)
                    {
                        meio.SetActive(true);
                       // infoRespostaN1.text = "Bolinha Metade";
                       // infoRespostaN2.text = "Bolinha Metade";
                         btnReiniciar.SetActive(true);
                    }
                    else if (correta1 == false)
                    {
                        meio.SetActive(true);
                        // infoRespostaN1.text = "Bolinha Vazia";
                        // infoRespostaN2.text = "Bolinha Metade";
                        btnReiniciar.SetActive(true);
                    }
                    else if (correta1 == true)
                    {
                        certo.SetActive(true);
                        meio.SetActive(true);
                        // infoRespostaN1.text = "Bolinha Cheia";
                        //infoRespostaN2.text = "Bolinha Metade";
                        btnReiniciar.SetActive(true);
                    }
                }
                else if (alternativaB[idFase] != corretaN2[idFase] && alternativaB[idFase] != corretaN1[idFase])
                {
                    if (correta1 == false)
                    {
                       // infoRespostaN1.text = "Bolinha Vazia";
                        //infoRespostaN2.text = "Bolinha Vazia";
                         btnReiniciar.SetActive(true);
                    }
                    if (posicaoE1 == true)
                    {
                        meio.SetActive(true);
                        //infoRespostaN1.text = "Bolinha Metade";
                        // infoRespostaN2.text = "Bolinha Vazia";
                        btnReiniciar.SetActive(true);
                    }
                    else if (correta1 == true)
                    {
                        certo.SetActive(true);
                       // infoRespostaN1.text = "Bolinha Cheia";
                       // infoRespostaN2.text = "Bolinha Vazia";
                         btnReiniciar.SetActive(true);
                    }

                }
            }////////////////////////// ----- /////////////////////// ---- ///////////////////// ----- //////////////////////////////// ---- ///////////////////////////
            else if (numero == alternativaC[idFase])
            {
                textX2.text = alternativaC[idFase];
                txt2 = true;
                if (alternativaC[idFase] == corretaN2[idFase]) //acertou o segundo número
                {
                    correta2 = true;

                    if (correta1 == true) //acertou o primeiro número
                    {
                       // infoRespostaN1.text = "Bolinha Cheia";
                        //infoRespostaN2.text = "Bolinha Cheia";
                       
                            btnAvancar.SetActive(true);
                        
                        btnReiniciar.SetActive(false);
                        
                    }
                    else if (posicaoE1 == true) //errou a posição do primeiro clique
                    {
                        certo.SetActive(true);
                        meio.SetActive(true);
                        // infoRespostaN1.text = "Bolinha Metade";
                        // infoRespostaN2.text = "Bolinha cheia";
                        btnReiniciar.SetActive(true);
                    }
                    else if (correta1 == false)
                    {
                        certo.SetActive(true);
                       // infoRespostaN1.text = "Bolinha Vazia";
                       // infoRespostaN2.text = "Bolinha Cheia";
                         btnReiniciar.SetActive(true);
                    }
                }
                else if (alternativaC[idFase] == corretaN1[idFase])
                {
                    posicaoE2 = true;

                    if (posicaoE1 == true)
                    {
                        meio.SetActive(true);
                        // infoRespostaN1.text = "Bolinha Metade";
                        // infoRespostaN2.text = "Bolinha Metade";
                        btnReiniciar.SetActive(true);
                    }
                    else if (correta1 == false)
                    {
                        meio.SetActive(true);
                        // infoRespostaN1.text = "BolinhaVazia";
                        // infoRespostaN2.text = "BolinhaMetade";
                        btnReiniciar.SetActive(true);
                    }
                    else if (correta1 == true)
                    {
                        certo.SetActive(true);
                        meio.SetActive(true);
                        // infoRespostaN1.text = "Bolinha Cheia";
                        // infoRespostaN2.text = "Bolinha Metade";
                        btnReiniciar.SetActive(true);
                    }
                }
                else if (alternativaC[idFase] != corretaN2[idFase] && alternativaC[idFase] != corretaN1[idFase])
                {
                    if (correta1 == false)
                    {
                       // infoRespostaN1.text = "Bolinha Vazia";
                       // infoRespostaN2.text = "Bolinha Vazia";
                         btnReiniciar.SetActive(true);
                    }
                    if (posicaoE1 == true)
                    {
                        meio.SetActive(true);
                       // infoRespostaN1.text = "Bolinha Metade";
                       // infoRespostaN2.text = "Bolinha Vazia";
                         btnReiniciar.SetActive(true);
                    }
                    else if (correta1 == true)
                    {
                        certo.SetActive(true);
                        //infoRespostaN1.text = "Bolinha Cheia";
                        //infoRespostaN2.text = "Bolinha Vazia";
                        btnReiniciar.SetActive(true);
                    }

                }
            }///////////////----------//////////////---------------/////////////--------------/////////////------------////////////----------/////////////
            else if (numero == alternativaD[idFase])
            {
                textX2.text = alternativaD[idFase];
                txt2 = true;
                if (alternativaD[idFase] == corretaN2[idFase]) //acertou o segundo número
                {
                    correta2 = true;

                    if (correta1 == true) //acertou o primeiro número
                    {
                      
                           
                            btnAvancar.SetActive(false);
                       
                       
                        btnReiniciar.SetActive(false);
                    }
                    else if (posicaoE1 == true) //errou a posição do primeiro clique
                    {
                        certo.SetActive(true);
                        meio.SetActive(true);
                        // infoRespostaN1.text = "Bolinha Metade";
                        // infoRespostaN2.text = "Bolinha cheia";
                        btnReiniciar.SetActive(true);
                    }
                    else if (correta1 == false)
                    {
                        certo.SetActive(true);
                       // infoRespostaN1.text = "Bolinha Vazia";
                        //infoRespostaN2.text = "Bolinha Cheia";
                         btnReiniciar.SetActive(true);
                    }

                }
                else if (alternativaD[idFase] == corretaN1[idFase])
                {
                    posicaoE2 = true;

                    if (posicaoE1 == true)
                    {
                        meio.SetActive(true);
                        // infoRespostaN1.text = "Bolinha Metade";
                        // infoRespostaN2.text = "Bolinha Metade";
                        btnReiniciar.SetActive(true);
                    }
                    else if (correta1 == false)
                    {
                        meio.SetActive(true);
                        //infoRespostaN1.text = "Bolinha Vazia";
                        //infoRespostaN2.text = "Bolinha Metade";
                        btnReiniciar.SetActive(true);
                    }
                    else if (correta1 == true)
                    {
                        certo.SetActive(true);
                        meio.SetActive(true);
                        // infoRespostaN1.text = "Bolinha Cheia";
                        // infoRespostaN2.text = "Bolinha Metade";
                        btnReiniciar.SetActive(true);
                    }
                }
                else if (alternativaD[idFase] != corretaN2[idFase] && alternativaD[idFase] != corretaN1[idFase])
                {
                    if (correta1 == false)
                    {
                       // infoRespostaN1.text = "Bolinha Vazia";
                        //infoRespostaN2.text = "Bolinha Vazia";
                         btnReiniciar.SetActive(true);
                    }
                    if(posicaoE1 == true)
                    {
                        meio.SetActive(true);
                        // infoRespostaN1.text = "Bolinha Metade";
                        // infoRespostaN2.text = "Bolinha Vazia";
                        btnReiniciar.SetActive(true);
                    }
                    else if (correta1 == true)
                    {
                        certo.SetActive(true);
                       // infoRespostaN1.text = "Bolinha Cheia";
                       // infoRespostaN2.text = "Bolinha Vazia";
                         btnReiniciar.SetActive(true);
                    }

                }
            }


        }



    }

    

    public void proximaFase()
        {
        certo.SetActive(false);
        meio.SetActive(false);
        
        btnAvancar.SetActive(false);
        idFase++;
        txtFase.text = "" + (idFase + 1);

        correta1 = false;
        correta2 = false;

        txt1 = false;
        txt2 = false;
        posicaoE1 = false;
        posicaoE2 = false;
        btnReiniciar.SetActive(false);
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
    
    public void reiniciar()
    {

        certo.SetActive(false);
        meio.SetActive(false);
        correta1 = false;
        correta2 = false;

        txt1 = false;
        txt2 = false;
        posicaoE1 = false;
        posicaoE2 = false;
       

        
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
        //////////////////////////////////////////
     

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

    


