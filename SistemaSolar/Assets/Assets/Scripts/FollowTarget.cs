using UnityEngine;

public class FollowTarget: MonoBehaviour {

	static public Vector3 inc;
	static public GameObject target;

	public float step = 5f;

	void Start() {
		inc = Vector3.zero;

		if (target == null)
			target = GameObject.FindGameObjectWithTag("Sun");
	}

	void Update() {
		if (target) {
			inc[0] += this.step / 10 * Input.GetAxis("Horizontal");

			var change = this.step * Input.GetAxis("Mouse ScrollWheel");
			var targetScale = target.transform.lossyScale.x;

			var relativeY = 5 * targetScale;
			var newY = relativeY + inc[1];

			if (!(newY - change < relativeY))
				inc[1] -= change;

			inc[2] += this.step / 10 * Input.GetAxis("Vertical");

			var targetPos = target.transform.position;

			transform.position = new Vector3(targetPos.x + inc[0],
				newY, targetPos.z + inc[2]);
		}
	}
}
