using UnityEngine;

public class CollectingPoints : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        Destroy(gameObject);
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
