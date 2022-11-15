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
    int E_Min = 0;
    int E_Max = 30;
    int Mid_Min = 31;
    int Mid_Max = 99;
    int Hard_Min = 100;
    int Hard_Max = 999;
    public static int level_parameter;
    public static int index = 0;
    public static int row1 = 0;
    public static int row2 = 0;
    public static int row3 = 0;
    public static int row4 = 0;
    public static int row5 = 0;
    public static int col1 = 0;
    public static int col2 = 0;
    public static int col3 = 0;
    public static int col4 = 0;
    public static int col5 = 0;
    public static int diag1 = 0;
    public static int diag2 = 0;
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
        index = 0;
        row1 = 0;
        row2 = 0;
        row3 = 0;
        row4 = 0;
        row5 = 0;
        col1 = 0;
        col2 = 0;
        col3 = 0;
        col4 = 0;
        col5 = 0;
        diag1 = 0;
        diag2 = 0;
        Debug.Log("gm");
        Debug.Log("level_parameter:"+level_parameter);
        System.Random random = new System.Random();
        for (int i = 0; i < 25; i++)
        {
            if (level_parameter == 1)
            {
                operator1[i] = UnityEngine.Random.Range(E_Min, E_Max);
                operator2[i] = UnityEngine.Random.Range(E_Min, operator1[i]);
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
