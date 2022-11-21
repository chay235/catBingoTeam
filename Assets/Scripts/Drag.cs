using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Drag : MonoBehaviour
{
    [SerializeField]

    private Canvas canvas;
    public GameObject apple;
    public GameObject orange;
    public GameObject watermelon;
    public GameObject guava;
<<<<<<< Updated upstream
=======
    public float appleX;
    public float appleY;
    public float orangeX;
    public float orangeY;
    public float melonX;
    public float melonY;
    public float guavaX;
    public float guavaY;


>>>>>>> Stashed changes

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
    

        float appleX = (GameObject.Find("apple").transform.position.x);
        float appleY = (GameObject.Find("apple").transform.position.y);

        float orangeX = (GameObject.Find("orange").transform.position.x);
        float orangeY = (GameObject.Find("orange").transform.position.y);

        float melonX= (GameObject.Find("watermelon").transform.position.x);
        float melonY = (GameObject.Find("watermelon").transform.position.y);

        float guavaX = (GameObject.Find("guava").transform.position.x);
        float guavaY = (GameObject.Find("guava").transform.position.y);




        float catXmin = (GameObject.Find("Cateating").transform.position.x);
        float catYmin = (GameObject.Find("Cateating").transform.position.y);
        float catXmax = catXmin + 50;
        catYmin = catYmin + 50;
        float catYmax = catYmin - 100; 
        Debug.Log(transform.position);
        if (orangeX > catXmin && orangeX < catXmax && orangeY < catYmin && orangeY > catYmax)
        {
            orange.SetActive(false);

            //Fruitinc.applecount = (clickControll.applebingoinc - 1).ToString();
            Debug.Log("hello eat");

           // fruit.SetActive(true);

        }
        else if (appleX > catXmin && appleX < catXmax && appleY < catYmin && appleY > catYmax)
        {
            apple.SetActive(false);

<<<<<<< Updated upstream
          //  Fruitinc.applecount = (clickControll.applebingoinc - 1).ToString();
=======
            //Fruitinc.applecount = (clickControll.applebingoinc - 1).ToString();
>>>>>>> Stashed changes
            Debug.Log("hello eat");

            // fruit.SetActive(true);

        }
        else if (melonX > catXmin && melonX < catXmax && melonY < catYmin && melonY > catYmax)
        {
            watermelon.SetActive(false);

            //Fruitinc.applecount = (clickControll.applebingoinc - 1).ToString();
            Debug.Log("hello eat");

            // fruit.SetActive(true);

        }
        else if (guavaX > catXmin && guavaX < catXmax && guavaY < catYmin && guavaY > catYmax)
        {
            guava.SetActive(false);

            //Fruitinc.applecount = (clickControll.applebingoinc - 1).ToString();
            Debug.Log("hello eat");

            // fruit.SetActive(true);

        }
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