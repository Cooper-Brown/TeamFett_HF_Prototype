using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu3 : MonoBehaviour
{
    public FirstPersonAIO FirstPerson;
    private Canvas CanvasObject;

    public enum MenuStates { Main, Assistance, Navigation, Settings, PopularExhibits };
    private GameObject currentState;


    public GameObject mainMenu;
    public GameObject assistanceMenu;
    public GameObject navigationMenu;
    public GameObject settingsMenu;
    public GameObject popularExhibitsMenu;

    public GameObject guidanceSystem;
    public GameObject frameSystem;
    public GameObject VRTableGO;

    private Table VRTable;

    private bool menuActive;

    void Start()
    {
        CanvasObject = GetComponent<Canvas>();
        CanvasObject.enabled = !CanvasObject.enabled;
        currentState = mainMenu;
        menuActive = true;
        //currentState.SetActive(false);
        VRTable = VRTableGO.GetComponent<Table>();
        
        guidanceSystem.SetActive(false);
        frameSystem.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Menu") && VRTable.glassesOn() && !menuActive)
        {
            menuActive = true;
            OnBackToMainMenu();
            CanvasObject.enabled = true;
            //menuActive = !menuActive;
            //mainMenu.SetActive(menuActive);
            FirstPerson.ControllerPause();
            
        }

        if (Input.GetButtonDown("AirTap") && menuActive)
        {
            OnBackToMainMenu();
            CanvasObject.enabled = false;
            FirstPerson.ControllerPause();
            menuActive = false;
        }

        if (Input.GetButtonDown("FreeLook"))
        {
            FirstPerson.ControllerPause();
        }

        if (Input.GetButtonUp("FreeLook"))
        {
            FirstPerson.ControllerPause();
        }
    }

    private void switchMenu(MenuStates menu)
    {
        GameObject newState;

        switch (menu)
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
            case MenuStates.PopularExhibits:
                newState = popularExhibitsMenu;
                break;
            default:
                newState = mainMenu;
                break;
        }

        if (currentState != mainMenu)
        {
            currentState.SetActive(false);
        }
        else
        {
            CanvasObject.enabled = false;
        }
        
        currentState = newState;

        if (currentState != mainMenu)
        {
            currentState.SetActive(true);
        }
        else
        {
            CanvasObject.enabled = true;
        }

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
        //mainMenu.SetActive(false);
        FirstPerson.ControllerPause();
    }

    public void OnBackToMainMenu()
    {
        switchMenu(MenuStates.Main);
    }

    public void OnPopularExhibits()
    {
        switchMenu(MenuStates.PopularExhibits);
    }

    public void OnBackToNavMenu()
    {
        switchMenu(MenuStates.Navigation);
    }

    public void OnCoronaLisa()
    {
        guidanceSystem.SetActive(true);
        frameSystem.SetActive(true);
        switchMenu(MenuStates.Main);
        CanvasObject.enabled = !CanvasObject.enabled;
        FirstPerson.ControllerPause();
    }
}