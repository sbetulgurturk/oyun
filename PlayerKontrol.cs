using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKontrol : MonoBehaviour {

    public float karakterHizi = 2f,maxSurat=3f;
    private Rigidbody2D myRigidbody;
    private Animator myAnimator;

    private bool solaGit, sagaGit;

    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (solaGit)
        {
            SolaGit();
        }
        if (sagaGit)
        {
            SagaGit();
        }
    }

    public void AyarlaSolaGit(bool solaGit)
    {
        this.solaGit = solaGit;
        this.sagaGit = !solaGit;
    }

    public void HareketiDurdur()
    {
        solaGit = sagaGit = false;
        myAnimator.SetBool("run", false);

    }


    void SolaGit()
    {
        float Xdurdur = 0f;
        float surat = Mathf.Abs(myRigidbody.velocity.x);

        if (surat < maxSurat)
            Xdurdur = -karakterHizi;

        Vector3 yon = transform.localScale;
        yon.x = -0.3f;
        transform.localScale = yon;

        myAnimator.SetBool("run", true);

        myRigidbody.AddForce(new Vector2(Xdurdur, 0));
    }


    void SagaGit()
    {
        float Xdurdur = 0f;
        float surat = Mathf.Abs(myRigidbody.velocity.x);

        if (surat < maxSurat)
            Xdurdur = karakterHizi;

        Vector3 yon = transform.localScale;
        yon.x = 0.3f;
        transform.localScale = yon;

        myAnimator.SetBool("run", true);

        myRigidbody.AddForce(new Vector2(Xdurdur, 0));
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
