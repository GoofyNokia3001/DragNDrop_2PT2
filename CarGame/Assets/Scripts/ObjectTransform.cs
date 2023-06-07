using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransform : MonoBehaviour {
	public Objects objectScript;

	void Update () {
		if (objectScript.LastDrag != null) {
			if (Input.GetKey(KeyCode.Z)) {
				objectScript.LastDrag.GetComponent<RectTransform>().transform.Rotate(0, 0, Time.deltaTime * 20f);
			}
		}

        if (objectScript.LastDrag != null)
        {
            if (Input.GetKey(KeyCode.X))
            {
                objectScript.LastDrag.GetComponent<RectTransform>().transform.Rotate(0, 0, -Time.deltaTime * 20f);
            }
        }

        if (objectScript.LastDrag != null)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (objectScript.LastDrag.GetComponent<RectTransform>().localScale.y <= 1.5)
                {
                    objectScript.LastDrag.GetComponent<RectTransform>().transform.localScale = new Vector2(objectScript.LastDrag.
                        GetComponent<RectTransform>().localScale.x, objectScript.LastDrag.GetComponent<RectTransform>().localScale.y + 0.01f);
                }


            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (objectScript.LastDrag.GetComponent<RectTransform>().localScale.y >= 0.2f)
                {
                    objectScript.LastDrag.GetComponent<RectTransform>().transform.localScale = new Vector2(objectScript.LastDrag.
                        GetComponent<RectTransform>().localScale.x, objectScript.LastDrag.GetComponent<RectTransform>().localScale.y - 0.01f);
                }
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (objectScript.LastDrag.GetComponent<RectTransform>().localScale.x >= 0.2f)
                {
                    objectScript.LastDrag.GetComponent<RectTransform>().transform.localScale =
                         new Vector2(objectScript.LastDrag.GetComponent<RectTransform>().localScale.x - 0.01f,
                         objectScript.LastDrag.GetComponent<RectTransform>().localScale.y);
                }
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (objectScript.LastDrag.GetComponent<RectTransform>().localScale.x <= 1.5f)
                {
                    objectScript.LastDrag.GetComponent<RectTransform>().transform.localScale = 
                        new Vector2(objectScript.LastDrag.GetComponent<RectTransform>().localScale.x + 0.01f,
                        objectScript.LastDrag.GetComponent<RectTransform>().localScale.y);
                }
            }
        }
    }
}

