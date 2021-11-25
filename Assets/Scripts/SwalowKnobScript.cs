using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwalowKnobScript : MonoBehaviour
{
    private PlantBodyPiceScript target;
    private CameraControllScript cameraControll;
    private PlantHeadScript plantHead;

    private Coroutine coroutine;

    private float speed = 2;

    public void SetTarget(PlantBodyPiceScript target, CameraControllScript camera, PlantHeadScript plantHead)
    {
        transform.position = plantHead.transform.position;
        this.target = target;
        this.plantHead = plantHead;
        this.cameraControll = camera;
        plantHead.OnPositionChanged += OnPlantMove;
    }

    private void OnPlantMove(Vector3 p, Vector3 pp)
    {
        if (cameraControll.IsOutOfBounds(this.transform.position))
        {
            Destroy(this.gameObject); //TODO: theese items can be pooled
            return;
        }

        if (target == null)
            return;

        if (transform.position == target.gameObject.transform.position) 
            target = target.previousPice;

       coroutine = StartCoroutine(moveTowardsEnum());
    }

    private IEnumerator moveTowardsEnum()
    {
        if (target != null)
        {
            while (transform.position != target.transform.position)
            {
                if (target == null) break;

                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
                yield return null;
            }
        }
        yield return null;
    }

    private void OnDestroy()
    {
        if (plantHead != null)
            plantHead.OnPositionChanged -= OnPlantMove;
        
        if (coroutine != null)
            StopCoroutine(coroutine);
    }

}
