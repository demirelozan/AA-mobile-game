using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject kucukcember;
    public oyun oyun;
    
    void Start()
    {
        oyun = oyun.GetComponent<oyun>();

    }

    
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && oyun.oyunkontrol )
        {
            oyun.CemberlerdeSayi();
            CemberOlusturma();
            
        }
    }
    void CemberOlusturma()
    {
        Instantiate(kucukcember, transform.position, transform.rotation);//unuttun
    }
}
