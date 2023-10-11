using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatme : MonoBehaviour
{
    public test Facing;
    public Transform target;
    private void LookAtMouse()
    {
        var look_direction = Input.mousePosition - Camera.main.WorldToScreenPoint(target.position);
        if (Facing.m_FacingRight)
        {
            var angle = Mathf.Atan2(look_direction.y, look_direction.x) * Mathf.Rad2Deg;
            target.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            target.transform.localScale = new Vector3(-2, -2, 1);
        } else
        {
            var angle = Mathf.Atan2(look_direction.y, look_direction.x) * Mathf.Rad2Deg;
            target.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            target.transform.localScale = new Vector3(2, 2, 1);
        }
        
    }
    void Update()
    {
        LookAtMouse();
    }
}
