using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public GameObject currentWeapon;

    public float WeaponShot()
    {
       return currentWeapon.GetComponent<Defaultgunscript>().fired();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
