using UnityEngine;

public class ChangeLookAtTarget: MonoBehaviour {

	public int id;
	public GameObject target;

	void Start() {
		if (target == null)
			target = this.gameObject;
	}

	void OnMouseDown() {
		MusicCtrl.musicNum = this.id;

		FollowTarget.target = this.gameObject;
		FollowTarget.inc = Vector3.zero;
	}
}
