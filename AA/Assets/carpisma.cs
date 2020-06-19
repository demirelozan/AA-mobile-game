using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpisma : MonoBehaviour
{
    public float hiz;
    Rigidbody2D rigid;
    public bool kontrol = true;
    // public bool oyun = true;
    GameObject oyunyoneticisi;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        oyunyoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisi");
    }


    void FixedUpdate()
    {
        if (kontrol && oyunyoneticisi.GetComponent<oyun>().oyunkontrol)
        {
            rigid.MovePosition(rigid.position + Vector2.up * hiz * Time.deltaTime);
            //burda patladın
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "cemberdon")
        {
            kontrol = false;
            transform.SetParent(col.transform);//burda patladın
        }
        if(col.tag == "kucukcember")
        {
            oyunyoneticisi.GetComponent<oyun>().oyunkayip();
            
           // oyunkontrol = false;
        }
    }
    
    
}
   