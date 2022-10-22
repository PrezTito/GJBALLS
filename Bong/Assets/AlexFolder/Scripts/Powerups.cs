using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{

    public static Powerups powerupInstance;
    [SerializeField]private List<GameObject> balls;
    [SerializeField]private GameObject ballPrefab;
    [SerializeField]private GameObject player1;
    [SerializeField]private GameObject player2;


    //Make it into a scriptable object?

    void Awake()
    {
        if (powerupInstance != null && powerupInstance != this)
        {
            Destroy(this);
        }
        else
        {
            powerupInstance = this;
        }
    }



    void DecreaseSize()
    {
        //Decrease Size
        for (int i = 0; i < balls.Count; i++)
        {
            balls[i].transform.localScale -= new Vector3(1, 1, 1);
        }
        
    }

    void IncreaseSize()
    {
        //Increase Size
        for (int i = 0; i < balls.Count; i++)
        {
            balls[i].transform.localScale -= new Vector3(1, 1, 1);
        }
    }

    void SplitPowerup()
    {
        for (int i = 0; i < balls.Count; i++)
        {
            balls[i].transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
            Instantiate(ballPrefab, balls[i].transform.position, Quaternion.identity);
        }
        
    }

    void RainOfBalls()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(ballPrefab, transform.position, Quaternion.identity);
        }
        
    }

    void TeleportBall(int player)
    {
        if (player == 1)
        {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].transform.position = new Vector3 (player1.transform.position.x, player1.transform.position.y, balls[i].transform.position.z);
            }
            
        }

        if (player == 2)
        {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].transform.position = new Vector3 (player2.transform.position.x, player2.transform.position.y, balls[i].transform.position.z);
            }
            
        }
        
    }
}
