using UnityEngine;

public class RotateAround: MonoBehaviour {

	public Transform target; // the object to rotate around
	public float speed; // the speed of rotation

	void Start() {
		if (target == null)
			target = this.gameObject.transform;
	}

	void Update() {
		transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
	}
}
