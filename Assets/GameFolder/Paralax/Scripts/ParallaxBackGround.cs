using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackGround : MonoBehaviour
{
    [SerializeField] private Vector2 parallaxSpeed;
    private Transform cameraTransform;
    private Vector3 startPosition;
    
    void Start()
    {
        cameraTransform = Camera.main.transform;
        startPosition = transform.position;
    }

    
    void FixedUpdate()
    {
        float distanceX = cameraTransform.position.x * parallaxSpeed.x;
        float distanceY = cameraTransform.position.y * parallaxSpeed.y;
        transform.position = new Vector2(startPosition.x + distanceX,startPosition.y + distanceY);
 
    }
}
