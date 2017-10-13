using UnityEngine;

public class RotateAround: MonoBehaviour {

	public float speed;
	public Transform target;

	void Start() {
		if (target == null)
			target = this.gameObject.transform;
	}

	void Update() {
		transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
	}
}
