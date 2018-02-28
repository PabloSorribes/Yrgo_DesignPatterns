using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObjectPool : MonoBehaviour {

	public GameObject bulletPrefab;
	public int maxBullets = 100;

	private LinkedList<GameObject> freeBullets = new LinkedList<GameObject>();

	private void OnDisable()
	{
		foreach (var bullet in freeBullets)
		{
			Destroy(bullet);
		}
		freeBullets.Clear();
	}

	public GameObject CreateBullet()
	{
		if (freeBullets.Count == 0)
		{
			return Instantiate(bulletPrefab);
		}
		else
		{
			var freeBulletNode = freeBullets.First;
			var bullet = freeBulletNode.Value;
			freeBullets.Remove(freeBulletNode);
			bullet.SetActive(true);
			return bullet;
		}
	}

	public void DestroyBullet(GameObject bullet)
	{
		if (freeBullets.Count >= maxBullets)
		{
			Destroy(bullet);
			return;
		}

		bullet.transform.parent = null;
		bullet.SetActive(false);
		freeBullets.AddFirst(bullet);
	}
}
