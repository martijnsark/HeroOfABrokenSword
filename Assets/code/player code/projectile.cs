using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed = 4;

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.right * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       var enemy = collision.collider.GetComponent<Enemy>();
        if (enemy)
        {
            enemy.TakeHit(1);
        }

        Destroy(gameObject);
    }
}
