using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class PointCollect : MonoBehaviour
{

    //public Text ScoreText;


    void OnTriggerEnter(Collider infoCollider)
    {
        //Debug.Log(infoCollider.tag);
        //if (infoCollider.tag.Equals("MK"))
        //{
        //    GameManager.Score++;
        //}
        //else
        //{
        //    GameManager.Score--;
        //}
        GameManager.Score++;
        Destroy(gameObject);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
