using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; // <<<<<< ADD THIS.

public class macedonianplayer : MonoBehaviour
{

    // Use this for initialization
    public void changeToScene(int Level01)
    {
        SceneManager.LoadScene(Level01);

    }
}