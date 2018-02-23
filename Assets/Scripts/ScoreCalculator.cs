using System;
using UnityEngine;
using UnityEngine.Networking.NetworkSystem;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{

    public Transform Player;
    public Text ScoreText;

	
	// Update is called once per frame
	void Update ()
	{
	    ScoreText.text = Convert.ToInt32(Player.position.z).ToString();
	}
}
