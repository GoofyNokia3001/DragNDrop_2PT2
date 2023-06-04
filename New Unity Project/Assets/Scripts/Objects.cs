using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour {

    public GameObject GarbageCar;
    public GameObject AmbulanceCar;
    public GameObject BusCar;
	public GameObject E46Car;
	public GameObject B2Car;
	public GameObject CementCar;
	public GameObject E61Car;
	public GameObject EskavatCar;
	public GameObject PoliceCar;
	public GameObject TractorCar;
	public GameObject Tractor2Car;
	public GameObject FireFightCar;




	[HideInInspector]
	public Vector2 GarbCCOORD;

	[HideInInspector]
	public Vector2 AmbulCCOORD;

    [HideInInspector]
    public Vector2 BusCCOORD;

	[HideInInspector]
	public Vector2 E46CCOORD;

	[HideInInspector]
	public Vector2 B2CCOORD;

	[HideInInspector]
	public Vector2 CementCCOORD;

	[HideInInspector]
	public Vector2 E61CCOORD;

	[HideInInspector]
	public Vector2 EskavatCCOORD;

	[HideInInspector]
	public Vector2 PoliceCCOORD;

	[HideInInspector]
	public Vector2 TractorCCOORD;

	[HideInInspector]
	public Vector2 Tractor2CCOORD;

	[HideInInspector]
	public Vector2 FireFightCCOORD;


	public Canvas canva;

	public AudioSource audioSource;
	public AudioClip[] AudioToPlay;

	[HideInInspector]
	public bool RightPlace = false;
	[HideInInspector]
	public GameObject LastDrag = null;

    // Use this for initialization
    void Start () {
		GarbCCOORD = GarbageCar.GetComponent<RectTransform>().localPosition;
        AmbulCCOORD = AmbulanceCar.GetComponent<RectTransform>().localPosition;
        BusCCOORD = BusCar.GetComponent<RectTransform>().localPosition;
		E46CCOORD = E46Car.GetComponent<RectTransform>().localPosition;
		B2CCOORD = B2Car.GetComponent<RectTransform>().localPosition;
		CementCCOORD = CementCar.GetComponent<RectTransform>().localPosition;
		E61CCOORD = E61Car.GetComponent<RectTransform>().localPosition;
		EskavatCCOORD = EskavatCar.GetComponent<RectTransform>().localPosition;
		PoliceCCOORD = PoliceCar.GetComponent<RectTransform>().localPosition;
		TractorCCOORD = TractorCar.GetComponent<RectTransform>().localPosition;
		Tractor2CCOORD = Tractor2Car.GetComponent<RectTransform>().localPosition;
		FireFightCCOORD = FireFightCar.GetComponent<RectTransform>().localPosition;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
