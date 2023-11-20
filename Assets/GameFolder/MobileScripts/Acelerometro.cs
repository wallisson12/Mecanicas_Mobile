using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerometro : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(new Vector2(Input.acceleration.x * speed,Input.acceleration.y *speed));
    }
}
