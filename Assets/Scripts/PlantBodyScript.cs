using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBodyScript : MonoBehaviour
{
    [SerializeField]
    private PlantHeadScript plantHeadScript;
    [SerializeField]
    private PlantBodyPiceScript plantBodyPicePrefab;
    [SerializeField]
    private CameraControllScript camera;

    Stack<PlantBodyPiceScript> plantBodyPicePool = new Stack<PlantBodyPiceScript>();
    List<PlantBodyPiceScript> activePlantPices = new List<PlantBodyPiceScript>();

    PlantBodyPiceScript piceToAdd;
    int numberOfPices = 0;

    private Vector3 oldDirection = Vector3.up;

    private void Start()
    {
        plantHeadScript.OnPositionChanged += OnHeadPositionChanged;
    }

    private void OnHeadPositionChanged(Vector3 position, Vector3 oldPosition)
    {
        if (IsGameOver())
        {
            Destroy(plantHeadScript.gameObject);
            return;
        }

        if (plantBodyPicePool.Count > 0)
        {
            piceToAdd = plantBodyPicePool.Pop();
            piceToAdd.gameObject.SetActive(true);
        } else
        {
            piceToAdd = Instantiate(plantBodyPicePrefab);
            numberOfPices++;
            piceToAdd.gameObject.name = "PiceNumber: " + numberOfPices.ToString();
        }
        Vector3 direction = position - oldPosition;
        piceToAdd.SetUpPice(camera, plantHeadScript, OnPiceDestroyedCallback, direction, oldDirection);
        oldDirection = direction;
        piceToAdd.transform.position = oldPosition;
        activePlantPices.Add(piceToAdd);
    }

    public void OnPiceDestroyedCallback(PlantBodyPiceScript destroyedPice)
    {
        activePlantPices.Remove(destroyedPice);
        plantBodyPicePool.Push(destroyedPice);
        destroyedPice.gameObject.SetActive(false);
    }

    private bool IsGameOver()
    {
        foreach(PlantBodyPiceScript plantpice in activePlantPices)
        {
            if (plantpice.transform.position == plantHeadScript.transform.position)
                return true;
        }
        return false;
    }

}
