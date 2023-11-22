using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class Player_I : MonoBehaviour
{
    [Header("Input Player")]
    PlayerInput _playerI;
    //InputAction _movementA1;
    //public  InputActionReference _movementA2;



    Rigidbody2D rig;
    public Vector2 dir;
    public float speed;

    void Awake()
    {
        _playerI = GetComponent<PlayerInput>();
        rig = GetComponent<Rigidbody2D>();
       // _movementA1 = _playerI.actions.FindAction("Movement");

    }

    void Start()
    {
        
    }


    void FixedUpdate()
    {
        MovePlayer();    
    }

    void Update()
    {
        
    }
    void MovePlayer()
    {
        //Nessa parte o dir, esta recebendo a acao ja procurada antes 
        //Vector2 dir = _movementA1.ReadValue<Vector2>();

        //Nesssa parte o dir, esta recebendo a propria acao ja referenciada
        //Vector2 dir = _movementA2.action.ReadValue<Vector2>();


        rig.MovePosition(rig.position + dir * speed * Time.fixedDeltaTime);
    }

    //Events Inputs
    public void SetMoveInput(CallbackContext value)
    {
        //Retorna o movimento
        dir = value.ReadValue<Vector2>();
    }

    public void SetFireInput(CallbackContext value)
    {
        //Retorna se o botao foi press
        if (value.started)
        {
            Debug.Log("Atacou!");
        }
    } 

}
