﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    private void Awake()
    {
        if(instance == null){

            instance = this;
            DontDestroyOnLoad(this.gameObject);

        } else
        {
            Destroy(this);
        }
    }

    #region oldLerp

    public CameraConfiguration configA;
    public CameraConfiguration configB;

    [Range(0, 360)]
    private float yaw;

    [Range(-90, 90)]
    private float pitch;

    [Range(-180, 180)]
    private float roll;

    private Vector3 pivot;

    private float distance;

    /*
    [Space(1)]
    [Header("Lerp")]
    public bool useLerpValue = true;

    [Range(0,1)]
    public float lerpPotencial = 0f;

    public float lerpSpeed = 0f;
    private bool positif = true;

    // Update is called once per frame
    void Update()
    {
        if (positif)
        {
            if (lerpPotencial>1)
            {
                positif = !positif;
            }
            lerpPotencial += lerpSpeed * Time.deltaTime;
        }
        else
        {
            if (lerpPotencial < 0)
            {
                positif = !positif;
            }
            lerpPotencial -= lerpSpeed * Time.deltaTime;
        }

        if (useLerpValue)
        {
            yaw = Mathf.Lerp(configA.yaw, configB.yaw, lerpPotencial);
            pitch = Mathf.Lerp(configA.pitch, configB.pitch, lerpPotencial);
            roll = Mathf.Lerp(configA.roll, configB.roll, lerpPotencial);
            pivot = Vector3.Lerp(configA.pivot, configB.pivot, lerpPotencial);
            distance = Mathf.Lerp(configA.distance, configB.distance, lerpPotencial);
            fov = Mathf.Lerp(configA.fov, configB.fov, lerpPotencial);
        }

        Quaternion orientation = Quaternion.Euler(pitch, yaw, roll);
        transform.rotation = orientation;
        Vector3 offset = orientation * (Vector3.back * distance);
        transform.position = pivot + offset;
    }
    */

    #endregion

    private List<AView> activeViews = new List<AView>();

    public void AddView(AView view)
    {
        activeViews.Add(view);
    }

    public void RemoveView(AView view)
    {
        activeViews.Remove(view);
    }
}
