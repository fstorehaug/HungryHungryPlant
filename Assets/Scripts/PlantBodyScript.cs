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
    [SerializeField]
    private SwalowKnobScript swalowKnopPrefab;

    Stack<PlantBodyPiceScript> plantBodyPicePool = new Stack<PlantBodyPiceScript>();
    List<PlantBodyPiceScript> activePlantPices = new List<PlantBodyPiceScript>();

    PlantBodyPiceScript piceToAdd;
    PlantBodyPiceScript previousPiceToAdd;
    int numberOfPices = 0;

    private Vector3 oldDirection = Vector3.up;

    private void Start()
    {
        plantHeadScript.OnPositionChanged += OnHeadPositionChanged;
        plantHeadScript.OnHeadDeath += OnHeadDead;
        plantHeadScript.OnEat += OnHeadEat;
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
        piceToAdd.SetUpPice(camera, plantHeadScript, OnPiceDestroyedCallback, direction, oldDirection, previousPiceToAdd);
        oldDirection = direction;
        piceToAdd.transform.position = oldPosition;
        activePlantPices.Add(piceToAdd);
        previousPiceToAdd = piceToAdd;
    }

    public void OnPiceDestroyedCallback(PlantBodyPiceScript destroyedPice)
    {
        activePlantPices.Remove(destroyedPice);
        plantBodyPicePool.Push(destroyedPice);
        destroyedPice.gameObject.SetActive(false);
    }

    public void OnHeadDead()
    {
        previousPiceToAdd.StartDestructionCascade();
    }

    public void OnHeadEat()
    {
        SwalowKnobScript swalow = Instantiate(swalowKnopPrefab); //TODO pool this
        swalow.SetTarget(activePlantPices[activePlantPices.Count - 1], camera, plantHeadScript);
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
