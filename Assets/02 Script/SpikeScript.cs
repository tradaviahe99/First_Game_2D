using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Observer.Notify("TakeDamage");
    }
}
