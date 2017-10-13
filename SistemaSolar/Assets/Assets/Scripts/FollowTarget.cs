using UnityEngine;

public class FollowTarget: MonoBehaviour {

	static public Vector3 inc;
	static public GameObject target;

	public float step = 5f;
	public float timeStep = 0.5f;

	void Start() {
		inc = Vector3.zero;

		if (target == null)
			target = GameObject.FindGameObjectWithTag("Sun");
	}

	void Update() {
		if (target) {
			inc[0] += this.step / 10 * Input.GetAxis("Horizontal");
			inc[2] += this.step / 10 * Input.GetAxis("Vertical");

			var targetScale = target.transform.lossyScale.x;
			var relativeY = 5 * targetScale;
			var newY = relativeY + inc[1];

			var input = Input.GetAxis("Mouse ScrollWheel");
			if (Input.GetKey(KeyCode.LeftControl)) {
				float mult = input == 0 ? 0 : Mathf.Sign(input);
				Time.timeScale += this.timeStep * mult;
			} else {
				var change = this.step * input;

				if (!(newY - change < relativeY))
					inc[1] -= change;
			}

			var targetPos = target.transform.position;

			transform.position = new Vector3(targetPos.x + inc[0],
				newY, targetPos.z + inc[2]);
		}

		Debug.Log(Time.timeScale);
	}
}
