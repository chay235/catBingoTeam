using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class clickControll : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update

    public TMP_Text num1text;
    public int index;
    public TMP_Text operand1text;
    public TMP_Text operand2text;
    public Button button;
    public Image image;
    public Image bingo_image;
    public static int r1 = 0;
    public static int r2 = 0;
    public static int r3 = 0;
    public static int r4 = 0;
    public static int r5 = 0;
    public static int c1 = 0;
    public static int c2 = 0;
    public static int c3 = 0;
    public static int c4 = 0;
    public static int c5 = 0;
    public static int d1 = 0;
    public static int d2 = 0;
    public static bool over = false;
    public static bool over1 = false;
    public static bool over2 = false;
    public static bool over3 = false;
    public static int applebingoinc = 0;
    public static int melonbingoinc = 0;
    public static int guavabingoinc = 0;
    public static int orangebingoinc = 0;
	public static int score = 0;
    int E_Min = 0;
    int E_Max = 30;
    int Mid_Min = 31;
    int Mid_Max = 99;
    int Hard_Min = 100;
    int Hard_Max = 999;
    public TMP_Text hint1;
    public TMP_Text hint2;
    public TMP_Text hint3;
    public static int[] shuffleArr = new int[3];
    public static bool h1 = true;
    public static bool h2 = true;
    public static bool h3 = true;
    public static bool h4 = true;
    public static bool h5 = true;
    public static bool v1 = true;
    public static bool v2 = true;
    public static bool v3 = true;
    public static bool v4 = true;
    public static bool v5 = true;
    public static bool dia1 = true;
    public static bool dia2 = true;
    public GameObject operand1;
    public GameObject operand2;
    public GameObject operator1;
    public GameObject hint;
    public GameObject exit;
    public GameObject congratulations;
    public GameObject nomoremoves;
    


    void Start()
    {
        //Debug.Log("cc"+index);
        num1text.text = GMScript.test[index].ToString();
        image.enabled = false;
    }
   

    public void OnPointerClick(PointerEventData eventData)
    {
        int temp = 0;
        temp = GMScript.operator1[GMScript.index + 1] - GMScript.operator2[GMScript.index + 1];
        // ans1.text = temp.ToString();
        for(int i=0; i<2; i++){
            if (GMScript.level_parameter == 1)
            {
                int range1 = UnityEngine.Random.Range(E_Min, E_Max);
                shuffleArr[i] = range1;
            }
            else if (GMScript.level_parameter == 2)
            {
                int range2 = UnityEngine.Random.Range(Mid_Min, Mid_Max); 
                shuffleArr[i] = range2;
            }
            else if(GMScript.level_parameter == 3)
            {
                int range3 = UnityEngine.Random.Range(Hard_Min, Hard_Max); 
                shuffleArr[i] = range3;
            }
        }
        shuffleArr[2] = temp;
        System.Random rnd = new System.Random();
        shuffleArr = shuffleArr.OrderBy(x => rnd.Next()).ToArray();
        hint1.text = shuffleArr[0].ToString();
        hint2.text = shuffleArr[1].ToString();
        hint3.text = shuffleArr[2].ToString();  

        int currquesint = GMScript.index;
        int o1 = GMScript.operator1[currquesint];
        int o2 = GMScript.operator2[currquesint];

        //Debug.Log("in click control");
        if(o2==0 || o2==1){
            GMScript.questions_types_total[0] += 1;
            if(GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[0] += 1;
            }
        }
        if (o1 == o2 * 2 && o1<10)
        {
            GMScript.questions_types_total[1] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[1] += 1;
            }
        }
        if(o1 == o2 * 2 && o1 >= 10 && o1 <= 99)
        {
            GMScript.questions_types_total[2] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[2] += 1;
            }
        }
        if (o1 == 10)
        {
            GMScript.questions_types_total[3] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[3] += 1;
            }
        }
        if(o1>=10 && o1<=20 && o2 == 10)
        {
            GMScript.questions_types_total[4] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[4] += 1;
            }
        }
        if (o1 == o2 * 2 + 1)
        {
            GMScript.questions_types_total[5] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[5] += 1;
            }
        }
        if(o1==9 || o1 == 11)
        {
            GMScript.questions_types_total[6] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[6] += 1;
            }
        }
        if (o1 == o2 - 2)
        {
            GMScript.questions_types_total[7] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[7] += 1;
            }
        }
        if(o2==2)
        {
            GMScript.questions_types_total[8] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[8] += 1;
            }
        }
        if (o2 == 10)
        {
            GMScript.questions_types_total[9] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[9] += 1;
            }
        }
        if (o1<20)
        {
            GMScript.questions_types_total[10] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[10] += 1;
            }
        }
        if(o1>=20 && o1 <= 30)
        {
            GMScript.questions_types_total[11] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[11] += 1;
            }
        }
        if (o1 > 30 && o1 <= 50)
        {
            GMScript.questions_types_total[13] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[13] += 1;
            }
        }
        if (o1 > 50 && o1 <= 100)
        {
            GMScript.questions_types_total[14] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[12] += 1;
            }
        }
        if (o2 >= 10 && o2 <= 99)
        {
            GMScript.questions_types_total[14] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[13] += 1;
            }
        }
        if (o1 >= 100 && o2 >= 10 && o2 <= 99)
        {
            GMScript.questions_types_total[15] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[15] += 1;
            }
        }
        if(o1>=100 && o2 >= 100)
        {
            GMScript.questions_types_total[16] += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                GMScript.answers_types_total[16] += 1;
            }
        }


        if (GMScript.test[index] == o1-o2)
        {

            //Debug.Log("correct ans");
            //button.GetComponent<Image>().sprite= image;
            image.enabled = true;
            score = score + 1;
            //num1text.text = "";
            //GMScript.result[GMScript.Indarray[GMScript.index]] = 1;
            GMScript.result[GMScript.index] = 1;
            //button.GetComponent<Button>().interactable = false;

            if(index!=0 & index!=24 & index % 4 == 0)
            {
                d1 += 1;
                if (d1 == 5)
                {
                    applebingoresponse();
                }
            }
            if (index % 6 == 0)
            {
                d2 += 1;
                if (d2 == 5)
                {
                    orangebingoresponse();
                }
            }

            switch (index % 5){
                case 0:
                    c1 += 1;
                    //Debug.Log("C count:-----------"+c1);
                    if (c1 == 5)
                    {
                        guavabingoresponse();
                    }
                    break;
                case 1:
                    //Debug.Log("C count:-----------" + c2);
                    c2 += 1;
                    if (c2 == 5)
                    {
                        guavabingoresponse();
                    }
                    break;
                case 2:
                    //Debug.Log("C count:-----------" + c3);
                    c3 += 1;
                    if (c3 == 5)
                    {
                        guavabingoresponse();
                    }
                    break;
                case 3:
                    c4 += 1;
                    if (c4 == 5)
                    {
                        guavabingoresponse();
                    }
                    break;
                case 4:
                    c5 += 1;
                    if (c5 == 5)
                    {
                        guavabingoresponse();
                    }
                    break;
                default:
                    break;
            }
            switch (index/5)
            {
                case 0:
                    r1 += 1;
                    //Debug.Log("R count:-----------" + r1);
                    if (r1 == 5)
                    {
                        melonbingoresponse();
                    }
                    break;
                case 1:
                    //Debug.Log("R count:-----------" + r2);
                    r2 += 1;
                    if (r2 == 5)
                    {
                        melonbingoresponse();
                    }
                    break;
                case 2:
                    r3 += 1;
                    if (r3 == 5)
                    {
                        melonbingoresponse();
                    }
                    break;
                case 3:
                    r4 += 1;
                    if (r4 == 5)
                    {
                        melonbingoresponse();
                    }
                    break;
                case 4:
                    r5 += 1;
                    if (r5 == 5)
                    {
                        melonbingoresponse();
                    }
                    break;
                default:
                    break;
            }
        }
        else
        {
            if (index - 1 == 0)
            {
                if (h1 == true)
                {
                    h1 = false;
                }
                if (v1 == true)
                {
                    v1 = false;
                }
                if (dia1 == true)
                {
                    dia1 = false;
                }
            }
            else if (index - 1 == 1)
            {
                if (h1 == true)
                {
                    h1 = false;
                }
                if (v2 == true)
                {
                    v2 = false;
                }
            }
            else if (index - 1 == 2)
            {
                if (h1 == true)
                {
                    h1 = false;
                }
                if (v3 == true)
                {
                    v3 = false;
                }
            }
            else if (index - 1 == 3)
            {
                if (h1 == true)
                {
                    h1 = false;
                }
                if (v4 == true)
                {
                    v4 = false;
                }
            }
            else if (index - 1 == 4)
            {
                if (h1 == true)
                {
                    h1 = false;
                }
                if (v5 == true)
                {
                    v5 = false;
                }
                if (dia2 == true)
                {
                    dia2 = false;
                }
            }
            else if (index - 1 == 5)
            {
                if (h2 == true)
                {
                    h2 = false;
                }
                if (v1 == true)
                {
                    v1 = false;
                }
            }
            else if (index - 1 == 6)
            {
                if (h2 == true)
                {
                    h2 = false;
                }
                if (v2 == true)
                {
                    v2 = false;
                }
                if (dia1 == true)
                {
                    dia1 = false;
                }
            }
            else if (index - 1 == 7)
            {
                if (h2 == true)
                {
                    h2 = false;
                }
                if (v3 == true)
                {
                    v3 = false;
                }
            }
            else if (index - 1 == 8)
            {
                if (h2 == true)
                {
                    h2 = false;
                }
                if (v4 == true)
                {
                    v4 = false;
                }
                if (dia2 == true)
                {
                    dia2 = false;
                }
            }
            else if (index - 1 == 9)
            {
                if (h2 == true)
                {
                    h2 = false;
                }
                if (v5 == true)
                {
                    v5 = false;
                }
            }
            else if (index - 1 == 10)
            {
                if (h3 == true)
                {
                    h3 = false;
                }
                if (v1 == true)
                {
                    v1 = false;
                }
            }
            else if (index - 1 == 11)
            {
                if (h3 == true)
                {
                    h3 = false;
                }
                if (v2 == true)
                {
                    v2 = false;
                }
            }
            else if (index - 1 == 12)
            {
                if (h3 == true)
                {
                    h3 = false;
                }
                if (v3 == true)
                {
                    v3 = false;
                }
                if (dia1 == true)
                {
                    dia1 = false;
                }
                if (dia2 == true)
                {
                    dia2 = false;
                }
            }
            else if (index - 1 == 13)
            {
                if (h3 == true)
                {
                    h3 = false;
                }
                if (v4 == true)
                {
                    v4 = false;
                }
            }
            else if (index - 1 == 14)
            {
                if (h3 == true)
                {
                    h3 = false;
                }
                if (v5 == true)
                {
                    v5 = false;
                }
            }
            else if (index - 1 == 15)
            {
                if (h4 == true)
                {
                    h4 = false;
                }
                if (v1 == true)
                {
                    v1 = false;
                }
            }
            else if (index - 1 == 16)
            {
                if (h4 == true)
                {
                    h4 = false;
                }
                if (v2 == true)
                {
                    v2 = false;
                }
                if (dia2 == true)
                {
                    dia2 = false;
                }
            }
            else if (index - 1 == 17)
            {
                if (h4 == true)
                {
                    h4 = false;
                }
                if (v3 == true)
                {
                    v3 = false;
                }
            }
            else if (index - 1 == 18)
            {
                if (h4 == true)
                {
                    h4 = false;
                }
                if (v4 == true)
                {
                    v4 = false;
                }
                if (dia1 == true)
                {
                    dia1 = false;
                }
            }
            else if (index - 1 == 19)
            {
                if (h4 == true)
                {
                    h4 = false;
                }
                if (v5 == true)
                {
                    v5 = false;
                }
            }
            else if (index - 1 == 20)
            {
                if (h5 == true)
                {
                    h5 = false;
                }
                if (v1 == true)
                {
                    v1 = false;
                }
                if (dia2 == true)
                {
                    dia2 = false;
                }
            }
            else if (index - 1 == 21)
            {
                if (h5 == true)
                {
                    h5 = false;
                }
                if (v2 == true)
                {
                    v2 = false;
                }
            }
            else if (index - 1 == 22)
            {
                if (h5 == true)
                {
                    h5 = false;
                }
                if (v3 == true)
                {
                    v3 = false;
                }
            }
            else if (index - 1 == 23)
            {
                if (h5 == true)
                {
                    h5 = false;
                }
                if (v4 == true)
                {
                    v4 = false;
                }
            }
            else if (index - 1 == 24)
            {
                if (h5 == true)
                {
                    h5 = false;
                }
                if (v5 == true)
                {
                    v5 = false;
                }
                if (dia1 == true)
                {
                    dia1 = false;
                }
            }
                //button.GetComponent<Button>().interactable = false;
                //GMScript.result[GMScript.Indarray[GMScript.index]] =2;
                int currnum = GMScript.test[index];
            for (int i = 0;i< 24; i++)
            {
                if ((GMScript.operator1[i] - GMScript.operator2[i])==currnum && GMScript.result[i] == 0)
                {
                    GMScript.result[i] = 2;
                    break;
                }
            }
            Debug.Log("null answer index"+GMScript.Indarray[index]);
            button.gameObject.SetActive(false);

            //Debug.Log("incorrect ans");
        }
        Bingo();
        Debug.Log("index"+index);

        int currind = GMScript.index;
        while (currind < 24)
        {
            string[] res = Array.ConvertAll(GMScript.result, x => x.ToString());
            Debug.Log(String.Join(",",res));
            if (GMScript.result[currind + 1] == 2)
            {
                Debug.Log("null question index" + currind);
                currind++;
                
            }
            else
            {

                GMScript.index = currind + 1;
                operand1text.text = GMScript.operator1[currind + 1].ToString();
                operand2text.text = GMScript.operator2[currind + 1].ToString();
                break;
            }
        }
        
        //GMScript.index = currquesint+1;
        //if (currquesint < 24) {
        //    operand1text.text = GMScript.operator1[currquesint+1].ToString();
        //    operand2text.text = GMScript.operator2[currquesint+1].ToString();
        //}
        //Debug.Log("button number" + index + " clicked");
    }
    //public void buttontesting()
    //{
    //    Debug.Log("button"+index+"clicked!");
    //}
    public void Bingo()
    {
        if (h1 == false && h2 == false && h3 == false && h4 == false && h5 == false && v1 == false && v2 == false && v3 == false
            && v4 == false && v5 == false && dia1 == false && dia2 == false)
        {
            operand1.SetActive(false);
            operand2.SetActive(false);
            operator1.SetActive(false);
            hint.SetActive(false);
            nomoremoves.SetActive(true);
            exit.SetActive(true);

            //string bingoOrNot = "NOT BINGO";
            //StartCoroutine(SceneLoader(bingoOrNot));
        }
    }
    IEnumerator SceneLoader(string bingoOrNot)
    {
        if (bingoOrNot == "BINGO")
        {
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("LevelScreen");
        }
    }
        public void applebingoresponse()
    {
        //Debug.Log("Bingo");
        bingo_image.enabled = true;
        over = true;
        applebingoinc = applebingoinc + 1;
        operand1.SetActive(false);
        operand2.SetActive(false);
        operator1.SetActive(false);
        hint.SetActive(false);
        congratulations.SetActive(true);
        string bingoOrNot = "BINGO";
        StartCoroutine(SceneLoader(bingoOrNot));
    }
    public void guavabingoresponse()
    {
        //Debug.Log("Bingo");
        bingo_image.enabled = true;
        over1 = true;
        guavabingoinc = guavabingoinc + 1;
        operand1.SetActive(false);
        operand2.SetActive(false);
        operator1.SetActive(false);
        hint.SetActive(false);
        congratulations.SetActive(true);
        string bingoOrNot = "BINGO";
        StartCoroutine(SceneLoader(bingoOrNot));
    }

    public void melonbingoresponse()
    {
        //Debug.Log("Bingo");
        bingo_image.enabled = true;
        over2 = true;
        melonbingoinc = melonbingoinc + 1;
        operand1.SetActive(false);
        operand2.SetActive(false);
        operator1.SetActive(false);
        hint.SetActive(false);
        congratulations.SetActive(true);
        string bingoOrNot = "BINGO";
        StartCoroutine(SceneLoader(bingoOrNot));
    }

    public void orangebingoresponse()
    {
        //Debug.Log("Bingo");
        bingo_image.enabled = true;
        over3 = true;
        orangebingoinc = orangebingoinc + 1;
        operand1.SetActive(false);
        operand2.SetActive(false);
        operator1.SetActive(false);
        hint.SetActive(false);
        congratulations.SetActive(true);
        string bingoOrNot = "BINGO";
        StartCoroutine(SceneLoader(bingoOrNot));
    }


}
