using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class Report_score_script : MonoBehaviour
{
    public int category;
    public TMP_Text report_text;
    public TMP_Text progress;
    public static bool reset_parameter = false;
    public int c = 0;
    public GameObject whiteCircle;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("in report_score_script"+category);
        int total_questions = GMScript.questions_types_total[category];
        int total_answers = GMScript.answers_types_total[category];
        if (total_questions > 0)
        {
            report_text.text = "Answered correctly " + total_answers + " out of " + total_questions + " times.";
            progress.text = (total_answers*100 / total_questions).ToString() + "%";
            int progressint = total_answers * 100 / total_questions;

            
            if (progressint > 90)
            {
                whiteCircle.GetComponent<Image>().color = new Color32(153, 255, 0, 255); 
            }
            else if (progressint > 70 && progressint <= 90)
            {
                whiteCircle.GetComponent<Image>().color = new Color32(0, 191, 255, 255);
            }
            else if (progressint > 50 && progressint <= 70)
            {
                whiteCircle.GetComponent<Image>().color = new Color32(191, 80, 14, 255);
            }
            else
            {
                whiteCircle.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            }
            progress.color = new Color(0, 0, 0, 255);
        }
        else
        {
            report_text.text = "Keep on learning! Check back to see your child's progress.";
            progress.text = "";
            whiteCircle.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        }
        

    }

    void Update()
    {
        //Debug.Log(c);
        if (reset_parameter == true)
        {
            Debug.Log("in update method!");
            report_text.text = "Keep on learning! Check back to see your child's progress.";
            progress.text = "";
        }
    }

    //public void reset_report_scores()
    //{
    //    Debug.Log("in reset method!");
    //    reset_parameter = true;
    //}


}
