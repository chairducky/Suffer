using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Movement;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField] private PhysicsMovement _movement;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis(Axis.Horizontal);
        float jump = Input.GetAxis(Axis.Jump);

        _movement.Move(new Vector2(horizontal, 0));
    }
}
