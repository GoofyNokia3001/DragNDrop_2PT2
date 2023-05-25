using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop : MonoBehaviour,
    IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public Objects ObjectScript;
    private CanvasGroup canvasGroup;
    private RectTransform dragObjRectTransform;
    public void OnBeginDrag(PointerEventData eventData)
    {
        ObjectScript.LastDrag = null;
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts= false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        dragObjRectTransform.anchoredPosition += eventData.delta / ObjectScript.canva.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        ObjectScript.LastDrag = eventData.pointerDrag;
        canvasGroup.alpha = 1f;
        if (ObjectScript.RightPlace == false)
        { canvasGroup.blocksRaycasts = true; }
        else { ObjectScript.LastDrag = null; }
        ObjectScript.RightPlace = false;
    }

    // Use this for initialization
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        dragObjRectTransform = GetComponent<RectTransform>();
    }

}
