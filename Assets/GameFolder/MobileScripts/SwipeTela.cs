using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTela : MonoBehaviour
{
    [SerializeField] private Vector3 fingerDown;
    [SerializeField] private Vector3 fingerUp;
    [SerializeField] private bool detectedFinalSwipe = false;

    [SerializeField] private float swipe_Sensi = 20f;

  
    void Update()
    {
        //Arry of the tuches on the screen
        foreach (Touch touch in Input.touches)
        {
            //Frist touch
            if (touch.phase == TouchPhase.Began)
            {
                fingerDown = touch.position;
                fingerUp = touch.position;
            }

            //Finger move
            if (touch.phase == TouchPhase.Moved)
            {
                if (!detectedFinalSwipe)
                {
                    fingerDown = touch.position;
                    CheckSwipe();
                }
            }

            //Finger came out
            if (touch.phase == TouchPhase.Ended)
            {
                fingerDown = touch.position;
                CheckSwipe();
            }
        }
    }

    void CheckSwipe()
    {

        //Vertical move
        if (VerticalMove() > swipe_Sensi && VerticalMove() > HorizontalMove())
        {
            if (fingerDown.y - fingerUp.y > 0)
            {
                OnSwipeUp();
            }
            else if(fingerDown.y - fingerUp.y < 0)
            {
                OnSwipeDown();
            }

            fingerUp = fingerDown;

         
         //Horizontal Move   
        }else if (HorizontalMove() > swipe_Sensi && HorizontalMove() > VerticalMove())
        {
            if (fingerDown.x - fingerUp.x > 0)
            {
                OnSwipeRight();
            }
            else if(fingerDown.x - fingerUp.x < 0)
            {
                OnSwipeLeft();
            }

            fingerUp = fingerDown;
        }
        else
        {
            //No movement
        }

    }

    float VerticalMove()
    {
        return Mathf.Abs(fingerDown.y - fingerUp.y);
    }
    float HorizontalMove()
    {
        return Mathf.Abs(fingerDown.x - fingerUp.x);
    }



    void OnSwipeUp()
    {
        Debug.Log("Cima!");
    }

    void OnSwipeDown()
    {
        Debug.Log("Baixo!");
    }

    void OnSwipeLeft()
    {
        Debug.Log("Esquerda!");
    }

    void OnSwipeRight()
    {
        Debug.Log("Direita!");
    }
}
