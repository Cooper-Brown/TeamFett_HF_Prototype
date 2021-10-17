using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://answers.unity.com/questions/7555/how-do-i-call-a-function-in-another-gameobjects-sc.html

public class Menu2 : MonoBehaviour
{
   // private GameObject fpgo;
   // private FirstPersonAIO FirstPersonController;

    private GameObject CanvasGO1;
    private Canvas CanvasObject;
    

    // Start is called before the first frame update
    void Start()
    {

        //fpgo = GameObject.Find("FirstPersonAIO");
        CanvasGO1 = GameObject.Find("Canvas2");

        //FirstPersonController = fpgo.GetComponent<FirstPersonAIO>();
        CanvasObject = CanvasGO1.GetComponent<Canvas>();



        CanvasObject.enabled = !CanvasObject.enabled;

        
        //FirstPersonController = GetComponent<FirstPersonAIO>();
        //FirstPersonController.controllerPauseState = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * if (Input.GetButtonDown("Menu"))
        {
            CanvasObject.enabled = !CanvasObject.enabled;
            //FirstPersonController.enableCameraMovement = !(FirstPersonController.enableCameraMovement);
            //FirstPersonController.ControllerPause();
        }
        */
    }


    public void flipDisplay()
    {
        CanvasObject.enabled = !CanvasObject.enabled;
    }
}
