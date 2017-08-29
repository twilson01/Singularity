namespace VRTK.Examples
{
	using UnityEngine;

	public class RayGun : VRTK_InteractableObject
	{
		public GameObject bullet;
		public float bulletSpeed = 1000f;
		private float bulletLife = 5f;
		public Transform shootFrom;
		public override void StartUsing(VRTK_InteractUse usingObject)
		//my code
		public 
		{
			base.StartUsing(usingObject);
			FireBullet();
		}
			

		private void FireBullet()
		{
			Debug.Log ("Shots Fired");
			GameObject bulletClone = Instantiate(bullet, shootFrom.position, shootFrom.rotation) as GameObject;
			bulletClone.SetActive(true);
			Rigidbody rb = bulletClone.GetComponent<Rigidbody>();
			rb.AddForce(shootFrom.transform.forward * bulletSpeed);
			Destroy(bulletClone, bulletLife);
		}
	}
}