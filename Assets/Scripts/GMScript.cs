using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GMScript : MonoBehaviour
{
    int E_MinL1 = 0;
    int E_MaxL1 = 10;
    int E_MinL2 = 11;
    int E_MaxL2 = 20;
    int E_MinL3 = 21;
    int E_MaxL3 = 30;

    int Mid_Min = 31;
    int Mid_Max = 99;
    int Hard_Min = 100;
    int Hard_Max = 999;
    public static int level_parameter;
    public static int index = 0;
    public static int[] test = new int[25];
    public static int[] tempans = new int[25];
    public static int[] Indarray= new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24};
    public static int[] operator1 = new int[25];
    public static int[] operator2 = new int[25];
    public static int[] result=new int[25];
    public static int[] questions_types_total = new int[17];
    public static int[] answers_types_total = new int[17];
    public TMP_Text operator1_handler;
    public TMP_Text operand1_handler;
    public TMP_Text operand2_handler;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("gm");
        Debug.Log("level_parameter:"+level_parameter);
        System.Random random = new System.Random();
        for (int i = 0; i < 25; i++)
        {
            if (level_parameter == 1)
            {
                if(clickControll.score < 10){
                operator1[i] = UnityEngine.Random.Range(E_MinL1, E_MaxL1);
                operator2[i] = UnityEngine.Random.Range(E_MinL1, operator1[i]);
                }
                else if(clickControll.score > 10 && clickControll.score < 20)
                {
                    operator1[i] = UnityEngine.Random.Range(E_MinL2, E_MaxL2);
                    operator2[i] = UnityEngine.Random.Range(E_MinL2, operator1[i]);
                }
                else{
                    operator1[i] = UnityEngine.Random.Range(E_MinL3, E_MaxL3);
                    operator2[i] = UnityEngine.Random.Range(E_MinL3, operator1[i]);
                }

            }
            else if (level_parameter == 2)
            {
                operator1[i] = UnityEngine.Random.Range(Mid_Min, Mid_Max);
                operator2[i] = UnityEngine.Random.Range(Mid_Min, operator1[i]);
            }
            else if (level_parameter == 3)
            {
                operator1[i] = UnityEngine.Random.Range(Hard_Min, Hard_Max);
                operator2[i] = UnityEngine.Random.Range(Hard_Min, operator1[i]);
                

            }
            tempans[i] = operator1[i] - operator2[i];
            
            
        }

        System.Random rnd = new System.Random();
        Indarray = Indarray.OrderBy(x => rnd.Next()).ToArray();

        for(int i = 0; i < 25; i++)
        {
            test[i] = tempans[Indarray[i]];
        }

        String[] o1 = Array.ConvertAll(operator1, x => x.ToString());
        String[] o2 = Array.ConvertAll(operator2, x => x.ToString());
        String[] o3 = Array.ConvertAll(tempans, x => x.ToString());
        String[] o4 = Array.ConvertAll(Indarray, x => x.ToString());

        String[] t = Array.ConvertAll(test, x => x.ToString());
        
        Debug.Log(String.Join(",", o1));
        Debug.Log(String.Join(",", o2));
        Debug.Log("answer in order" + String.Join(",", o3));
        Debug.Log("array index" + String.Join(",", o4));
        Debug.Log("answers showed" + String.Join(",", t));
        
        

        image.enabled = false;
    }
}
