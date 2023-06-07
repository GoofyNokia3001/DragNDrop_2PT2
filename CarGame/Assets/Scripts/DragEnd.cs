using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragEnd : MonoBehaviour, IDropHandler{
	private float placeZRotat, dragObjZRotat, rotationDiff;
	private Vector2 placeSize, dragObjSize;
	private float xSizeDiff, ySizeDiff;
	public Objects ObjectScript;
	public GameObject panelEnd;
    private bool firstTime = true;
	public Color NoTransparent = new Color(1f, 1f, 1f, 1f);
    public Color Transparent = new Color(1f, 1f, 1f, 0f);


    void Start()
	{
        panelEnd = new GameObject();
		panelEnd = GameObject.Find("Panel1");
	

        if (panelEnd != null)
		{
            panelEnd.SetActive(true);

			// Get and set the color of the material in one line
			panelEnd.GetComponent<Image>().color = Transparent;





        }
        else { Debug.Log("Error"); }
	}

       


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
                    ObjectScript.punkti += 1;
                    Debug.Log("Punkti " + ObjectScript.punkti);



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

					case "b2":
						ObjectScript.audioSource.PlayOneShot(ObjectScript.AudioToPlay[4]);
                            break;

					case "e46":
						ObjectScript.audioSource.PlayOneShot(ObjectScript.AudioToPlay[5]);
                            break;

					case "e61":
						ObjectScript.audioSource.PlayOneShot(ObjectScript.AudioToPlay[6]);
                            break;

					case "cement":
						ObjectScript.audioSource.PlayOneShot(ObjectScript.AudioToPlay[7]);
                            break;

					case "eskavat":
						ObjectScript.audioSource.PlayOneShot(ObjectScript.AudioToPlay[8]);
                            break;

					case "police":
						ObjectScript.audioSource.PlayOneShot(ObjectScript.AudioToPlay[9]);
                            break;

					case "trakt1":
						ObjectScript.audioSource.PlayOneShot(ObjectScript.AudioToPlay[10]);
                            break;

					case "trakt2":
						ObjectScript.audioSource.PlayOneShot(ObjectScript.AudioToPlay[11]);
                            break;

					case "firefighters":
						ObjectScript.audioSource.PlayOneShot(ObjectScript.AudioToPlay[12]);
                            break;

					

                    }
					
                    if (ObjectScript.punkti == 12 && firstTime == true)
                    {
						if (panelEnd != null)
						{
                            panelEnd.SetActive(true);
							panelEnd.GetComponent<Image>().color = NoTransparent;
                            firstTime = false;
						}
						else { Debug.Log("Error"); }
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

				case "b2":
					ObjectScript.B2Car.GetComponent<RectTransform>().localPosition = ObjectScript.B2CCOORD;
					break;

				case "e46":
					ObjectScript.E46Car.GetComponent<RectTransform>().localPosition = ObjectScript.E46CCOORD;
					break;

				case "e61":
					ObjectScript.E61Car.GetComponent<RectTransform>().localPosition = ObjectScript.E61CCOORD;
					break;

				case "cement":
					ObjectScript.CementCar.GetComponent<RectTransform>().localPosition = ObjectScript.CementCCOORD;
					break;

				case "eskavat":
					ObjectScript.EskavatCar.GetComponent<RectTransform>().localPosition = ObjectScript.EskavatCCOORD;
					break;

				case "police":
					ObjectScript.PoliceCar.GetComponent<RectTransform>().localPosition = ObjectScript.PoliceCCOORD;
					break;

				case "trakt1":
					ObjectScript.TractorCar.GetComponent<RectTransform>().localPosition = ObjectScript.TractorCCOORD;
					break;

				case "trakt2":
					ObjectScript.Tractor2Car.GetComponent<RectTransform>().localPosition = ObjectScript.Tractor2CCOORD;
					break;

				case "firefighters":
					ObjectScript.FireFightCar.GetComponent<RectTransform>().localPosition = ObjectScript.FireFightCCOORD;
					break;



                }
            }
		}
    }
}
