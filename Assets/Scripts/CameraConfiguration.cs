﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConfiguration : MonoBehaviour
{
    [Range(0, 360)]
    public float yaw = 0f;

    [Range(-90, 90)]
    public float pitch = 0f;

    [Range(-180, 180)]
    public float roll = 0f;

    public Vector3 pivot;

    public float distance;

    [Range(1,179)]
    public float fov = 60;
}
