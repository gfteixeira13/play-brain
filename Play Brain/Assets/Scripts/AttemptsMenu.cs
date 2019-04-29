using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AttemptsMenu : MonoBehaviour
{
    public GameObject imgMenuT;
    public GameObject F1, H1, H11, F2, H2, H22, F3, H3, H33, F4, H4, H44, F5, H5, H55;
    public TextMeshProUGUI cli1_1, cli2_1, cli1_2, cli2_2, cli1_3, cli2_3, cli1_4, cli2_4, cli1_5, cli2_5;

    public void Start()
    {
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
        F1.SetActive(false);
        H1.SetActive(false);
        H11.SetActive(false);
        F2.SetActive(false);
        H2.SetActive(false);
        H22.SetActive(false);
        F3.SetActive(false);
        H3.SetActive(false);
        H33.SetActive(false);
        F4.SetActive(false);
        H4.SetActive(false);
        H44.SetActive(false);
        F5.SetActive(false);
        H5.SetActive(false);
        H55.SetActive(false);
    }

    /// <summary>
    /// Traz dados da Fase para o Menu de Tentativas
    /// </summary>
    /// <param name="GC">Controlador do Game</param>
    public void F_AttemptsMenu(GameController GC) //Função referente à "tela" de tentativas
    {
        if (GC.attempts != 0)
        {
            imgMenuT.SetActive(true);

            ///------------------/// ///------------------///  ///------------------///
            if (GC.attempts == 1)
            {
                cli1_1.text = GC.click1[0];
                cli2_1.text = GC.click2[0];


                if (GC.result[0] == "F")
                {
                    F1.SetActive(true);
                    F1.transform.localPosition = new Vector3(-112, 231, 0);

                    H1.SetActive(false);
                }

                if (GC.result[0] == "H")
                {
                    H1.SetActive(true);
                    H1.transform.localPosition = new Vector3(-112, 231, 0);

                    F1.SetActive(false);
                }
                else if (GC.result[0] == "HH")
                {
                    H1.SetActive(true);
                    H11.SetActive(true);
                    H1.transform.localPosition = new Vector3(-201, 231, 0);
                    H11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
            }
            else if (GC.attempts == 2)
            {

                //--------------//
                cli1_1.text = GC.click1[0];
                cli2_1.text = GC.click2[0];
                ///------------------///
                cli1_2.text = GC.click1[1];
                cli2_2.text = GC.click2[1];


                if (GC.result[0] == "F")
                {
                    F1.SetActive(true);
                    F1.transform.localPosition = new Vector3(-112, 231, 0);
                    H11.SetActive(false);

                    H1.SetActive(false);
                }
                if (GC.result[0] == "H")
                {
                    H1.SetActive(true);
                    H1.transform.localPosition = new Vector3(-112, 231, 0);
                    H11.SetActive(false);
                    F1.SetActive(false);
                }
                else if (GC.result[0] == "HH")
                {
                    H1.SetActive(true);
                    H11.SetActive(true);
                    H1.transform.localPosition = new Vector3(-201, 231, 0);
                    H11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
                ///------------------///
                if (GC.result[1] == "F")
                {
                    F2.SetActive(true);
                    F2.transform.localPosition = new Vector3(-112, 127, 0);
                    H22.SetActive(false);

                    H2.SetActive(false);
                }
                if (GC.result[1] == "H")
                {
                    H2.SetActive(true);
                    H2.transform.localPosition = new Vector3(-112, 127, 0);
                    H22.SetActive(false);
                    F2.SetActive(false);
                }
                else if (GC.result[1] == "HH")
                {
                    H2.SetActive(true);
                    H22.SetActive(true);
                    H2.transform.localPosition = new Vector3(-201, 127, 0);
                    H22.transform.localPosition = new Vector3(-112, 127, 0);
                }

            }
            else if (GC.attempts == 3)
            {

                //--------------//
                cli1_1.text = GC.click1[0];
                cli2_1.text = GC.click2[0];
                ///------------------///
                cli1_2.text = GC.click1[1];
                cli2_2.text = GC.click2[1];
                ///------------------///
                cli1_3.text = GC.click1[2];
                cli2_3.text = GC.click2[2];

                if (GC.result[0] == "F")
                {
                    F1.SetActive(true);
                    F1.transform.localPosition = new Vector3(-112, 231, 0);

                    H1.SetActive(false);
                }
                if (GC.result[0] == "H")
                {
                    H1.SetActive(true);
                    H1.transform.localPosition = new Vector3(-112, 231, 0);

                    F1.SetActive(false);
                }
                else if (GC.result[0] == "HH")
                {
                    H1.SetActive(true);
                    H11.SetActive(true);
                    H1.transform.localPosition = new Vector3(-201, 231, 0);
                    H11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
                ///------------------///
                if (GC.result[1] == "F")
                {
                    F2.SetActive(true);
                    F2.transform.localPosition = new Vector3(-112, 127, 0);
                    H22.SetActive(false);
                    H2.SetActive(false);
                }
                if (GC.result[1] == "H")
                {
                    H2.SetActive(true);
                    H2.transform.localPosition = new Vector3(-112, 127, 0);
                    H22.SetActive(false);

                    F2.SetActive(false);
                }
                else if (GC.result[1] == "HH")
                {
                    H2.SetActive(true);
                    H22.SetActive(true);
                    H2.transform.localPosition = new Vector3(-201, 127, 0);
                    H22.transform.localPosition = new Vector3(-112, 127, 0);
                }
                ///------------------///

                if (GC.result[2] == "F")
                {
                    F3.SetActive(true);
                    F3.transform.localPosition = new Vector3(-112, 26, 0);
                    H33.SetActive(false);
                    H3.SetActive(false);

                }
                if (GC.result[2] == "H")
                {
                    H3.SetActive(true);
                    H3.transform.localPosition = new Vector3(-112, 26, 0);
                    H33.SetActive(false);

                    F3.SetActive(false);
                }
                else if (GC.result[2] == "HH")
                {
                    H3.SetActive(true);
                    H33.SetActive(true);
                    H3.transform.localPosition = new Vector3(-201, 26, 0);
                    H33.transform.localPosition = new Vector3(-112, 26, 0);
                }
            }
            //**************************//
            else if (GC.attempts == 4)
            {

                cli1_1.text = GC.click1[0];
                cli2_1.text = GC.click2[0];
                ///------------------///
                cli1_2.text = GC.click1[1];
                cli2_2.text = GC.click2[1];
                ///------------------///
                cli1_3.text = GC.click1[2];
                cli2_3.text = GC.click2[2];
                ///------------------///
                cli1_4.text = GC.click1[3];
                cli2_4.text = GC.click2[3];

                /// ///------------------//////------------------//////------------------///
                if (GC.result[0] == "F")
                {
                    F1.SetActive(true);
                    F1.transform.localPosition = new Vector3(-112, 231, 0);
                    H11.SetActive(false);
                    H1.SetActive(false);
                }
                if (GC.result[0] == "H")
                {
                    H1.SetActive(true);
                    H1.transform.localPosition = new Vector3(-112, 231, 0);
                    H11.SetActive(false);

                    F1.SetActive(false);
                }
                else if (GC.result[0] == "HH")
                {
                    H1.SetActive(true);
                    H11.SetActive(true);
                    H1.transform.localPosition = new Vector3(-201, 231, 0);
                    H11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
                ///------------------///
                if (GC.result[1] == "F")
                {
                    F2.SetActive(true);
                    F2.transform.localPosition = new Vector3(-112, 127, 0);
                    H22.SetActive(false);
                    H2.SetActive(false);
                }
                if (GC.result[1] == "H")
                {
                    H2.SetActive(true);
                    H2.transform.localPosition = new Vector3(-112, 127, 0);
                    H22.SetActive(false);

                    F2.SetActive(false);
                }
                else if (GC.result[1] == "HH")
                {
                    H2.SetActive(true);
                    H22.SetActive(true);
                    H2.transform.localPosition = new Vector3(-201, 127, 0);
                    H22.transform.localPosition = new Vector3(-112, 127, 0);
                }
                ///------------------///

                if (GC.result[2] == "F")
                {
                    F3.SetActive(true);
                    F3.transform.localPosition = new Vector3(-112, 26, 0);
                    H33.SetActive(false);
                    H3.SetActive(false);

                }
                if (GC.result[2] == "H")
                {
                    H3.SetActive(true);
                    H3.transform.localPosition = new Vector3(-112, 26, 0);
                    H33.SetActive(false);
                    F3.SetActive(false);
                }
                else if (GC.result[2] == "HH")
                {
                    H3.SetActive(true);
                    H33.SetActive(true);
                    H3.transform.localPosition = new Vector3(-201, 26, 0);
                    H33.transform.localPosition = new Vector3(-112, 26, 0);
                }

                ///------------------///
                if (GC.result[3] == "F")
                {
                    F4.SetActive(true);
                    F4.transform.localPosition = new Vector3(-112, -70, 0);
                    H44.SetActive(false);
                    H4.SetActive(false);
                }
                if (GC.result[3] == "H")
                {
                    H4.SetActive(true);
                    H4.transform.localPosition = new Vector3(-112, -70, 0);
                    H44.SetActive(false);
                    F4.SetActive(false);
                }
                else if (GC.result[3] == "HH")
                {
                    H4.SetActive(true);
                    H4.transform.localPosition = new Vector3(-201, -70, 0);
                    H44.SetActive(true);
                    H44.transform.localPosition = new Vector3(-112, -70, 0);
                }
                ///------------------///

            }
            ///------------------//////------------------//////------------------//////------------------//////------------------///
            else if (GC.attempts == 5)
            {


                cli1_1.text = GC.click1[0];
                cli2_1.text = GC.click2[0];
                ///------------------///
                cli1_2.text = GC.click1[1];
                cli2_2.text = GC.click2[1];
                ///------------------///
                cli1_3.text = GC.click1[2];
                cli2_3.text = GC.click2[2];
                ///------------------///
                cli1_4.text = GC.click1[3];
                cli2_4.text = GC.click2[3];
                ///------------------///
                cli1_5.text = GC.click1[4];
                cli2_5.text = GC.click2[4];
                ///------------------/// ///------------------//////------------------//////------------------///
                if (GC.result[0] == "F")
                {
                    F1.SetActive(true);
                    F1.transform.localPosition = new Vector3(-112, 231, 0);
                    H11.SetActive(false);
                    H1.SetActive(false);
                }
                if (GC.result[0] == "H")
                {
                    H1.SetActive(true);
                    H1.transform.localPosition = new Vector3(-112, 231, 0);
                    H11.SetActive(false);

                    F1.SetActive(false);
                }
                else if (GC.result[0] == "HH")
                {
                    H1.SetActive(true);
                    H11.SetActive(true);
                    H1.transform.localPosition = new Vector3(-201, 231, 0);
                    H11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
                ///------------------///
                if (GC.result[1] == "F")
                {
                    F2.SetActive(true);
                    F2.transform.localPosition = new Vector3(-112, 127, 0);
                    H22.SetActive(false);
                    H2.SetActive(false);
                }
                if (GC.result[1] == "H")
                {
                    H2.SetActive(true);
                    H2.transform.localPosition = new Vector3(-112, 127, 0);
                    H22.SetActive(false);

                    F2.SetActive(false);
                }
                else if (GC.result[1] == "HH")
                {
                    H2.SetActive(true);
                    H22.SetActive(true);
                    H2.transform.localPosition = new Vector3(-201, 127, 0);
                    H22.transform.localPosition = new Vector3(-112, 127, 0);
                }
                ///------------------///
                ///------------------///
                if (GC.result[2] == "F")
                {
                    F3.SetActive(true);
                    F3.transform.localPosition = new Vector3(-112, 26, 0);
                    H33.SetActive(false);
                    H3.SetActive(false);

                }
                if (GC.result[2] == "H")
                {
                    H3.SetActive(true);
                    H3.transform.localPosition = new Vector3(-112, 26, 0);
                    H33.SetActive(false);

                    F3.SetActive(false);
                }
                else if (GC.result[2] == "HH")
                {
                    H3.SetActive(true);
                    H33.SetActive(true);
                    H3.transform.localPosition = new Vector3(-201, 26, 0);
                    H33.transform.localPosition = new Vector3(-112, 26, 0);
                }

                ///------------------///
                if (GC.result[3] == "F")
                {
                    F4.SetActive(true);
                    F4.transform.localPosition = new Vector3(-112, -70, 0);
                    H44.SetActive(false);
                    H4.SetActive(false);
                }
                if (GC.result[3] == "H")
                {
                    H4.SetActive(true);
                    H4.transform.localPosition = new Vector3(-112, -70, 0);
                    H44.SetActive(false);

                    F4.SetActive(false);
                }
                else if (GC.result[3] == "HH")
                {
                    H4.SetActive(true);
                    H4.transform.localPosition = new Vector3(-201, -70, 0);
                    H44.SetActive(true);
                    H44.transform.localPosition = new Vector3(-112, -70, 0);
                }
                ///------------------///
                if (GC.result[4] == "F")
                {
                    F5.SetActive(true);
                    F5.transform.localPosition = new Vector3(-112, -178, 0);
                    H55.SetActive(false);
                    H5.SetActive(false);
                }
                if (GC.result[4] == "H")
                {
                    H5.SetActive(true);
                    H5.transform.localPosition = new Vector3(-112, -178, 0);
                    H55.SetActive(false);
                    F5.SetActive(false);
                }
                else if (GC.result[4] == "HH")
                {
                    H4.SetActive(true);
                    H44.SetActive(true);
                    H4.transform.localPosition = new Vector3(-201, 231, 0);
                    H44.transform.localPosition = new Vector3(-112, 231, 0);
                }
            }
        }


    }
    /// <summary>
    /// Fecha o Menu de Tentativas
    /// </summary>
    public void CloseAttemptsMenu()
    {
        imgMenuT.SetActive(false);
    }

}
