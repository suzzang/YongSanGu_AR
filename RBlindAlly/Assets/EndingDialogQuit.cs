﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EndingDialogQuit : MonoBehaviour, IPointerClickHandler
{
    public EndingCharacter ec;
    public void OnPointerClick(PointerEventData eventData)
    {
        ec.camerabtn = 1;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
