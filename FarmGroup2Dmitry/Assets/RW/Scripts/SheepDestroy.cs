using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Sheep sheep = other.gameObject.GetComponent<Sheep>();

        if(sheep != null)
        {
            sheep.DestroySheep();
        }
    }
}
