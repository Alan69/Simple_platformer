using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Animator animator;
    public AudioSource AudioSource;
    public GameObject bullet;
    public Transform firePoint;

    bool shoot = false; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
            shoot = true;
            animator.SetBool("isShooting", true);
            AudioSource.Play();
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            shoot = false;
            animator.SetBool("isShooting", false);
        }
    }

    void Fire()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);

    }
}
