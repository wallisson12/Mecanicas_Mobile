using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTela : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update() 
    {
        TouchPhasee();
    }

    void TouchPhasee()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            //Only the frist touch
            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("Tocou");
            }

            //Not considered touch
            if (touch.phase == TouchPhase.Canceled)
            {
                Debug.Log("Nao considerado Touch");
            }

            //Finger came out
            if (touch.phase == TouchPhase.Ended)
            {
                Debug.Log("Dedo saiu");
            }

            //Finger is moved
            if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("Dedo se movimentando");
            }

            //Finger is stopped
            if (touch.phase == TouchPhase.Stationary)
            {
                Debug.Log("Dedo parado");
            }
        }
    }

    void TouchOnScreen()
    {
        //Be touch on the screen
        if (Input.touchCount > 0)
        {
            //Frist Touch on the screen
            Touch touch = Input.GetTouch(0);

            //Taking the position touch on the world
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.z = 0f;

            transform.position = touchPos;


        }
    }
    void ManayTouches()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            Debug.DrawLine(Vector3.zero, touchPos, Color.green);
        }
    }
}
