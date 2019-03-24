using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject imgMenuT;
    public GameObject C1, M1, M11, C2, M2, M22, C3, M3, M33, C4, M4, M44, C5, M5, M55;
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
    }


    public void menuTentativa(GameController GC) //Função referente à "tela" de tentativas
    {
        if (GC.ttentativas != 0)
        {
            imgMenuT.SetActive(true);

            ///------------------/// ///------------------///  ///------------------///
            if (GC.ttentativas == 1)
            {
                cli1_1.text = GC.clique1[0];
                cli2_1.text = GC.clique2[0];


                if (GC.resultado[0] == "C")
                {
                    C1.SetActive(true);
                    C1.transform.localPosition = new Vector3(-112, 231, 0);

                    M1.SetActive(false);
                }

                if (GC.resultado[0] == "M")
                {
                    M1.SetActive(true);
                    M1.transform.localPosition = new Vector3(-112, 231, 0);

                    C1.SetActive(false);
                }
                else if (GC.resultado[0] == "MM")
                {
                    M1.SetActive(true);
                    M11.SetActive(true);
                    M1.transform.localPosition = new Vector3(-201, 231, 0);
                    M11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
            }
            else if (GC.ttentativas == 2)
            {

                //--------------//
                cli1_1.text = GC.clique1[0];
                cli2_1.text = GC.clique2[0];
                ///------------------///
                cli1_2.text = GC.clique1[1];
                cli2_2.text = GC.clique2[1];


                if (GC.resultado[0] == "C")
                {
                    C1.SetActive(true);
                    C1.transform.localPosition = new Vector3(-112, 231, 0);
                    M11.SetActive(false);

                    M1.SetActive(false);
                }
                if (GC.resultado[0] == "M")
                {
                    M1.SetActive(true);
                    M1.transform.localPosition = new Vector3(-112, 231, 0);
                    M11.SetActive(false);
                    C1.SetActive(false);
                }
                else if (GC.resultado[0] == "MM")
                {
                    M1.SetActive(true);
                    M11.SetActive(true);
                    M1.transform.localPosition = new Vector3(-201, 231, 0);
                    M11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
                ///------------------///
                if (GC.resultado[1] == "C")
                {
                    C2.SetActive(true);
                    C2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);

                    M2.SetActive(false);
                }
                if (GC.resultado[1] == "M")
                {
                    M2.SetActive(true);
                    M2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);
                    C2.SetActive(false);
                }
                else if (GC.resultado[1] == "MM")
                {
                    M2.SetActive(true);
                    M22.SetActive(true);
                    M2.transform.localPosition = new Vector3(-201, 127, 0);
                    M22.transform.localPosition = new Vector3(-112, 127, 0);
                }

            }
            else if (GC.ttentativas == 3)
            {

                //--------------//
                cli1_1.text = GC.clique1[0];
                cli2_1.text = GC.clique2[0];
                ///------------------///
                cli1_2.text = GC.clique1[1];
                cli2_2.text = GC.clique2[1];
                ///------------------///
                cli1_3.text = GC.clique1[2];
                cli2_3.text = GC.clique2[2];

                if (GC.resultado[0] == "C")
                {
                    C1.SetActive(true);
                    C1.transform.localPosition = new Vector3(-112, 231, 0);

                    M1.SetActive(false);
                }
                if (GC.resultado[0] == "M")
                {
                    M1.SetActive(true);
                    M1.transform.localPosition = new Vector3(-112, 231, 0);

                    C1.SetActive(false);
                }
                else if (GC.resultado[0] == "MM")
                {
                    M1.SetActive(true);
                    M11.SetActive(true);
                    M1.transform.localPosition = new Vector3(-201, 231, 0);
                    M11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
                ///------------------///
                if (GC.resultado[1] == "C")
                {
                    C2.SetActive(true);
                    C2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);
                    M2.SetActive(false);
                }
                if (GC.resultado[1] == "M")
                {
                    M2.SetActive(true);
                    M2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);

                    C2.SetActive(false);
                }
                else if (GC.resultado[1] == "MM")
                {
                    M2.SetActive(true);
                    M22.SetActive(true);
                    M2.transform.localPosition = new Vector3(-201, 127, 0);
                    M22.transform.localPosition = new Vector3(-112, 127, 0);
                }
                ///------------------///

                if (GC.resultado[2] == "C")
                {
                    C3.SetActive(true);
                    C3.transform.localPosition = new Vector3(-112, 26, 0);
                    M33.SetActive(false);
                    M3.SetActive(false);

                }
                if (GC.resultado[2] == "M")
                {
                    M3.SetActive(true);
                    M3.transform.localPosition = new Vector3(-112, 26, 0);
                    M33.SetActive(false);

                    C3.SetActive(false);
                }
                else if (GC.resultado[2] == "MM")
                {
                    M3.SetActive(true);
                    M33.SetActive(true);
                    M3.transform.localPosition = new Vector3(-201, 26, 0);
                    M33.transform.localPosition = new Vector3(-112, 26, 0);
                }
            }
            //**************************//
            else if (GC.ttentativas == 4)
            {

                cli1_1.text = GC.clique1[0];
                cli2_1.text = GC.clique2[0];
                ///------------------///
                cli1_2.text = GC.clique1[1];
                cli2_2.text = GC.clique2[1];
                ///------------------///
                cli1_3.text = GC.clique1[2];
                cli2_3.text = GC.clique2[2];
                ///------------------///
                cli1_4.text = GC.clique1[3];
                cli2_4.text = GC.clique2[3];

                /// ///------------------//////------------------//////------------------///
                if (GC.resultado[0] == "C")
                {
                    C1.SetActive(true);
                    C1.transform.localPosition = new Vector3(-112, 231, 0);
                    M11.SetActive(false);
                    M1.SetActive(false);
                }
                if (GC.resultado[0] == "M")
                {
                    M1.SetActive(true);
                    M1.transform.localPosition = new Vector3(-112, 231, 0);
                    M11.SetActive(false);

                    C1.SetActive(false);
                }
                else if (GC.resultado[0] == "MM")
                {
                    M1.SetActive(true);
                    M11.SetActive(true);
                    M1.transform.localPosition = new Vector3(-201, 231, 0);
                    M11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
                ///------------------///
                if (GC.resultado[1] == "C")
                {
                    C2.SetActive(true);
                    C2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);
                    M2.SetActive(false);
                }
                if (GC.resultado[1] == "M")
                {
                    M2.SetActive(true);
                    M2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);

                    C2.SetActive(false);
                }
                else if (GC.resultado[1] == "MM")
                {
                    M2.SetActive(true);
                    M22.SetActive(true);
                    M2.transform.localPosition = new Vector3(-201, 127, 0);
                    M22.transform.localPosition = new Vector3(-112, 127, 0);
                }
                ///------------------///

                if (GC.resultado[2] == "C")
                {
                    C3.SetActive(true);
                    C3.transform.localPosition = new Vector3(-112, 26, 0);
                    M33.SetActive(false);
                    M3.SetActive(false);

                }
                if (GC.resultado[2] == "M")
                {
                    M3.SetActive(true);
                    M3.transform.localPosition = new Vector3(-112, 26, 0);
                    M33.SetActive(false);
                    C3.SetActive(false);
                }
                else if (GC.resultado[2] == "MM")
                {
                    M3.SetActive(true);
                    M33.SetActive(true);
                    M3.transform.localPosition = new Vector3(-201, 26, 0);
                    M33.transform.localPosition = new Vector3(-112, 26, 0);
                }

                ///------------------///
                if (GC.resultado[3] == "C")
                {
                    C4.SetActive(true);
                    C4.transform.localPosition = new Vector3(-112, -70, 0);
                    M44.SetActive(false);
                    M4.SetActive(false);
                }
                if (GC.resultado[3] == "M")
                {
                    M4.SetActive(true);
                    M4.transform.localPosition = new Vector3(-112, -70, 0);
                    M44.SetActive(false);
                    C4.SetActive(false);
                }
                else if (GC.resultado[3] == "MM")
                {
                    M4.SetActive(true);
                    M4.transform.localPosition = new Vector3(-201, -70, 0);
                    M44.SetActive(true);
                    M44.transform.localPosition = new Vector3(-112, -70, 0);
                }
                ///------------------///

            }
            ///------------------//////------------------//////------------------//////------------------//////------------------///
            else if (GC.ttentativas == 5)
            {


                cli1_1.text = GC.clique1[0];
                cli2_1.text = GC.clique2[0];
                ///------------------///
                cli1_2.text = GC.clique1[1];
                cli2_2.text = GC.clique2[1];
                ///------------------///
                cli1_3.text = GC.clique1[2];
                cli2_3.text = GC.clique2[2];
                ///------------------///
                cli1_4.text = GC.clique1[3];
                cli2_4.text = GC.clique2[3];
                ///------------------///
                cli1_5.text = GC.clique1[4];
                cli2_5.text = GC.clique2[4];
                ///------------------/// ///------------------//////------------------//////------------------///
                if (GC.resultado[0] == "C")
                {
                    C1.SetActive(true);
                    C1.transform.localPosition = new Vector3(-112, 231, 0);
                    M11.SetActive(false);
                    M1.SetActive(false);
                }
                if (GC.resultado[0] == "M")
                {
                    M1.SetActive(true);
                    M1.transform.localPosition = new Vector3(-112, 231, 0);
                    M11.SetActive(false);

                    C1.SetActive(false);
                }
                else if (GC.resultado[0] == "MM")
                {
                    M1.SetActive(true);
                    M11.SetActive(true);
                    M1.transform.localPosition = new Vector3(-201, 231, 0);
                    M11.transform.localPosition = new Vector3(-112, 231, 0);
                }
                ///------------------///
                ///------------------///
                if (GC.resultado[1] == "C")
                {
                    C2.SetActive(true);
                    C2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);
                    M2.SetActive(false);
                }
                if (GC.resultado[1] == "M")
                {
                    M2.SetActive(true);
                    M2.transform.localPosition = new Vector3(-112, 127, 0);
                    M22.SetActive(false);

                    C2.SetActive(false);
                }
                else if (GC.resultado[1] == "MM")
                {
                    M2.SetActive(true);
                    M22.SetActive(true);
                    M2.transform.localPosition = new Vector3(-201, 127, 0);
                    M22.transform.localPosition = new Vector3(-112, 127, 0);
                }
                ///------------------///
                ///------------------///
                if (GC.resultado[2] == "C")
                {
                    C3.SetActive(true);
                    C3.transform.localPosition = new Vector3(-112, 26, 0);
                    M33.SetActive(false);
                    M3.SetActive(false);

                }
                if (GC.resultado[2] == "M")
                {
                    M3.SetActive(true);
                    M3.transform.localPosition = new Vector3(-112, 26, 0);
                    M33.SetActive(false);

                    C3.SetActive(false);
                }
                else if (GC.resultado[2] == "MM")
                {
                    M3.SetActive(true);
                    M33.SetActive(true);
                    M3.transform.localPosition = new Vector3(-201, 26, 0);
                    M33.transform.localPosition = new Vector3(-112, 26, 0);
                }

                ///------------------///
                if (GC.resultado[3] == "C")
                {
                    C4.SetActive(true);
                    C4.transform.localPosition = new Vector3(-112, -70, 0);
                    M44.SetActive(false);
                    M4.SetActive(false);
                }
                if (GC.resultado[3] == "M")
                {
                    M4.SetActive(true);
                    M4.transform.localPosition = new Vector3(-112, -70, 0);
                    M44.SetActive(false);

                    C4.SetActive(false);
                }
                else if (GC.resultado[3] == "MM")
                {
                    M4.SetActive(true);
                    M4.transform.localPosition = new Vector3(-201, -70, 0);
                    M44.SetActive(true);
                    M44.transform.localPosition = new Vector3(-112, -70, 0);
                }
                ///------------------///
                if (GC.resultado[4] == "C")
                {
                    C5.SetActive(true);
                    C5.transform.localPosition = new Vector3(-112, -178, 0);
                    M55.SetActive(false);
                    M5.SetActive(false);
                }
                if (GC.resultado[4] == "M")
                {
                    M5.SetActive(true);
                    M5.transform.localPosition = new Vector3(-112, -178, 0);
                    M55.SetActive(false);
                    C5.SetActive(false);
                }
                else if (GC.resultado[4] == "MM")
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
