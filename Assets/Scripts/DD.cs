using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DD : MonoBehaviour,  IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform m_RectTransform;
    private CanvasGroup m_CanvasGroup;
    public int x_position;
    public TMP_Text applecount;
    public TMP_Text meloncount;
    public TMP_Text orangecount;
    public TMP_Text guavacount;

    //Awake is called when the script instance is being loaded
    void Awake()
    {
        m_RectTransform = GetComponent<RectTransform>();
        m_CanvasGroup = GetComponent<CanvasGroup>(); 
    }
    //This method is called when the gameobject drag is started
    public void OnBeginDrag(PointerEventData eventData)
    {
            m_CanvasGroup.blocksRaycasts = false;
    }
    //This method is called when the gameobject is being dragged
    public void OnDrag(PointerEventData eventData)
    {
        m_RectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    //This method is called when the game object is dropped
    public void OnEndDrag(PointerEventData eventData)
    {
        StartCoroutine(SceneLoader());
        m_CanvasGroup.blocksRaycasts = true;   
    }
    IEnumerator SceneLoader()
    {
        yield return new WaitForSeconds(3.5f);
        gameObject.SetActive(false);
        if (gameObject.name == "guava")
        {
            guavacount.text = (clickControll.guavabingoinc - 1).ToString();
        }
        else if (gameObject.name == "apple")
        {
            applecount.text = (clickControll.applebingoinc - 1).ToString();
        }
        else if (gameObject.name == "orange")
        {
            orangecount.text = (clickControll.orangebingoinc - 1).ToString();
        }
        else if (gameObject.name == "watermelon")
        {
            meloncount.text = (clickControll.melonbingoinc - 1).ToString();
        }
    }
}
