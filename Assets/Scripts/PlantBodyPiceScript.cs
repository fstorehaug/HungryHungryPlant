using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlantBodyPiceScript : MonoBehaviour
{

    private CameraControllScript camera;
    private PlantHeadScript headScript;
    public delegate void OnOutOfBoundsDelegate(PlantBodyPiceScript pice);
    public event OnOutOfBoundsDelegate onOutOfBounds;


    public void SetUpPice(CameraControllScript camera, PlantHeadScript headScript, OnOutOfBoundsDelegate callback)
    {
        this.camera = camera;
        this.headScript = headScript; 
        onOutOfBounds += callback;
        headScript.OnPositionChanged += OnPlayerHeadChanged;
    }

    public void OnPlayerHeadChanged(Vector3 p, Vector3 op)
    {
        if (camera.IsOutOfBounds(transform.position))
        {
            headScript.OnPositionChanged -= OnPlayerHeadChanged;
            onOutOfBounds?.Invoke(this);
            onOutOfBounds = null;
        }       
    }
}
