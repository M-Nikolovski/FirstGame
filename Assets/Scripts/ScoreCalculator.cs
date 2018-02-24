using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{

    public Transform Player;
    public Text ScoreText;

	
	// Update is called once per frame
	void Update ()
	{
	    ScoreText.text = GameManager.Score.ToString();
	}
}
