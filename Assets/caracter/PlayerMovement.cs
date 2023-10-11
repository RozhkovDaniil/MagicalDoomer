using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    public Transform target;
    public Camera cam;
    public test controller;
    public float speed = 40f;
    float direction = 0f;
    bool TryToFly = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            TryToFly = true;
        }
        direction = Input.GetAxis("Horizontal") * speed;
        // Debug.Log(controller.m_FacingRight);
        // Debug.Log();
    }

    private void LookAtMouse()
    {
        var look_direction = Input.mousePosition - Camera.main.WorldToScreenPoint(target.position);
        var angle = Mathf.Atan2(look_direction.y, look_direction.x) * Mathf.Rad2Deg;
        target.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime, false, false);
        if (TryToFly){
            controller.Move(direction * Time.fixedDeltaTime, false, true);
            TryToFly = false;
        }
    }
}
