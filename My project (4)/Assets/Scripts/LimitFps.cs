using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitFps : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Makes the game have a capped framerate of 60
        // This is for computers that get more than 60 fps because it will make the movement of player way to fast
        Application.targetFrameRate = 60;
    }

}
