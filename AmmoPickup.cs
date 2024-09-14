using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public AudioSource audioSource;
    void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        if(GlobalAmmo.LoadedAmmo == 0)
        {
            GlobalAmmo.LoadedAmmo += 30;
            Destroy(gameObject);;
        }
        else
        {
            GlobalAmmo.CurrentAmmo += 30;
            Destroy(gameObject);;
        }
        
    }
}
