using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public int speed = 5;
	
	void Update() {
		Move ();
	}

	void Move() {
		var amtMove = speed * Time.deltaTime;
		var ver = Input.GetAxis("Vertical"); 
		var hor = Input.GetAxis("Horizontal");
		
		transform.Translate (Vector3.right * speed * hor * Time.deltaTime);
		transform.Translate (Vector3.up * speed * ver * Time.deltaTime);

	}
}