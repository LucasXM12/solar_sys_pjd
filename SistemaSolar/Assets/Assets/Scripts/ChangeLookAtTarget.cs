using UnityEngine;

public class ChangeLookAtTarget: MonoBehaviour {

	public GameObject target;

	void Start() {
		if (target == null)
			target = this.gameObject;
	}

	void OnMouseDown() {
		LookAtTarget.target = target;
		Camera.main.fieldOfView = 60 * target.transform.localScale.x;
	}
}
