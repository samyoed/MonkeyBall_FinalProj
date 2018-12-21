using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textWobble : MonoBehaviour {

	public float minSize = 0f, maxSize = 0f;
	public bool growing = false;
	public float mult = 0f;

	void Update ()	{
		if (growing) {
			this.GetComponent<RectTransform>().localScale *= (Time.deltaTime * mult) + 1f;

			if (this.GetComponent<RectTransform>().localScale.magnitude > maxSize) {
				growing = false;
			}
		}
		if (!growing) {
			this.GetComponent<RectTransform>().localScale /= (Time.deltaTime * mult) + 1f;

			if (this.GetComponent<RectTransform>().localScale.magnitude < minSize) {
				growing = true;
			}
		}
	}
}
