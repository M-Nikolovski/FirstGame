using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChanger : MonoBehaviour
{

    private bool speedIncAt5 = false;
    private bool speedIncAt10 = false;
    private bool speedIncAt15 = false;
    private bool speedIncAt20 = false;
    private bool speedIncAt25 = false;
    private bool speedIncAt30 = false;
    private bool speedIncAt35 = false;
    private bool speedIncAt40 = false;
    private bool speedIncAt45 = false;
    private bool speedIncAt50 = false;
    private bool speedIncAt55 = false;
    private bool speedIncAt60 = false;
    private bool speedIncAt65 = false;
    private bool speedIncAt70 = false;
    private bool speedIncAt75 = false;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (GameManager.Score == 5 && !speedIncAt5)
	    {
	        speedIncAt5 = true;
	        FindObjectOfType<PlayerMovement>().frowardForce += 150;
	    }
	    if (GameManager.Score == 10 && !speedIncAt10)
	    {
	        speedIncAt10 = true;
	        FindObjectOfType<PlayerMovement>().frowardForce += 150;
	    }
	    if (GameManager.Score == 15 && !speedIncAt15)
	    {
	        speedIncAt15 = true;
	        FindObjectOfType<PlayerMovement>().frowardForce += 150;
	    }
	    if (GameManager.Score == 20 && !speedIncAt20)
	    {
	        speedIncAt20 = true;
	        FindObjectOfType<PlayerMovement>().frowardForce += 200;
	    }
	    if (GameManager.Score == 25 && !speedIncAt25)
	    {
	        speedIncAt25 = true;
	        FindObjectOfType<PlayerMovement>().frowardForce += 200;
	    }
	    if (GameManager.Score == 30 && !speedIncAt30)
	    {
	        speedIncAt30 = true;
	        FindObjectOfType<PlayerMovement>().frowardForce += 200;
	    }
	    if (GameManager.Score == 35 && !speedIncAt35)
	    {
	        speedIncAt35 = true;
	        FindObjectOfType<PlayerMovement>().frowardForce += 250;
	    }
	    if (GameManager.Score == 40 && !speedIncAt40)
	    {
	        speedIncAt40 = true;
	        FindObjectOfType<PlayerMovement>().frowardForce += 250;
	    }
	    if (GameManager.Score == 45 && !speedIncAt45)
	    {
	        speedIncAt45 = true;
	        FindObjectOfType<PlayerMovement>().frowardForce += 250;
	    }
	    if (GameManager.Score == 50 && !speedIncAt50)
	    {
	        speedIncAt50 = true;
	        FindObjectOfType<PlayerMovement>().frowardForce += 300;
	    }
	    if (GameManager.Score == 55 && !speedIncAt55)
	    {
	        speedIncAt55 = true;
	        FindObjectOfType<PlayerMovement>().frowardForce += 300;
	    }
	    if (GameManager.Score == 60 && !speedIncAt60)
	    {
	        speedIncAt60 = true;
	        FindObjectOfType<PlayerMovement>().frowardForce += 300;
	    }
	    if (GameManager.Score == 65 && !speedIncAt65)
	    {
	        speedIncAt65 = true;
	        FindObjectOfType<PlayerMovement>().frowardForce += 350;
	    }
	    if (GameManager.Score == 70 && !speedIncAt70)
	    {
	        speedIncAt70 = true;
	        FindObjectOfType<PlayerMovement>().frowardForce += 350;
	    }


    }
}
