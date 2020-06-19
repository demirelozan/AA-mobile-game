using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class oyun : MonoBehaviour
{
    public bool oyunkontrol = true;
    public Animator animator;
    public Text levelatama;
    public Text bir;
    public Text iki;
    public Text uc;
    public int cembersayı;
    public dondurme dondurme;
   public bool kontrol = true;
    
    void Start()
    {
        dondurme = GameObject.FindGameObjectWithTag("cemberdon").GetComponent<dondurme>();
        levelatama.text = SceneManager.GetActiveScene().name;
        if (cembersayı < 2)
        {
            bir.text = cembersayı + "";
            iki.text = "";
            uc.text = ""; }
        else if (cembersayı == 2)
        {
            bir.text = cembersayı + "";
            iki.text = cembersayı - 1 + "";
            uc.text = "";
        
        }
        else
        {
            bir.text = cembersayı + "";
            iki.text = cembersayı-1 + "";
            uc.text = cembersayı-2 + "";
        }

       
    }

    
    public void CemberlerdeSayi()
    {
        if (cembersayı < 2)
        {
            bir.text = cembersayı-1 + "";
            iki.text = "";
            uc.text = "";
        }
        else if (cembersayı == 2)
        {
            bir.text = cembersayı-1 + "";
            iki.text = cembersayı - 2 + "";
            uc.text = "";

        }
        else
        {
            bir.text = cembersayı -1 + "";
            iki.text = cembersayı - 2 + "";
            uc.text = cembersayı - 3 + "";
        }

        Debug.Log("azalma var");
        cembersayı--;
        if(cembersayı == 0 )
        {
            Invoke("oyunkazan", 0.3f);
           //oyunkazan();
           
        }
    }
    void Update()
    {
       
    }
    public void oyunkazan()
    {
        Debug.Log("level kazanıldı");
        oyunkontrol = false;
        StartCoroutine(dondurme.oyunbasarili());
        //if (kontrol)
        //{
          //  SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
        //}
    }

    public void oyunkayip()
    {
        StartCoroutine(cagirilan());
        //burda patladın    
    }
    
    IEnumerator cagirilan()
    {
        Debug.Log("oyun bitti");
        oyunkontrol = false;
        animator.SetTrigger("oyunbitti");
        yield return new WaitForSeconds(1);
        kontrol = false;
        //burası patlattı
        SceneManager.LoadScene("AnaMenu");
    }
    
}
