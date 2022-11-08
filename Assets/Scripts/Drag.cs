using System.Collections;
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
        Debug.Log(transform.position);
        if (transform.position.x > catXmin && transform.position.x < catXmax && transform.position.y < catYmin && transform.position.y > catYmax)
        {
            fruit.SetActive(false);
        }
    }
}