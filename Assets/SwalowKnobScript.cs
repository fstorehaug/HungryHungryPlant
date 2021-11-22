using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwalowKnobScript : MonoBehaviour
{
    private PlantBodyPiceScript target;
    private CameraControllScript cameraControll;

    private float speed = 2;

    public void SetTarget(PlantBodyPiceScript target, CameraControllScript camera, PlantHeadScript plantHead)
    {
        this.target = target;

        plantHead.OnPositionChanged += OnPlantMove;
    }

    private void OnPlantMove(Vector3 p, Vector3 pp)
    {
        if (cameraControll.IsOutOfBounds(this.transform.position))
            Destroy(this.gameObject); //TODO: theese items can be pooled

        if (target == null)
            return;

        if (transform.position == target.gameObject.transform.position) 
            target = target.nextPice;

        StartCoroutine(moveTowardsEnum());
    }

    private IEnumerator moveTowardsEnum()
    {
        while (transform.position != target.transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
            yield return null;
        }
    }


}
