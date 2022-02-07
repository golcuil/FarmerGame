using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameOverOrNot 
{
    static int health = 3;
    static int point = 0;

    public static void HealthDecrease()
    {
        health--;

        if (health > 0)
        {
            Debug.Log("Health: " + health);
        }

        if (health <= 0)
        {
            Debug.Log("Game Over!");
        }
       
        
    }

    public static void PointIncrease()
    {
        point++;
        Debug.Log("Point: " + point);

        if(point > 19)
        {
            Debug.Log("You Passed the 1st Level");
        }
    }


}
