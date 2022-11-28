using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;

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

    void Start()
    {
        //Debug.Log("cc"+index);
        num1text.text = GMScript.test[index].ToString();
        image.enabled = false;
    }
   

    public void OnPointerClick(PointerEventData eventData)
    {
        int currquesint = GMScript.index;
        int o1 = GMScript.operator1[currquesint];
        int o2 = GMScript.operator2[currquesint];

        //Debug.Log("in click control");
        if(o2==0 || o2==1){
            Game_state.Qcategory1 += 1;
            if(GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory1 += 1;
            }
        }
        if (o1 == o2 * 2 && o1<10)
        {
            Game_state.Qcategory2 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory2 += 1;
            }
        }
        if(o1 == o2 * 2 && o1 >= 10 && o1 <= 99)
        {
            Game_state.Qcategory3 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory3 += 1;
            }
        }
        if (o1 == 10)
        {
            Game_state.Qcategory4 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory4 += 1;
            }
        }
        if(o1>=10 && o1<=20 && o2 == 10)
        {
            Game_state.Qcategory5 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory5 += 1;
            }
        }
        if (o1 == o2 * 2 + 1)
        {
            Game_state.Qcategory6 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory6 += 1;
            }
        }
        if(o1==9 || o1 == 11)
        {
            Game_state.Qcategory7 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory7 += 1;
            }
        }
        if (o1 == o2 - 2)
        {
            Game_state.Qcategory8 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory8 += 1;
            }
        }
        if(o2==2)
        {
            Game_state.Qcategory9 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory9 += 1;
            }
        }
        if (o2 == 10)
        {
            Game_state.Qcategory10 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory10 += 1;
            }
        }
        if (o1<20)
        {
            Game_state.Qcategory11 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory11 += 1;
            }
        }
        if(o1>=20 && o1 <= 30)
        {
            Game_state.Qcategory12 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory12 += 1;
            }
        }
        if (o1 > 30 && o1 <= 50)
        {
            Game_state.Qcategory13 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory13 += 1;
            }
        }
        if (o1 > 50 && o1 <= 100)
        {
            Game_state.Qcategory14 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory14 += 1;
            }
        }
        if (o2 >= 10 && o2 <= 99)
        {
            Game_state.Qcategory15 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory15 += 1;
            }
        }
        if (o1 >= 100 && o2 >= 10 && o2 <= 99)
        {
            Game_state.Qcategory16 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory16 += 1;
            }
        }
        if(o1>=100 && o2 >= 100)
        {
            Game_state.Qcategory17 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory17 += 1;
            }
        }


        if (GMScript.test[index] == o1-o2)
        {

            //Debug.Log("correct ans");
            //button.GetComponent<Image>().sprite= image;
            image.enabled = true;
            //num1text.text = "";
            //GMScript.result[GMScript.Indarray[GMScript.index]] = 1;
            GMScript.result[GMScript.index] = 1;
            //button.GetComponent<Button>().interactable = false;
            if (GMScript.level_parameter == 1)
            {
                Game_state.EasyScore = Game_state.EasyScore + 1;
            }
            else if (GMScript.level_parameter == 2)
            {
                Game_state.MediumScore = Game_state.MediumScore + 1;
            }
            else
            {
                Game_state.HardScore = Game_state.HardScore + 1;
            }


            if (index!=0 & index!=24 & index % 4 == 0)
            {
                GMScript.diag1 += 1;
                if (GMScript.diag1 == 5)
                {
                    bingoresponse();
                }
            }
            if (index % 6 == 0)
            {
                GMScript.diag2 += 1;
                if (GMScript.diag2 == 5)
                {
                    bingoresponse();
                }
            }

            switch (index % 5){
                case 0:
                    GMScript.col1 += 1;
                    //Debug.Log("C count:-----------"+c1);
                    if (GMScript.col1 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 1:
                    //Debug.Log("C count:-----------" + c2);
                    GMScript.col2 += 1;
                    if (GMScript.col2 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 2:
                    //Debug.Log("C count:-----------" + c3);
                    GMScript.col3 += 1;
                    if (GMScript.col3 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 3:
                    GMScript.col4 += 1;
                    if (GMScript.col4 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 4:
                    GMScript.col5 += 1;
                    if (GMScript.col5 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                default:
                    break;
            }
            switch (index/5)
            {
                case 0:
                    GMScript.row1 += 1;
                    //Debug.Log("R count:-----------" + r1);
                    if (GMScript.row1 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 1:
                    //Debug.Log("R count:-----------" + r2);
                    GMScript.row2 += 1;
                    if (GMScript.row2 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 2:
                    GMScript.row3 += 1;
                    if (GMScript.row3 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 3:
                    GMScript.row4 += 1;
                    if (GMScript.row4 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                case 4:
                    GMScript.row5 += 1;
                    if (GMScript.row5 == 5)
                    {
                        bingoresponse();
                    }
                    break;
                default:
                    break;
            }
        }
        else
        {
            if (index != 0 & index != 24 & index % 4 == 0)
            {
                GMScript.wrongans[10] += 1;
            }
            if (index % 6 == 0)
            {
                GMScript.wrongans[11] += 1;
            }

            switch (index % 5)
            {
                case 0:
                    GMScript.wrongans[0] += 1;
                    break;
                case 1:
                    GMScript.wrongans[1] += 1;
                    break;
                case 2:
                    GMScript.wrongans[2] += 1;
                    break;
                case 3:
                    GMScript.wrongans[3] += 1;
                    break;
                case 4:
                    GMScript.wrongans[4] += 1;
                    break;
                default:
                    break;
            }
            switch (index / 5)
            {
                case 0:
                    GMScript.wrongans[5] += 1;
                    break;
                case 1:
                    GMScript.wrongans[6] += 1;
                    break;
                case 2:
                    GMScript.wrongans[7] += 1;
                    break;
                case 3:
                    GMScript.wrongans[8] += 1;
                    break;
                case 4:
                    GMScript.wrongans[9] += 1;
                    break;
                default:
                    break;
            }
            //button.GetComponent<Button>().interactable = false;
            //GMScript.result[GMScript.Indarray[GMScript.index]] =2;
            int wronglines = 0;
            int currnum = GMScript.test[index];
            for (int i = 0;i< 24; i++)
            {
                if (i<12 && GMScript.wrongans[i] >= 1)
                {
                    wronglines++;
                }
                if ((GMScript.operator1[i] - GMScript.operator2[i])==currnum && GMScript.result[i] == 0)
                {
                    GMScript.result[i] = 2;
                    break;
                }
            }
            if (wronglines == 12)
            {
                Debug.Log("no more moves");
            }
            Debug.Log("null answer index"+GMScript.Indarray[index]);
            button.gameObject.SetActive(false);

            //Debug.Log("incorrect ans");
        }
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
    public void bingoresponse()
    {
        //Debug.Log("Bingo");
        bingo_image.enabled = true;
    }

    
}
