using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    public static int CurrentAmmo;
    public int InternalAmmo;
    public GameObject AmmoDisplay;

    public static int LoadedAmmo;
    public int InternalLoadedAmmo;
    public GameObject LoadedAmmoDisplay;

    void Update()
    {
        InternalAmmo = CurrentAmmo;
        InternalLoadedAmmo = LoadedAmmo;
        AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmo;
        LoadedAmmoDisplay.GetComponent<Text>().text = "" + LoadedAmmo;
    }
}