using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdibleScript : MonoBehaviour
{
    [SerializeField]
    private PlantHeadScript plantHead;
    
    public int nutrition = 1;

    private void OnEnable()
    {
        plantHead.OnPositionChanged += OnPlantheadPosisionChanged;
    }

    private void OnDisable()
    {
        plantHead.OnPositionChanged -= OnPlantheadPosisionChanged;
    }

    public void OnPlantheadPosisionChanged(Vector3 position, Vector3 oldPosition)
    {
        if (plantHead.transform.position == transform.position)
            plantHead.EatEdible(this);
    }

}
