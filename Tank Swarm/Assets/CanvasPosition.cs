using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPosition : MonoBehaviour
{
    public Transform target;

    public float offset = 1.1f;


    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y + offset);
    }
}
