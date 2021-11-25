using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField]
    private GameObject StartText;
    [SerializeField]
    private GameObject ResetText;
    [SerializeField]
    private PlantHeadScript plantHead;


    private PlayerControlls inputActions;
    

    // Start is called before the first frame update
    void Start()
    {
        inputActions = new PlayerControlls();
        inputActions.MainMenu.Enable();

        inputActions.MainMenu.MenuInteraction.performed += StartGame;
        plantHead.OnHeadDeath += OnHeadDeath;
        
        Time.timeScale = 0;
    }

    public void StartGame(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        Time.timeScale = 1;
        StartText.SetActive(false);
        inputActions.MainMenu.MenuInteraction.performed -= StartGame;
    }

    public void OnHeadDeath()
    {
        plantHead.OnHeadDeath -= OnHeadDeath;
        ResetText.SetActive(true);
        inputActions.MainMenu.MenuInteraction.performed += RestartGame;
    }

    private void RestartGame(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        inputActions.MainMenu.MenuInteraction.performed -= RestartGame;
        SceneManager.LoadScene(0);
    }

    private void OnDestroy()
    {
        plantHead.OnHeadDeath -= OnHeadDeath;
    }
}
