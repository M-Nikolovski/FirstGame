using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody Rb;
    public Transform Player;

    public float frowardForce = 1000f;
    public float sidewaysForce = 500f;

    // Use this for initialization
    void Start()
    { 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.AddForce(0, 0, frowardForce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            Rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Player.position.y < 0f)
        {
            FindObjectOfType<ScoreCalculator>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
