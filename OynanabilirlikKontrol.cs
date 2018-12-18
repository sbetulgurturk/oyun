using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OynanabilirlikKontrol : MonoBehaviour {

    public static OynanabilirlikKontrol ornek;

    void Awake()
    {
        OrnekYap();
    }

    void OrnekYap()
    {
        if (ornek == null)
        {
            ornek = this;
        }
    }

    

    [SerializeField]
    private Text skorText;

    [SerializeField]
    private Text altinText;

    [SerializeField]
    private Text canText;

    [SerializeField]
    private Text oyunSonuSkorText;

    [SerializeField]
    private Text oyunSonuAltinText;
  



    [SerializeField]
    public GameObject durdurPanel;

    [SerializeField]
    private GameObject oyunSonuPanel;

    [SerializeField]
    private GameObject HazirBtn;



    public void OyunuBaslat()
    {
        Time.timeScale = 1f;
        HazirBtn.SetActive(false);
    }

    public void OyunuDurdur()
    {
        
        Time.timeScale = 0f;
        durdurPanel.SetActive(true);
    }

    public void OyunuSurdur()
    {
        Time.timeScale = 1f;
        durdurPanel.SetActive(false);
    }

    public void OyunuKapat()
    {
        Time.timeScale = 1f;
        SahneGecis.ornek.LoadLevel("MainMenu");
    }

	// Use this for initialization
	void Start () {
        Time.timeScale = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SkorHesapla(int skor)
    {
        skorText.text = "0" + skor;
    }

    public void AltinHesapla(int altinskor)
    {
        altinText.text = "x" + altinskor;
    }

    public void CanHesapla(int canskor)
    {
        canText.text = "x" + canskor;
    }

    public void OyunSonuPanelAc(int sonSkor,int sonAltinSkor)
    {
        oyunSonuPanel.SetActive(true);
        oyunSonuSkorText.text = sonSkor.ToString();
        oyunSonuAltinText.text = sonAltinSkor.ToString();
        StartCoroutine(OyunSonuPanelYukle());

    }

    IEnumerator OyunSonuPanelYukle()
    {
        yield return new WaitForSeconds(3f);
        SahneGecis.ornek.LoadLevel("MainMenu");
    }
    public void KarakterOlunceOyunuYenidenBaslat()
    {
        StartCoroutine(KarakterOlunceYenidenBaslat());
    }
    IEnumerator KarakterOlunceYenidenBaslat()
    {
        yield return new WaitForSeconds(1f);
        SahneGecis.ornek.LoadLevel("oyunDort");
    }


}
