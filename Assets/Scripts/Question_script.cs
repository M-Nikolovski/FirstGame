using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question_script : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public AnimationCurve myCurve;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), transform.position.z);
        
    }



}
