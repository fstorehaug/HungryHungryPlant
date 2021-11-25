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

    [SerializeField]
    private float cameraMoveRate = .2f;

    private float deathDistance { get { return camera.orthographicSize + 0.5f; } }


    private void Start()
    {
        plantHead.OnPositionChanged += OnPlantHeadMoved;
        plantHead.OnHeadDeath += OnHeadDead;
        
    }

    public void OnHeadDead()
    {
        plantHead.OnHeadDeath -= OnHeadDead;
        cameraMoveRate = 0f;
    }

    public void OnPlantHeadMoved(Vector3 position, Vector3 oldPosition)
    {
        if (IsOutOfBounds(position))
            Destroy(plantHead.gameObject);
    }

    public bool IsOutOfBounds(Vector3 position)
    {
        return position.y < transform.position.y - deathDistance || position.y > transform.position.y + deathDistance;
    }

    private void Update()
    {
        transform.position += new Vector3(0f, cameraMoveDistance, 0f) * Time.deltaTime;
    }

    private void OnDestroy()
    {
        plantHead.OnHeadDeath -= OnHeadDead;
    }

}
