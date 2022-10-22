using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPowerup : MonoBehaviour
{
    public itemPowerup typeOfPowerup;
    public enum itemPowerup { Decrease_Size, Increase_Size, SplitUp, PlayerSpeedIncrease, RainOfBalls, AttackSpeed, TeleportBall }
    [SerializeField]private GameObject player1;
    [SerializeField]private GameObject player2;
    private int playerTagNum;

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player1")
        {
            playerTagNum = 1;
        }

        if (other.tag == "Player2")
        {
            playerTagNum = 2;
        }

        switch(typeOfPowerup)
        {
            case itemPowerup.Decrease_Size :
                GiveDS(playerTagNum);
            break;
            case itemPowerup.Increase_Size :
                GiveIS(playerTagNum);
            break;
            case itemPowerup.SplitUp :
                GiveSU(playerTagNum);
            break;
            case itemPowerup.PlayerSpeedIncrease :
                GivePSI(playerTagNum);
            break;
            case itemPowerup.RainOfBalls :
                GiveROB(playerTagNum);
            break;
            case itemPowerup.AttackSpeed :
                GiveAS(playerTagNum);
            break;
            case itemPowerup.TeleportBall :
                GiveTB(playerTagNum);
            break;
        }

        Destroy(this);
    }


    void GiveDS(int playerNumber)
    {

    }
    void GiveIS(int playerNumber)
    {

    }
    void GiveSU(int playerNumber)
    {

    }
    void GivePSI(int playerNumber)
    {
        
    }
    void GiveROB(int playerNumber)
    {
        
    }
    void GiveAS(int playerNumber)
    {
        
    }
    void GiveTB(int playerNumber)
    {
        
    }
}
