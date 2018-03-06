using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public KeyCode up;
    public KeyCode down;
    public float speed;
    float finalspeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(up))
        {
            if (transform.localPosition.y > 4.2)
            {
                finalspeed = 0;
            }
            else
            {
                finalspeed = speed;
            }
            transform.Translate(0, finalspeed, 0);
        }
        if (Input.GetKey(down))
        {
            if (transform.localPosition.y < -4.2)
            {
                finalspeed = 0;
            }
            else
            {
                finalspeed = speed;
            }
            transform.Translate(0, -finalspeed, 0);
        }
    }
}
