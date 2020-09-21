using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBar : MonoBehaviour
{
    private GameManagerScript GMS;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        GMS = GameObject.Find("Manager").GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GMS.counterDownDone == true)
        {
            gameObject.transform.position += new Vector3(speed, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GMS.counterDownDone == true)
        {
            Debug.Log("Collided !");
            speed = speed * -1;
        }
    }
}
