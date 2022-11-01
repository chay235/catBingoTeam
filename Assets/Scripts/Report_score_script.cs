using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Report_score_script : MonoBehaviour
{
    public int category;
    public TMP_Text report_text;
    public TMP_Text progress;
    public static bool reset_parameter = false;
    public int c = 0;
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
        }
        else
        {
            report_text.text = "Keep on learning! Check back to see your child's progress.";
            progress.text = "";
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
