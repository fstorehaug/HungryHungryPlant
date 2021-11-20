using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllScript : MonoBehaviour
{
    [SerializeField]
    private PlantHeadScript plantHead;
    [SerializeField]
    private Camera camera;

    private float cameraMoveDistance 
    { 
        get
        {
            return cameraMoveRate / plantHead.movespeed;
        } 
    }

    private float cameraMoveRate = .15f;

    private float deathDistance { get { return camera.orthographicSize; } }


    private void Start()
    {
        plantHead.OnPositionChanged += OnPlantHeadMoved;
        
    }

    public void OnPlantHeadMoved(Vector3 position, Vector3 oldPosition)
    {
        if (position.y < transform.position.y - deathDistance || position.y > transform.position.y + deathDistance)
            Destroy(plantHead.gameObject);
    }

    private void Update()
    {
        transform.position += new Vector3(0f, cameraMoveDistance, 0f) * Time.deltaTime;
    }

}
