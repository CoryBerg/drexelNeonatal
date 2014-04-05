using UnityEngine;
using System.Collections;

public class ZoomOnLocation : MonoBehaviour {

	public float tmp;
	public float speed;

	Vector3 startPos;
	Vector3 startRot;

	bool zoomed = false;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
		startRot = transform.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		Debug.DrawLine (ray.origin, ray.direction*tmp);

		if(!zoomed) {
			if(Physics.Raycast (ray.origin, ray.direction*tmp, out hit)) {
				if(hit.collider.gameObject.collider.tag == "zoom") {
					Debug.Log("Hit zoom");

					if(Input.GetKey(KeyCode.Mouse0)) {
						Vector3 point1 = hit.point;
						Vector3 point2 = Camera.main.transform.position;
						Vector3 point3 = Input.mousePosition;

						Vector3 side1 = point2 - point1;
						Vector3 side2 = point3 - point1;

						Vector3 moveTo = Vector3.Cross(side1, side2);
						moveTo.Normalize();

						Camera.main.transform.position = -moveTo;
						Camera.main.transform.LookAt(point1);

						zoomed = true;
					}
				}
			}
		}
		else if(Input.GetKey(KeyCode.Escape)) {
			Camera.main.transform.position = startPos;
			Camera.main.transform.eulerAngles = startRot;

			zoomed = false;
		}
	}
}
