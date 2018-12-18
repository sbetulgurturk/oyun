using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaplanKaldir : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Arkaplan")
        {
            other.gameObject.SetActive(false);
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
