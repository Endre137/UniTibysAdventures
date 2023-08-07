using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    private Transform cameraTransform;

    private void Start()
    {
        // Find the main camera in the scene
        Camera mainCamera = Camera.main;
        if (mainCamera != null)
            cameraTransform = mainCamera.transform;
    }


}

