using UnityEngine;
using System.Collections;
using System;

public class HideSystem : MonoBehaviour {
    public bool isHidden;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void setHiddenTrue()
    {
        isHidden = true;
    }
    
    public void setHiddenFalse()
    {
        isHidden = false;
    }
    public bool getHidden()
    {
        return isHidden;
    }
}
