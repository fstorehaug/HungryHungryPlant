using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlantHeadScript : MonoBehaviour
{
    PlayerControlls inputActions;

    [SerializeField]
    private float stepTime = .4f;
    private float timeSinceStep = 0f;

    public float movespeed = 1f;
    Vector3 lastDirection = Vector3.zero;
    Vector3 inputVector = new Vector3(0f, 1f, 0f);

    public UnityAction<Vector3, Vector3> OnPositionChanged;

    private void Start()
    {
        inputActions = new PlayerControlls();
        inputActions.Enable();
        inputActions.PlayerHead.UpAction.started += UpAction_started;
        inputActions.PlayerHead.DownAction.started += DownAction_started;
        inputActions.PlayerHead.RightAction.started += RightAction_started;
        inputActions.PlayerHead.LeftAction.started += LeftAction_started;
    }

    private void LeftAction_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        inputVector = new Vector3(-movespeed, 0f, 0f);
    }

    private void RightAction_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        inputVector = new Vector3(movespeed, 0f, 0f);
    }

    private void DownAction_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        inputVector = new Vector3(0f, -movespeed, 0f);
    }

    private void UpAction_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        inputVector = new Vector3(0f, movespeed, 0f);
    }

    private void Update()
    {
        if (timeSinceStep < stepTime)
        {
            timeSinceStep += Time.deltaTime;
            return;
        }

        timeSinceStep = 0;

        if (inputVector == -lastDirection) 
        {
            inputVector = lastDirection;
        }

        transform.position += inputVector;
        lastDirection = inputVector;

        OnPositionChanged?.Invoke(transform.position, transform.position - lastDirection);
    }
}
