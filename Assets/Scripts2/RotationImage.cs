using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationImage : MonoBehaviour
{
    public float rotateSpeed = 1;

    void Update()
    {
        this.transform.Rotate(0, 0, rotateSpeed, Space.World);
    }
}
