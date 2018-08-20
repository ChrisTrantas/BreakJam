using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System;

public class BallMovement : MonoBehaviour {

    public float velocityX;
    public float velocityZ;
    private Vector3 velocity;

    System.Random rand = new System.Random();
    private int randomNum;

    public Text playerOneScore;
    public Text playerTwoScore;
    public GameObject BallStart;

	// Use this for initialization
	void Start ()
    {
        velocity.x = rand.Next(-5, 5);
        if (velocity.x == 0)
        {
            velocity.x = rand.Next(-5, 5);
        }

        velocity.z = rand.Next(-5, 5);
        if (velocity.z == 0)
        {
            velocity.z = rand.Next(-5, 5);
        }
    }
	
	// Update is called once per frame
	void Update () {
        // float translationX = Time.deltaTime * velocityX;
        // float translationZ = Time.deltaTime * velocityZ;
        // transform.Translate(translationX, 0, translationZ);   
        transform.Translate(velocity * Time.deltaTime, Space.World);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            velocity = Vector3.Reflect(velocity, -transform.right);
        }

        if (collision.gameObject.tag == "Wall")
        {
            velocity = Vector3.Reflect(velocity, -transform.forward);
        }

        if (collision.gameObject.tag == "Player1Goal")
        {

            string score = playerOneScore.text;
            int newScore = int.Parse(score) + 1;
            playerOneScore.text = newScore.ToString();

            transform.position = BallStart.GetComponent<Transform>().position;
            velocity.x = rand.Next(-5, 5);
            if (velocity.x == 0)
            {
                velocity.x = rand.Next(-5, 5);
            }

            velocity.z = rand.Next(-5, 5);
            if (velocity.z == 0)
            {
                velocity.z = rand.Next(-5, 5);
            }
        }
        if (collision.gameObject.tag == "Player2Goal")
        {

            string score = playerTwoScore.text;
            int newScore = int.Parse(score) + 1;
            playerTwoScore.text = newScore.ToString();
            transform.position = BallStart.GetComponent<Transform>().position;

            velocity.x = rand.Next(-5, 5);
            if(velocity.x == 0)
            {
                velocity.x = rand.Next(-5, 5);
            }

            velocity.z = rand.Next(-5, 5);
            if(velocity.z == 0)
            {
                velocity.z = rand.Next(-5, 5);
            }
        }


    }
}
