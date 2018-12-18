using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnaMenuKontrol : MonoBehaviour {

    [SerializeField]
    private Button muzikBtn;

    [SerializeField]
    private Sprite[] muzikAcikKapali;
    



    // Use this for initialization
    void Start () {
        KontrolMuzik();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void KontrolMuzik()
    {
        if (OyunTercihleri.GetirMuzikDurumu() == 1)
        {
            MuzikKontrol.ornek.OynatMuzik(true);
            muzikBtn.image.sprite = muzikAcikKapali[1];
        }
        else
        {
            MuzikKontrol.ornek.OynatMuzik(false);
            muzikBtn.image.sprite = muzikAcikKapali[0];
        }
    }

    public void MuzikButton()
    {
        if (OyunTercihleri.GetirMuzikDurumu() == 0)
        {
            OyunTercihleri.AyarlaMuzikDurumu(1);
            MuzikKontrol.ornek.OynatMuzik(true);
            muzikBtn.image.sprite = muzikAcikKapali[1];
        }
        else if (OyunTercihleri.GetirMuzikDurumu() == 1)
        {
            OyunTercihleri.AyarlaMuzikDurumu(0);
            MuzikKontrol.ornek.OynatMuzik(false);
            muzikBtn.image.sprite = muzikAcikKapali[0];
        }
    }

    public void OyunuBaslat()
    {
        OyunYoneticisi.ornek.oyunAnaMenudenBaslatildi = true;

        SahneGecis.ornek.LoadLevel("oyunDort");

    }
    public void HighScore()
    {
#pragma warning disable CS0618 // Tür veya üye eski
        Application.LoadLevel("YuksekSkor");
#pragma warning restore CS0618 // Tür veya üye eski
    }
    public void Options()
    {
#pragma warning disable CS0618 // Tür veya üye eski
        Application.LoadLevel("Ayarlar");
#pragma warning restore CS0618 // Tür veya üye eski
    }
    public void OyunuKapat()
    {

    }
    public void Muzik()
    {

    }
}
