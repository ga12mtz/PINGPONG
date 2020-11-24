using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public Vector3 InitImpuls;
	public Rigidbody rg;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector3(transform.position.x + InitImpuls.x, transform.position.y , transform.position.z + InitImpuls.z);
		transform.Rotate(InitImpuls.z*50, 0, -InitImpuls.x*50, Space.World);
	}
  //Oncollision Обрабатывает столкновения
	void OnCollisionEnter(Collision col)
    {
		//столкновение с забором
		if (col.gameObject.tag == "Zborder") {
			InitImpuls.z = -InitImpuls.z;
		}
    
    //столкновение с игроками
		if (col.gameObject.tag == "Player")
		{
			InitImpuls.x = -InitImpuls.x;
		}
		
		if (col.gameObject.tag == "Finish")
        {
			transform.position = new Vector3(0, transform.position.y, 0);

		}
	}
}
