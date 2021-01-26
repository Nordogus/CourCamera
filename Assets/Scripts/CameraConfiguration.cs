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

    public Quaternion GetRotation()
    {
        return Quaternion.Euler(pitch, yaw, roll);
    }

    public Vector3 GetPosition()
    {
        Vector3 offset = GetRotation() * (Vector3.back * distance);
        return pivot + offset;
    }

    public void DrawGizmos(Color color)
    {
        Gizmos.color = color;
        Gizmos.DrawSphere(pivot, 0.25f);
        Vector3 position = GetPosition();
        Gizmos.DrawLine(pivot, position);
        Gizmos.matrix = Matrix4x4.TRS(position, GetRotation(), Vector3.one);
        Gizmos.DrawFrustum(Vector3.zero, fov, 0.5f, 0f, Camera.main.aspect);
        Gizmos.matrix = Matrix4x4.identity;
    }
}
