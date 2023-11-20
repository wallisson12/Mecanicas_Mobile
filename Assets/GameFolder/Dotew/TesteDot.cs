using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TesteDot : MonoBehaviour
{

    public SpriteRenderer sprite;
    
    void Start()
    {
        transform.DOMoveX(45f, 10f).SetLoops(3,LoopType.Yoyo);
        sprite.DOColor(Color.red, 10f).SetLoops(3,LoopType.Yoyo);
    }

   
}
