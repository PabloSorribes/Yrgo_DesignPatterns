using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	private BulletObjectPool bulletPool;

	private void Start()
	{
		bulletPool = FindObjectOfType<BulletObjectPool>();
	}

	// Update is called once per frame
	private void Update()
	{
		ShootInput();
	}

	private void ShootInput()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			var newBullet = bulletPool.CreateBullet();
			newBullet.transform.position = transform.position;

			if (Input.GetAxisRaw("Horizontal") < 0)
			{
				//newBullet.transform.SetPositionAndRotation(this.transform.rotation, Quaternion.EulerRotation();
			}
		}
	}
}
