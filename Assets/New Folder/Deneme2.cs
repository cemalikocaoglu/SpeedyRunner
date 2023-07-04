using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme2 : MonoBehaviour
{

    public List<int> sayi2;

    Deneme1 deneme1;

    private void Awake()
    {
        deneme1 = GetComponent<Deneme1>();
        

    }

    private void Start()
    {


        for (int i = 0; i < deneme1._sayi.Count; i++)
        {
            sayi2.Add( deneme1._sayi[i]);
        }

    }
}
