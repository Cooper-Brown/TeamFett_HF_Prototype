using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuProper : MonoBehaviour
{
    public FirstPersonAIO FirstPerson;
    private Canvas CanvasObject;

    public enum MenuStates { Main, Assistance, Navigation, Settings };
    private GameObject currentState;


    public GameObject mainMenu;
    public GameObject assistanceMenu;
    public GameObject navigationMenu;
    public GameObject settingsMenu;

    public GameObject VRTableGO;
    //public Table VRTable;

    void Start()
    {
        //VRTableGO = GameObject.Find("World/Props/VRTable");

        //VRTable = VRTableGO.getComponent(typeof(VRTable));

        CanvasObject = GetComponent<Canvas>();
        CanvasObject.enabled = !CanvasObject.enabled;
        currentState = mainMenu;


    }

    void Update()
    {
        if (Input.GetButtonDown("Menu")) // testing VR table compatibility
        {
            CanvasObject.enabled = !CanvasObject.enabled;
            FirstPerson.ControllerPause();
        }
    }

    private void switchMenu(MenuStates menu)
    {
        GameObject newState;

        switch(menu)
        {
            case MenuStates.Main:
                newState = mainMenu;
                break;
            case MenuStates.Assistance:
                newState = assistanceMenu;
                break;
            case MenuStates.Navigation:
                newState = navigationMenu;
                break;
            case MenuStates.Settings:
                newState = settingsMenu;
                break;
            default:
                newState = mainMenu;
                break;
        }

        currentState.SetActive(false);
        currentState = newState;
        currentState.SetActive(true);

    }

    public void OnAssistance()
    {
        switchMenu(MenuStates.Assistance);
    }

    public void OnNavigation()
    {
        switchMenu(MenuStates.Navigation);
    }

    public void OnSystemSettings()
    {
        switchMenu(MenuStates.Settings);
    }

    public void OnExitMenu()
    {
        CanvasObject.enabled = !CanvasObject.enabled;
        FirstPerson.ControllerPause();
    }

    public void onBackToMainMenu()
    {
        switchMenu(MenuStates.Main);
    }
}