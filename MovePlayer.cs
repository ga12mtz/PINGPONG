using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
	//enum для упрощения кода(в редакторе юнити выбераем на каком обьекте весит скрипт на игроке или на Боте)
  //
  public enum WhoPlays
    {
		player,
		bot
    }
	public Transform ball;
	public WhoPlays player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (player == WhoPlays.player)
        {
			var a = Input.GetAxis("Vertical");
			if ((transform.position.z > -7 && a < 0) || (transform.position.z < 7 && a > 0))
			{
				transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + a/4);
			}
        }
        else
        {
			transform.position = new Vector3(transform.position.x, transform.position.y, ball.position.z);

		}
		
		
	}
}
