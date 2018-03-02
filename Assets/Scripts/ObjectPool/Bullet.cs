using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed;
	private BulletObjectPool bulletPool;

	// Use this for initialization
	private void OnEnable()
	{
		float inputX = Input.GetAxisRaw("Horizontal");
		if (inputX == 0)
		{
			inputX = 1f;
		}

		GetComponent<Rigidbody2D>().velocity = inputX * transform.right * speed;

		Invoke("DestroyBullet", 2f);
	}

	private void Start()
	{
		bulletPool = FindObjectOfType<BulletObjectPool>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		DestroyBullet();
	}

	private void DestroyBullet()
	{
		bulletPool.DestroyBullet(gameObject);
	}

	private void OnDisable()
	{
		CancelInvoke("DestroyBullet");
	}
}
