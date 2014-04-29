using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public float seconds = 59;
	public float minutes = 0;
    float insiderSeconds;
    float insiderMinutes;
    bool isOn = false;

    public bool GetIsOn(){
        return isOn;
    }

	// Use this for initialization
	void Start () {
        insiderMinutes = minutes;
        insiderSeconds = seconds;
	}
	
	// Update is called once per frame
	void Update () {
        if(isOn){
            if(insiderSeconds <= 0 && insiderMinutes <= 0){
                isOn = false;
                insiderSeconds = seconds;
                insiderMinutes = minutes;
            }
            else{
                if (insiderSeconds <= 0)
                {
                    insiderSeconds = 59;
                    if (insiderMinutes >= 1)
                        insiderMinutes--;
                    else
                    {
                        insiderMinutes = 0;
                        insiderSeconds = 0;
                        GameObject.Find("Timer").guiText.text = insiderMinutes.ToString("f0")+ ":0" + insiderSeconds.ToString("f0");
                    }
                } 
                else
                    insiderSeconds -= Time.deltaTime;

                if (Mathf.Round(seconds) <= 9)
                    GameObject.Find("Timer").guiText.text = insiderMinutes.ToString("f0")+ ":0" + insiderSeconds.ToString("f0");
                else
                    GameObject.Find("Timer").guiText.text = insiderMinutes.ToString("f0")+ ":" + insiderSeconds.ToString("f0");
            }
        }
        
	}

    public bool StartTimer(){
        if(!isOn){
            isOn = true;
            return true;
        }
        return false;
    }
}
