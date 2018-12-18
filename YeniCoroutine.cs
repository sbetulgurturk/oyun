using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YeniCoroutine : MonoBehaviour {

    public static IEnumerator GercekZamaniBekle(float zaman)
    {
        float baslangic = Time.realtimeSinceStartup;
        while (Time.realtimeSinceStartup < (baslangic + zaman))
        {
            yield return null;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
