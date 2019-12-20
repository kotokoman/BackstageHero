﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public float cameraSpeed = 0.3f;
   
    void FixedUpdate()
    {
        gameObject.transform.Translate(0, 0.1f * cameraSpeed, 0);  // faz a camera subir continuamente
    }
}
