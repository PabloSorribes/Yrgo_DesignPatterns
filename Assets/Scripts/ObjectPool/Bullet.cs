using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed;
	private BulletObjectPool bulletPool;

	private void Start()
	{
		bulletPool = FindObjectOfType<BulletObjectPool>();
	}

	// Use this for initialization
	void OnEnable () {
		GetComponent<Rigidbody2D>().velocity = transform.up * speed;
		Invoke("DestroyBullet", 2);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		DestroyBullet();
	}

	private void DestroyBullet()
	{
		CancelInvoke("DestroyBullet");
		bulletPool.DestroyBullet(gameObject);
	}

}
