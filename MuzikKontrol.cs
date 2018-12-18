﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzikKontrol : MonoBehaviour {

    public static MuzikKontrol ornek;
    private AudioSource sesKaynagi;

    void Awake()
    {
        TekYap();
        sesKaynagi = GetComponent<AudioSource>();
    }

    void TekYap()
    {
        if (ornek != null)
        {
            Destroy(gameObject);
        }
        else
        {
            ornek = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void OynatMuzik(bool oynat)
    {
        if (oynat)
        {
            if (!sesKaynagi.isPlaying)
            {
                sesKaynagi.Play();
            }
        }
        else
        {
            if (sesKaynagi.isPlaying)
            {
                sesKaynagi.Stop();
            }
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
