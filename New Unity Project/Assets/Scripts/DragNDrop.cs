using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

    public Object ObjectScript;
    private CanvasGroup canvasGroup;
    private RectTransform dragObjRectTransform;
    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       
    }

    // Use this for initialization
    void Start () {
		canvasGroup= GetComponent<CanvasGroup>();
        dragObjRectTransform= GetComponent<RectTransform>();
	}
	
}
