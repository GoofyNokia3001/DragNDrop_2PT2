using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragEnd : MonoBehaviour, IDropHandler{
	private float placeZRotat, dragObjZRotat, rotationDiff;
	private Vector2 placeSize, dragObjSize;
	private float xSizeDiff, ySizeDiff;
	public Objects ObjectScript;

	

    public void OnDrop(PointerEventData eventData)
    {
		if (eventData.pointerDrag != null) {
			
			if (eventData.pointerDrag.tag.Equals(tag)) {
				placeZRotat = GetComponent<RectTransform>().transform.eulerAngles.z;
				dragObjZRotat = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
				rotationDiff = Mathf.Abs(dragObjZRotat-placeZRotat);
                dragObjSize = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
				placeSize = GetComponent<RectTransform>().localScale;
				xSizeDiff = Mathf.Abs(dragObjSize.x - placeSize.x);
                ySizeDiff = Mathf.Abs(dragObjSize.y - placeSize.y);

				if ((rotationDiff <= 6 || (rotationDiff >= 354 && rotationDiff <= 360))
					&& (xSizeDiff <= 0.1 && ySizeDiff <= 0.1)) 
				{
					ObjectScript.RightPlace = true;

					eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
					
					eventData.pointerDrag.GetComponent<RectTransform>().localScale= GetComponent<RectTransform>().localScale;

					switch (eventData.pointerDrag.tag) 
					{
						case "garbage":
							ObjectScript.audioSource.PlayOneShot(ObjectScript.AudioToPlay[0]);
							break;

                        case "ambulance":
                            ObjectScript.audioSource.PlayOneShot(ObjectScript.AudioToPlay[1]);
                            break;

                        case "bus":
                            ObjectScript.audioSource.PlayOneShot(ObjectScript.AudioToPlay[2]);
                            break;

                    }
				}
            } else {
				ObjectScript.RightPlace = false;
				ObjectScript.audioSource.PlayOneShot(ObjectScript.AudioToPlay[3]);
                switch (eventData.pointerDrag.tag)
                {
                    case "garbage":
						ObjectScript.GarbageCar.GetComponent<RectTransform>().localPosition = ObjectScript.GarbCCOORD;
                        break;

                    case "ambulance":
                        ObjectScript.AmbulanceCar.GetComponent<RectTransform>().localPosition = ObjectScript.AmbulCCOORD;
                        break;

                    case "bus":
                        ObjectScript.BusCar.GetComponent<RectTransform>().localPosition = ObjectScript.BusCCOORD;
                        break;

                }
            }
		}
    }

   
}
