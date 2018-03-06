using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Bola : MonoBehaviour {

    public ParticleSystem spark;
    //public ParticleSystem spark_goal;

    int directionX;
    int directionY;

    float speed;
    //Puntuacion
    public Text score;
    public Text winner;

    int p1score;
    int p2score;

	// Use this for initialization
	void Start () {
        p1score = 0;
        p2score = 0;
        MoveBall();
    }
	
	// Update is called once per frame
	void Update () {
        score.text = p1score.ToString() + " - " + p2score.ToString();

        if(p1score==7)
        {
            winner.text = "PLAYER 1 WINS";
            winner.gameObject.SetActive(true);
            ResetBall();
        }
        if(p2score==7)
        {
            winner.text = "PLAYER 2 WINS";
            winner.gameObject.SetActive(true);
            ResetBall();
        }
	}

    void ResetBall()
    {
        transform.localPosition = new Vector3(0, 0, 10);
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    void MoveBall()
    {
        speed = 10;
        directionX = Random.Range(0, 2);
        if (directionX == 0)
        {
            directionX = 1;
        }
        else
        {
            directionX = -1;
        }
        directionY = Random.Range(0, 2);
        if (directionY == 0)
        {
            directionY = 1;
        }
        else
        {
            directionY = -1;
        }
        GetComponent<Rigidbody>().velocity = new Vector3(speed * directionX, speed * directionY, 0);
    }

    void OnCollisionEnter(Collision obj){
        if(obj.collider.tag=="P1goal")
        {
            p1score++;
            ResetBall();
            Invoke("MoveBall",2);
        }
        if(obj.collider.tag=="P2goal")
        {
            p2score++;
            ResetBall();
            Invoke("MoveBall", 2);
        }
        if (obj.collider.tag == "Player")
        {
            spark.Play();
        }
       /* if (obj.collider.tag == "P1goal" || obj.collider.tag == "P2goal")
        {
            //spark_goal.Play();
        }*/
    }
}
