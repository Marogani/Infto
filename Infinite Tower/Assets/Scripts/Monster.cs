using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
	public Transform target;
	public float enemySpeed = 2;

	void Start () {
		///target = GameObject.Find("player").transform;
	}
	
	void Update () {
		Move();
	}
	
	void Move () {
		/*Vector3 targetDirection = target.position - transform.position;
		transform.position += targetDirection * enemySpeed * Time.deltaTime;*/
	}
	void OnTriggerStay2D(Collider2D other){
			Vector3 targetDirection = target.position - transform.position;
			transform.position += targetDirection * enemySpeed * Time.deltaTime;
	}
}
