using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField] private float speed;

    [Header("Lights")]
    [SerializeField] private GameObject[] lights;

    [Header("Volume")]
    [SerializeField] private Volume pp;

    [SerializeField] private bool day, night;
    
    
    void FixedUpdate()
    {
        ControlPPV();
    }

    void ControlPPV()
    {
        if (day && pp.weight > 0)
        {
            night = false;
            pp.weight -= Time.fixedDeltaTime * speed;

            if (pp.weight <= 0.5)
            {
                foreach (GameObject light in lights)
                {
                    light.SetActive(false);
                }
            }

            if (pp.weight < 0)
            {
                pp.weight = 0f;
            }

            Debug.Log("Day");
        }
        else if(night && pp.weight < 1)
        {
            day = false;
            pp.weight += Time.fixedDeltaTime * speed;

            if (pp.weight >= 0.7f)
            {
                foreach (GameObject light in lights)
                {
                    light.SetActive(true);
                }
            }

            if (pp.weight > 1)
            {
                pp.weight = 1f;
            }
            Debug.Log("Night");
        }
    }
}
