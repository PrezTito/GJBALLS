using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    [SerializeField] private GameObject ScoreKeeper;
    public int PlayerGoal;

    void OnTriggerEnter(Collider other)
    {
        if (PlayerGoal == 1)
        {
            ScoreKeeper.SendMessage("AddScoreForPlayer1");
        }
        if (PlayerGoal == 2)
        {
            ScoreKeeper.SendMessage("AddScoreForPlayer2");
        }

        Destroy(other);
    }
}
