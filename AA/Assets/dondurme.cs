using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class dondurme : MonoBehaviour
{
    public float hiz = 50f;
    public Rigidbody2D fizik;
    public oyun oyun;

    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        //bu satıra iyi çalış
        oyun = oyun.GetComponent<oyun>();



    }


    void FixedUpdate()
    {

        if (oyun.oyunkontrol)
        {
            fizik.transform.Rotate(0, 0, hiz * Time.fixedDeltaTime);
        }
    }
    
     public IEnumerator oyunbasarili()
    {
        Debug.Log("oyun bitti");
        oyun.oyunkontrol = false;
        oyun.animator.SetTrigger("oyunbasarili");
        yield return new WaitForSeconds(1);
        //burası patlattı
        if (oyun.kontrol)
        {
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
        }
    }
}