using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		int rand = Random.Range (0, 6);
		if (rand < 3) {
			transform.Rotate (new Vector3 (15, 30, 45)*Time.deltaTime);
		} else if (rand >= 3) {
			transform.Rotate (new Vector3 (45, 30, 15)*Time.deltaTime);
		}

	}
}
