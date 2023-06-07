using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float Timer;
    public bool TimerOn = false;
    public Objects ObjectScript;
    public DragEnd Dragend;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject StarLeft;
    public GameObject StarCenter;
    public GameObject StarRight;
    
  

    public Text TimerTxt;

    void Start()
    {
        Screen.SetResolution(1280, 600, false);

        StarLeft.GetComponent<Image>().color = Dragend.Transparent;
        StarCenter.GetComponent<Image>().color = Dragend.Transparent;
        StarRight.GetComponent<Image>().color = Dragend.Transparent;

        TimerOn = true;
        Button1.GetComponent<RectTransform>().localPosition = new Vector2(570, 290);
        Button2.GetComponent<RectTransform>().localPosition = new Vector2(-570, 290);

    }

    void Update()
    { if (ObjectScript.punkti == 12) {
            TimerOn = false;
            Button1.GetComponent<RectTransform>().localPosition = new Vector2(0,40);
            Button2.GetComponent<RectTransform>().localPosition = new Vector2(0, -65);
            
                if (Timer <= 60)
                {
                    StarLeft.GetComponent<Image>().color = Dragend.NoTransparent;
                    StarCenter.GetComponent<Image>().color = Dragend.NoTransparent;
                    StarRight.GetComponent<Image>().color = Dragend.NoTransparent;
                }
                else if (Timer <= 120)
                {
                    StarLeft.GetComponent<Image>().color = Dragend.NoTransparent;
                    StarCenter.GetComponent<Image>().color = Dragend.NoTransparent;
                }

                else if (Timer <= 180)
                {
                    StarLeft.GetComponent<Image>().color = Dragend.NoTransparent;
                }
                else if (Timer > 181) { }
                
            
        }
        if (TimerOn)
        {
            if (Timer >= 0)
            {
                Timer += Time.deltaTime;
                updateTimer(Timer);
            }
            else
            {
                
                Timer = 0;
                TimerOn = false;
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float hours = Mathf.FloorToInt(currentTime / 3600);
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        Debug.Log(currentTime);

        TimerTxt.text = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
       
       

    }

}