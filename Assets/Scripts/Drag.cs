using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Drag : MonoBehaviour
{
    [SerializeField]

    private Canvas canvas;
    public GameObject apple;
    public GameObject orange;
    public GameObject watermelon;
    public GameObject guava;

    public GameObject appleaxis;
    public GameObject orangeaxis;
    public GameObject melonaxis;
    public GameObject guavaaxis;

    public TMP_Text applecount;
    public TMP_Text meloncount;
    public TMP_Text orangecount;
    public TMP_Text guavacount;


    public void Start()
    {
       // startingObject = GameObject.Find("Starting"); //Find it here, or drag it into the hierarchy

        appleaxis = GameObject.Find("apple");
        melonaxis = GameObject.Find("watermelon");
        guavaaxis = GameObject.Find("guava");
        orangeaxis = GameObject.Find("orange");

    }

public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform,
             pointerData.position,
            canvas.worldCamera,
            out position);

        transform.position = canvas.transform.TransformPoint(position);

        Debug.Log("test1");
        //appleaxis = GameObject.Find("apple");
        float appleX = appleaxis.transform.position.x;
        float appleY = appleaxis.transform.position.y;
        //float appleY = (GameObject.Find("apple").transform.position.y);
        Debug.Log("test2");
        //orangeaxis = GameObject.Find("orange");
      //  float orangeX = (GameObject.Find("orange").transform.position.x);
      //  float orangeY = (GameObject.Find("orange").transform.position.y);
        float orangeX = orangeaxis.transform.position.x;
        float orangeY = orangeaxis.transform.position.y;
        Debug.Log("test3");
      //  float melonX = (GameObject.Find("watermelon").transform.position.x);
      //  float melonY = (GameObject.Find("watermelon").transform.position.y);

        float melonX = melonaxis.transform.position.x;
        float melonY = melonaxis.transform.position.y;

        Debug.Log("test4");
      //  float guavaX = (GameObject.Find("guava").transform.position.x);
      //  float guavaY = (GameObject.Find("guava").transform.position.y);

        float guavaX = guavaaxis.transform.position.x;
        float guavaY = guavaaxis.transform.position.y;


        float catXmin = (GameObject.Find("Cateating").transform.position.x);
        float catYmin = (GameObject.Find("Cateating").transform.position.y);
        float catXmax = catXmin + 100;
        catYmin = catYmin + 100;
        float catYmax = catYmin - 100; 
        Debug.Log(transform.position);
        //if (clickControll.orangebingoinc == 0)
        //{

        if (orangeX > catXmin && orangeX < catXmax && orangeY < catYmin && orangeY > catYmax)
            {
               
            orange.SetActive(false);
            //Fruitinc.orangecount = (clickControll.orangebingoinc - 1).ToString();
            
            orangecount.text  = (clickControll.orangebingoinc - 1).ToString();
                
                //Debug.Log("hello ea apple"+ orangecountval);

            // fruit.SetActive(true);

        }
         //}
          //  if (clickControll.applebingoinc != 0)
        //{
            if (appleX > catXmin && appleX < catXmax && appleY < catYmin && appleY > catYmax)
            {
                apple.SetActive(false);
                //  int y = clickControll.applebingoinc - 1;
                applecount.text = (clickControll.applebingoinc - 1).ToString();
                //Fruitinc.acount = (clickControll.applebingoinc - 1);
                Debug.Log("hello eat");


                // fruit.SetActive(true);

            }
        //}
        //if (clickControll.melonbingoinc != 0)
        //{
           

            if (melonX > catXmin && melonX < catXmax && melonY < catYmin && melonY > catYmax)
            {
                watermelon.SetActive(false);
                //int z = clickControll.melonbingoinc - 1;


                meloncount.text = (clickControll.melonbingoinc - 1).ToString();
                Debug.Log("hello eat");

                // fruit.SetActive(true);

            }
       // }
        //if (clickControll.guavabingoinc != 0)
        //{
            if (guavaX > catXmin && guavaX < catXmax && guavaY < catYmin && guavaY > catYmax)
            {
                guava.SetActive(false);
                //int s = clickControll.guavabingoinc - 1;

               guavacount.text = (clickControll.guavabingoinc - 1).ToString();
                Debug.Log("hello eat");

                // fruit.SetActive(true);

            }
       // }

    }
}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Drag : MonoBehaviour
{
    [SerializeField]

    private Canvas canvas;
    public GameObject fruit;

    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform,
             pointerData.position,
            canvas.worldCamera,
            out position);

        transform.position = canvas.transform.TransformPoint(position);
        float catXmin = (GameObject.Find("Cateating").transform.position.x);
        float catYmin = (GameObject.Find("Cateating").transform.position.y);
        float catXmax = catXmin + 50;
        catYmin = catYmin + 50;
        float catYmax = catYmin - 100;
        // Debug.Log(catXmin, catXmax, catYmin, catYmax);
        Debug.Log(transform.position);
        if (transform.position.x > catXmin && transform.position.x < catXmax && transform.position.y < catYmin && transform.position.y > catYmax)
        {
            fruit.SetActive(false);
        }
    }
}*/