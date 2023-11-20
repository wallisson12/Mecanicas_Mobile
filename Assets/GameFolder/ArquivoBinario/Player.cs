using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 1;
    public int health = 100;
    public Vector3 position;

    public void SaveP()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadP()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        if (data != null)
        {
            level = data.level;
            health = data.health;

            position.x = data.position[0];
            position.y = data.position[1];
            position.z = data.position[2];
        }
    }
}
