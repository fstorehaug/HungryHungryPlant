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
    [SerializeField]
    private SpriteSelector spriteSelector;


    public void SetUpPice(CameraControllScript camera, PlantHeadScript headScript, OnOutOfBoundsDelegate callback, Vector3 direction, Vector3 oldDirection)
    {
        spriteSelector.selectSPrite(direction, oldDirection);
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
