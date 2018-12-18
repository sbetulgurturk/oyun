using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour,IPointerUpHandler,IPointerDownHandler {

    private PlayerKontrol playerHareket;

    public void OnPointerDown(PointerEventData veri)
    {
        if (gameObject.name == "SolBtn")
        {

            playerHareket.AyarlaSolaGit(true);
        }
        else
        {
            playerHareket.AyarlaSolaGit(false);
        }
    }

    public void OnPointerUp(PointerEventData veri)
    {
        playerHareket.HareketiDurdur();
    }

	// Use this for initialization
	void Start () {
        playerHareket = GameObject.Find("Player").GetComponent<PlayerKontrol>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
