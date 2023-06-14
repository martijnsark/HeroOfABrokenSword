using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

	// Update is called once per frame
	void Update()
	{
		if (currentHealth <= 0)
		{
			SceneManager.LoadScene("deathScene");
		}
	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.gameObject.CompareTag("Enemy1"))
		{
			TakeDamage(20);
		}
	}


	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
}
