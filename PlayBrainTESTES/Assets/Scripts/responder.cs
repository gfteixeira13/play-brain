using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class responder : MonoBehaviour
{
    public GameObject btnAvancar;
    public GameObject btn0;
    public GameObject btn1;
    public GameObject btn2;//
    public GameObject btn3;
    public GameObject btn4;//
    public GameObject btn5;
    public GameObject btn6;//
    public GameObject btn7;//
    public GameObject btn8;
    public GameObject btn9;
    // Use this for initialization

    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public Text infoResposta;
    public Text txtFase;
    public Text textX1;
    public Text textX2;
    //números escondidos que precisam ser adivinhados.

   
    //alternativas 
    public string[] alternativaA;
    public string[] alternativaB;
    public string[] alternativaC;
    public string[] alternativaD;

    ///////////

    public string[] corretaN1;
    public string[] corretaN2;
    private int idFase;

    private bool txt1; //serve para verificar se o textX1 está vazio
    private bool txt2; //serve para verificar se o textX2 está vazio;
    private bool correta1;
    private bool correta2;

    private bool posicaoE;

    void Start()
    {
      
        idFase = 0;
        txtFase.text = "Fase " + (idFase+1);

       btnAvancar.SetActive(false);

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
        posicaoE = false;
        txt1 = false;
        txt2 = false;

        

        respostaA.text = alternativaA[idFase];
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
        respostaB.text = alternativaB[idFase];
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
        respostaC.text = alternativaC[idFase];
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
        respostaD.text = alternativaD[idFase];

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





    public void clique(string alternativa)
    {

        if (alternativa == "A") //alternativa clicadao = A
        {
            if (txt1 == false) //textx1 está vazio
            {

                textX1.text = alternativaA[idFase]; // preenche textX1 com o numero da alternativa A
                txt1 = true;
                if (alternativaA[idFase] == corretaN1[idFase]) //compara a alternativa A com o número escondido
                {


                    correta1 = true; //alternativaA é igual ao primeiro número escondido


                }
               if (alternativaA[idFase] == corretaN2[idFase]) //alternativaA é igual ao segundo número escondido, sendo assim a posição está incorreta
                {


                    posicaoE = true; //posição errada recebe true
                }
            }


            else if (txt2 == false)
            { //preenche o textX2 com a alternativa A

                textX2.text = alternativaA[idFase]; //text2 recebe a alternativaA
                txt2 = true; //text2 não está vazio
                if (alternativaA[idFase] == corretaN2[idFase]) //compara a alternativa A com o número2 escondido
                {


                    correta2 = true; 

                    if (correta1 == true)  //correta2 já recebeu true no if acima. Já este if compara se o primeiro número a ser adivinhado já foi acertado.
                    {
                        infoResposta.text = "Você acertou";
                        btnAvancar.SetActive(true);
                    }
                    else if (posicaoE == true) //se o número n1 não foi acertado antes de dar as resposta como errada ele compara se a posição errada recebeu true.
                    {
                        infoResposta.text = "Meio certo";
                    }





                }
                else if (alternativaA[idFase] == corretaN1[idFase])
                {
                    posicaoE = true;
                    infoResposta.text = "Meio certo";

                }

                else if (alternativaA[idFase] != corretaN2[idFase])
                {

                    if (correta1 == true)
                    {
                        infoResposta.text = "Meio certo";
                    }
                    else if (posicaoE == true)
                    {
                        infoResposta.text = "Meio certo";
                    }

                }

            }


        }/////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////
        else if (alternativa == "B")
        {
            if (txt1 == false)
            {

                textX1.text = alternativaB[idFase]; // preenche textX1 com o numero da alternativa B
                txt1 = true;
                if (alternativaB[idFase] == corretaN1[idFase]) //compara a alternativa A com o número escondido
                {


                    correta1 = true; //primeiro número selecionado correto recebe true


                }
                else if (alternativaB[idFase] == corretaN2[idFase])
                {

                    posicaoE = true;
                }
            }


            else if (txt2 == false)
            { //preenche o textX2 com a alternativa B

                textX2.text = alternativaB[idFase];
                txt2 = true;
                if (alternativaB[idFase] == corretaN2[idFase])
                {


                    correta2 = true;
                    if (correta1 == true)
                    {
                        infoResposta.text = "Você acertou";
                        btnAvancar.SetActive(true);
                    }
                    else if (posicaoE == true)
                    {
                        infoResposta.text = "Meio certo";
                    }





                }
                else if (alternativaB[idFase] == corretaN1[idFase])
                {
                    posicaoE = true;
                    infoResposta.text = "Meio certo";

                }

                else if (alternativaB[idFase] != corretaN2[idFase])
                {

                    if (correta1 == true)
                    {
                        infoResposta.text = "Meio certo";
                    }
                    else if (posicaoE == true)
                    {
                        infoResposta.text = "Meio certo";
                    }


                }





            }
        }/////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////
        else if (alternativa == "C")
        {
            if (txt1 == false)
            {

                textX1.text = alternativaC[idFase]; // preenche textX1 com o numero da alternativa C
                txt1 = true;
                if (alternativaC[idFase] == corretaN1[idFase]) //compara a alternativa A com o número escondido
                {


                    correta1 = true; //primeiro número selecionado correto recebe true


                }
                else if (alternativaC[idFase] == corretaN2[idFase])
                {

                    posicaoE = true;
                }
            }




            else if (txt2 == false)
            { //preenche o textX2 com a alternativa C

                textX2.text = alternativaC[idFase];
                txt2 = true;
                if (alternativaC[idFase] == corretaN2[idFase])
                {


                    correta2 = true;
                    if (correta1 == true)
                    {
                        infoResposta.text = "Você acertou";
                        btnAvancar.SetActive(true);
                    }
                    else if (posicaoE == true)
                    {
                        infoResposta.text = "Meio certo";
                    }





                }
                else if (alternativaC[idFase] == corretaN1[idFase])
                {
                    posicaoE = true;
                    infoResposta.text = "Meio certo";

                }
                else if (alternativaC[idFase] != corretaN2[idFase])
                {
                    if (correta1 == true)
                    {
                        infoResposta.text = "Meio certo";
                    }
                    else if(posicaoE == true)
                    {
                        infoResposta.text = "Meio certo";
                    }
                }


            }
        }/////////////////////////////////////////////////////////////////////////////
         //////////////////////////////////////////////////////////////////////////////
         /////////////////////////////////////////////////////////////////////////////
        else if (alternativa == "D")
        {
            if (txt1 == false)
            {

                textX1.text = alternativaD[idFase]; // preenche textX1 com o numero da alternativa C
                txt1 = true;
                if (alternativaD[idFase] == corretaN1[idFase]) //compara a alternativa A com o número escondido
                {


                    correta1 = true; //primeiro número selecionado correto recebe true


                }
                else if (alternativaD[idFase] == corretaN2[idFase])
                {

                    posicaoE = true;
                }
            }




            else if (txt2 == false)
            { //preenche o textX2 com a alternativa C

                textX2.text = alternativaD[idFase];
                txt2 = true;
                if (alternativaD[idFase] == corretaN2[idFase])
                {


                    correta2 = true;
                    if (correta1 == true)
                    {
                        infoResposta.text = "Você acertou";
                        btnAvancar.SetActive(true);
                    }
                    else if (posicaoE == true)
                    {
                        infoResposta.text = "Meio certo";
                    }





                }
                else if (alternativaD[idFase] == corretaN1[idFase])
                {
                    posicaoE = true;
                    infoResposta.text = "Meio certo";

                }
                else if (alternativaD[idFase] != corretaN2[idFase])
                {
                    if (correta1 == true)
                    {
                        infoResposta.text = "Meio certo";
                    }
                    else if (posicaoE == true)
                    {
                        infoResposta.text = "Meio certo";
                    }
                }


            }
        }


    }

    

    public void proximaFase()
        {
        btnAvancar.SetActive(false);
        idFase++;
        txtFase.text = "Fase: " + (idFase + 1);

        correta1 = false;
        correta2 = false;

        txt1 = false;
        txt2 = false;
        posicaoE = false;
        
        //////////////////////////////////////////
        respostaA.text = alternativaA[idFase];
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
        respostaB.text = alternativaB[idFase];
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
        respostaC.text = alternativaC[idFase];
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
        respostaD.text = alternativaD[idFase];

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
        infoResposta.text = " ";

    }
    
    public void reiniciar()
    {
        

        correta1 = false;
        correta2 = false;

        txt1 = false;
        txt2 = false;
        posicaoE = false;
       

        respostaA.text = alternativaA[idFase];
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
        respostaB.text = alternativaB[idFase];
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
        respostaC.text = alternativaC[idFase];
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
        respostaD.text = alternativaD[idFase];

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
        infoResposta.text = " ";
    }

    
}

    


