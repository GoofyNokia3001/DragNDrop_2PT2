using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour {

    public GameObject GarbageCar;
    public GameObject AmbulanceCar;
    public GameObject BusCar;

	[HideInInspector]
	public Vector2 GarbCCOORD;

	[HideInInspector]
	public Vector2 AmbulCCOORD;

    [HideInInspector]
    public Vector2 BusCCOORD;

	public Canvas canva;

	public AudioSource audioSource;
	public AudioClip[] AudioToPlay;

	[HideInInspector]
	public bool RightPlace = false;
	public GameObject LastDrag = null;

    // Use this for initialization
    void Start () {
		GarbCCOORD = GarbageCar.GetComponent<RectTransform>().localPosition;
        AmbulCCOORD = AmbulanceCar.GetComponent<RectTransform>().localPosition;
        BusCCOORD = BusCar.GetComponent<RectTransform>().localPosition;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
