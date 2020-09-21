using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCountdown : MonoBehaviour
{
    private GameManagerScript GMS;

    public void SetCountDownNow()
    {
        GMS = GameObject.Find("Manager").GetComponent<GameManagerScript>();
        GMS.counterDownDone = true;
    }
}
