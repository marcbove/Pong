using UnityEngine;
using System.Collections;

public class Scoring : MonoBehaviour {

    public ParticleSystem spark;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision obj)
    {
        if (obj.collider.tag == "Ball")
        {
            spark.Play();
        }
    }
}
