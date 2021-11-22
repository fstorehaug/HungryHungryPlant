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

    public PlantBodyPiceScript nextPice;
    public PlantBodyPiceScript previousPice;


    public void SetUpPice(CameraControllScript camera, PlantHeadScript headScript, OnOutOfBoundsDelegate callback, Vector3 direction, Vector3 oldDirection, PlantBodyPiceScript previousPice)
    {
        spriteSelector.selectSPrite(direction, oldDirection);
        spriteSelector.SetColor(headScript.nutrition);
        this.camera = camera;
        this.headScript = headScript; 
        onOutOfBounds += callback;
        headScript.OnPositionChanged += OnPlayerHeadChanged;
        this.previousPice = previousPice;
    }

    public void OnPlayerHeadChanged(Vector3 p, Vector3 op)
    {
        if (camera.IsOutOfBounds(transform.position))
        {
            headScript.OnPositionChanged -= OnPlayerHeadChanged;
            onOutOfBounds?.Invoke(this);
            onOutOfBounds = null;
            if (nextPice != null) 
                nextPice.previousPice = null;
        }       
    }

    public void StartDestructionCascade()
    {
        StartCoroutine(DestructionEnum());
    }

    private IEnumerator DestructionEnum()
    {
        float timeBetweenPices = .2f;
        float timeToExplode = .5f;

        yield return new WaitForSeconds(timeBetweenPices);
        
        if (previousPice != null)
            previousPice.StartDestructionCascade();

        yield return new WaitForSeconds(timeToExplode);
        Destroy(this.gameObject); 
    }

    private void OnDisable()
    {
        if (nextPice != null)
            nextPice.previousPice = null;

        if (previousPice != null)
            previousPice.nextPice = null;
    }

}
