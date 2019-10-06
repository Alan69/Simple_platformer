using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    public Transform FirePointFlip;
    
    void Update()
    {
        FirePointFlip.rotation = transform.rotation;
    }
    
}
