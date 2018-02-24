using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetMouseButtonDown(0))
	    {
	        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	        RaycastHit hit;

	        if (Physics.Raycast(ray, out hit))
	        {
	            if (hit.transform.name.ToLower().Equals("macedonia"))
	            {
	                SceneManager.LoadScene("MacedoniaPlayground");
	            }
	            else if (hit.transform.name.ToLower().Equals("germany"))
	            {
	                SceneManager.LoadScene("GermanyPlayground");
	            }
	            else if (hit.transform.name.ToLower().Equals("china"))
	            {
	                SceneManager.LoadScene("ChinaPlayground");
	            }
            }

        }

	    


	}
}
