using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour {

    private float hiz=1f;
    private float hizlanma = 0.2f;
    private float maxHiz = 3.2f;

    private float kolayhiz = 3.0f;
    private float normalhiz = 3.8f;
    private float zorhiz = 4.6f;

    

    [HideInInspector]
    public bool hareketliKamera;



	// Use this for initialization
	void Start () {

        if (OyunTercihleri.GetirKolayZorlukDurumu() == 1)
        {
            maxHiz = kolayhiz;
        }

        if (OyunTercihleri.GetirNormalZorlukDurumu() == 1)
        {
            maxHiz = normalhiz;
        }


        if (OyunTercihleri.GetirYuksekZorlukDurumu() == 1)
        {
            maxHiz = zorhiz;
        }

        hareketliKamera = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (hareketliKamera)
        {
            HareketliKamera();
        }
	}

    void HareketliKamera()
    {
        Vector3 depo = transform.position;
        float eskiY = depo.y;
        float yeniY = depo.y - (hiz * Time.deltaTime);
        depo.y = Mathf.Clamp(depo.y, eskiY, yeniY);
        transform.position = depo;
        hiz += hizlanma * Time.deltaTime;
        if (hiz > maxHiz)
        {
            hiz = maxHiz;
        }
    }
}
