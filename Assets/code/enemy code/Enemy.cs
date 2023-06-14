using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitPoints = 5;
    public FloatingHealthBar Healthbar;

   

    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitPoints;
        Healthbar.SetHealth(Hitpoints, MaxHitPoints);
    }

  public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        Healthbar.SetHealth(Hitpoints, MaxHitPoints);

        if (Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
