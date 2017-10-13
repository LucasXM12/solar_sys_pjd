using UnityEngine;

public class ChangeLookAtTarget: MonoBehaviour {

	public GameObject target;

	void Start() {
		if (target == null)
			target = this.gameObject;
	}

	void OnMouseDown() {
		FollowTarget.target = this.gameObject;
		FollowTarget.inc = Vector3.zero;
	}
}
