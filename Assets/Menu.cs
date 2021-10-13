using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://answers.unity.com/questions/7555/how-do-i-call-a-function-in-another-gameobjects-sc.html

public class Menu : MonoBehaviour
{
    private GameObject fpgo;
    private Canvas CanvasObject;
    public FirstPersonAIO FirstPersonController;

    // Start is called before the first frame update
    void Start()
    {

        //fpgo = GameObject.Find("FirstPersonAIO");

        CanvasObject = GetComponent<Canvas>();
        CanvasObject.enabled = !CanvasObject.enabled;

        //FirstPersonController = fpgo.GetComponent<FirstPersonAIO>();
        //FirstPersonController = GetComponent<FirstPersonAIO>();
        //FirstPersonController.controllerPauseState = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Menu"))
        {
            CanvasObject.enabled = !CanvasObject.enabled;
            //FirstPersonController.enableCameraMovement = !(FirstPersonController.enableCameraMovement);
            FirstPersonController.ControllerPause();
        }
    }
}
