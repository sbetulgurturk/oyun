using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AyarlarKontrol : MonoBehaviour {

    [SerializeField]
    private GameObject kolayTik, normalTik, zorTik;

	// Use this for initialization
	void Start () {
        AyarlaZorluk();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void secZorluk(string zorluk)
    {
        switch (zorluk)
        {
            case "kolay":
                normalTik.SetActive(false);
                zorTik.SetActive(false);
                break;
            case "normal":
                kolayTik.SetActive(false);
                zorTik.SetActive(false);
                break;
            case "zor":
                normalTik.SetActive(false);
                kolayTik.SetActive(false);
                break;
        }
    }

    void AyarlaZorluk()
    {
        if (OyunTercihleri.GetirKolayZorlukDurumu() == 1)
        {
            secZorluk("kolay");
        }

        if (OyunTercihleri.GetirNormalZorlukDurumu() == 1)
        {
            secZorluk("normal");
        }

        if (OyunTercihleri.GetirYuksekZorlukDurumu() == 1)
        {
            secZorluk("zor");
        }
    }


    public void KolayZorluk()
    {
        OyunTercihleri.AyarlaKolayZorlukDurumu(1);
        OyunTercihleri.AyarlaNormalZorlukDurumu(0);
        OyunTercihleri.AyarlaYuksekZorlukDurumu(0);

        kolayTik.SetActive(true);
        normalTik.SetActive(false);
        zorTik.SetActive(false);
    }


    public void NormalZorluk()
    {
        OyunTercihleri.AyarlaKolayZorlukDurumu(0);
        OyunTercihleri.AyarlaNormalZorlukDurumu(1);
        OyunTercihleri.AyarlaYuksekZorlukDurumu(0);

        kolayTik.SetActive(false);
        normalTik.SetActive(true);
        zorTik.SetActive(false);
    }

    public void YuksekZorluk()
    {
        OyunTercihleri.AyarlaKolayZorlukDurumu(0);
        OyunTercihleri.AyarlaNormalZorlukDurumu(0);
        OyunTercihleri.AyarlaYuksekZorlukDurumu(1);

        kolayTik.SetActive(false);
        normalTik.SetActive(false);
        zorTik.SetActive(true);
    }


    public void AnaMenuyeDon()
    {
#pragma warning disable CS0618 // Tür veya üye eski
        Application.LoadLevel("MainMenu");
#pragma warning restore CS0618 // Tür veya üye eski
    }
}
