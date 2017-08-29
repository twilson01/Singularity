using UnityEngine;

public class OrbitPlanet : MonoBehaviour
{

	//public float turnspeed;
	public float orbitspeed;

    void Update()
    {
        // Rotate the object around its local X axis at 1 degree per second
        //transform.Rotate(0, turnspeed * Time.deltaTime, 0);

        // ...also rotate around the World's Y axis
        transform.Rotate(0, orbitspeed * Time.deltaTime, 0, Space.World);
    }
}