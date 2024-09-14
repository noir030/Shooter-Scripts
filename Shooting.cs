using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float damage = 21f;
    public float fireRate = 1f;
    public float range = 15f;
    public float distance;
    public float force = 155f;
    public Transform bulletSpawn;
    public ParticleSystem muzzleFlash;
    public AudioClip shotSFX;
    public AudioClip dontshotSFX;
    public AudioSource audioSource;
    public Camera cam;
    private float nextFire = 0f; 
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        if(GlobalAmmo.LoadedAmmo >= 1)
        {
            audioSource.PlayOneShot(shotSFX);
            muzzleFlash.Play();
            GetComponent<Animation>().Play("GunShot");
            GlobalAmmo.LoadedAmmo -= 1;
            RaycastHit hit;
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
            {
                distance = hit.distance;
                if(distance < range)
                {
                    hit.transform.SendMessage("DeductPoints", damage, SendMessageOptions.DontRequireReceiver);
                }

                Debug.Log("Yes");

                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * force);
                }
            }
        }
        else
        {
            audioSource.PlayOneShot(dontshotSFX); 
        }
    }
}