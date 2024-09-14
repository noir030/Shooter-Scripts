using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnimate : MonoBehaviour
{
    public GameObject UpCurs;
    public GameObject DownCurs;
    public GameObject LeftCurs;
    public GameObject RightCurs;

    void Update() 
    {
        if(GlobalAmmo.LoadedAmmo >= 1){
            if (Input.GetButton("Fire1") && Time.time > 0) 
            {
                UpCurs.GetComponent<Animation>().Play("UpCursAnimation");
                DownCurs.GetComponent<Animation>().Play("DownCursAnimation");
                LeftCurs.GetComponent<Animation>().Play("LeftCursAnimation");
                RightCurs.GetComponent<Animation>().Play("RightCursAnimation");
            }
        }
    }
}