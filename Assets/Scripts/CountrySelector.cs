using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Button = UnityEngine.Experimental.UIElements.Button;

public class CountrySelector : MonoBehaviour
{
    private GameObject Macedonia;
    private GameObject Germany;
    private GameObject China;

	// Use this for initialization
	void Start () {
	    Macedonia = GameObject.Find("MacedoniaPlayground");
        Germany = GameObject.Find("GermanyPlayground");
        China = GameObject.Find("ChinaPlayground");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonClick(Button button)
    {
        if (button.name == "Macedonia")
        {
            SceneManager.LoadScene("MacedoniaPlayground");
        }
    }
}
