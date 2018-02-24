using UnityEngine;
using UnityEngine.UI;

public class PointCollect : MonoBehaviour
{

    //public Text ScoreText;


    void OnTriggerEnter(Collider infoCollider)
    {
        GameManager.Score++;
        Destroy(gameObject);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
