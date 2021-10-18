using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CameraFading;

public class Table : MonoBehaviour
{
	public FirstPersonAIO FirstPerson;

	private bool glassesAvailable;
	private bool glassesAreOn;

	public GameObject initialPage;


	public GameObject VRGoggles;

	public Canvas mainMenu;

	//private GameObject txGO;
	//private Canvas arHeadsets;

	void Start()
    {
		glassesAvailable = false;
		glassesAreOn = false;

		//txGO = GameObject.Find("ARHeadsetsTextCanvas");
		//arHeadsets = txGO.GetComponent<Canvas>();


	}


	void Update()
    {
		if (glassesAvailable && Input.GetButtonDown("GlassesOn") && !glassesAreOn)
        {
			glassesAvailable = false;
			glassesAreOn = true;
			//arHeadsets.enabled = false;
			//CameraFade.Color = Color.black;

			//Canvas mainMenu = initialPage.GetComponent<Canvas>();
			mainMenu.enabled = false;

			//ControlsMenu.SetActive(true);

			VRGoggles.SetActive(false);

			initialPage.SetActive(true);
			FirstPerson.ControllerPause();



		}
    }

	void OnTriggerEnter(Collider coll)
	{
		if ( (coll.tag == "Player") && (!glassesAreOn) )
		{
			glassesAvailable = true;
		}
	}

	public bool glassesOn()
    {
		return glassesAreOn;
    }
}
