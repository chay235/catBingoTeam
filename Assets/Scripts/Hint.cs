using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Hint : MonoBehaviour
{
    
    // public static int level_parameter;
    // Start is called before the first frame update

    int E_Min = 0;
    int E_Max = 30;
    int Mid_Min = 31;
    int Mid_Max = 99;
    int Hard_Min = 100;
    int Hard_Max = 999;
    public TMP_Text operand1text;
    public TMP_Text operand2text;
    public TMP_Text hint1;
    public TMP_Text hint2;
    public TMP_Text hint3;
    public static int[] shuffleArr = new int[3];

    void Start()
    { 
        int temp = 0;
        temp = Int32.Parse(operand1text.text) - Int32.Parse(operand2text.text);
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
    }

    void Update(){
        
    }
}
