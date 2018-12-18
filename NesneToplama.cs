using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NesneToplama : MonoBehaviour {


    void Aktifken()
    {
        Invoke("PasifYap", 6f);
    }

    void PasifYap()
    {
        gameObject.SetActive(false);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
