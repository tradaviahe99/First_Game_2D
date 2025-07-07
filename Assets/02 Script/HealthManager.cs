using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Text healthText;
    int health = 3;
    void Start ()
    {
        Observer.Addlistener("TakeDamage", TakeDmg);
        healthText.text = health.ToString() + " HP";
    }
    void OnDestroy()
    {
        Observer.Removelistener("TakeDamage", TakeDmg);
    }
    public void TakeDmg (object[] datas)
    {
        health -= 1;
        healthText.text = health.ToString() + " HP";
    }

}
