using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyScript : MonoBehaviour
{
    public float EmptyHealth = 10f;

    void Update()
    {
        if(EmptyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    void DeductPoints(float damage)
    {
        EmptyHealth -= damage;
    }
}