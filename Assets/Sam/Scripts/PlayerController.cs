using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public float horizDegrees = 0;
	public float vertDegrees = 0;
	
	public int bananaCount = 0;

	private float vertAccelI = 0;
	public float vertMax = 0;
	private float horizAccelI = 0;
	public float horizMax = 0;

	private Rigidbody thisRB;
	public GameObject camTarget;
	private float yAngleDir = 0;

	private bool fading = false;
	public Graphic screenFadeRect;
	private float fadeAlpha = 0f;
	
	// Use this for initialization
	void Start ()
	{
		thisRB = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (thisRB.velocity.magnitude > 1.5)	//Player yRotation becomes automatic once moving for easier control
		{
			SetYRotation();
			
			if (Input.GetAxis("Horizontal") != 0 && Mathf.Abs(horizAccelI) < horizMax)
			{
				horizAccelI += Input.GetAxis("Horizontal") * Time.deltaTime * 13;
			}
			else horizAccelI = Mathf.MoveTowards(horizAccelI, 0, Time.deltaTime * 7);	
		}

		else 	//While stationary player lookRotation is directly controlled (less snappy, better for looking around)
		{
			yAngleDir += Input.GetAxis("Horizontal") * Time.deltaTime * 115;
		}
		
		//*****BELOW IS MANUAL ACCELRATION ON KEY INPUT
		if (Input.GetAxis("Vertical") != 0 && Mathf.Abs(vertAccelI) < vertMax)
		{
			vertAccelI += Input.GetAxis("Vertical") * Time.deltaTime * 13;
		}
		else vertAccelI = Mathf.MoveTowards(vertAccelI, 0, Time.deltaTime * 7);
	
		
		//*********************************************
		
		transform.eulerAngles = new Vector3(-vertAccelI, yAngleDir, horizAccelI);

		if (fading)
		{
			screenFadeRect.color = new Color(255, 255, 255, fadeAlpha);
			fadeAlpha += Time.deltaTime * .8f;
		}
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Banana")
		{
			Destroy(other.gameObject);
			bananaCount++;
		}
		
		else if (other.gameObject.tag == "KillPlane")
		{
			StartCoroutine(playerLose());
			Debug.Log("killPlane");
		}
	}

	private void SetYRotation()		//Determines direction facing of yRot and adjusts appropriately
	{
		float xVelo = thisRB.velocity.x;
		float zVelo = thisRB.velocity.z;

		if (zVelo != 0)		//Avoid NaN Errors
		{
			float currentVeloDir = (Mathf.Atan(xVelo / zVelo) * Mathf.Rad2Deg) - 90f;

			if (zVelo > 0)
			{
				currentVeloDir = Mathf.Abs(currentVeloDir);
			}

			else
			{
				currentVeloDir = (Mathf.Atan(-xVelo / zVelo) * Mathf.Rad2Deg) - 90f;
			}
				//Debug.Log("angle = " + currentVeloDir);

			yAngleDir = -currentVeloDir + 90;
			camTarget.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, yAngleDir, this.transform.eulerAngles.z);
			
			/*this.transform.eulerAngles = Vector3.MoveTowards(
					this.transform.eulerAngles,
					new Vector3(this.transform.eulerAngles.x, currentVeloDir, this.transform.eulerAngles.z), 
					Time.deltaTime * 18
				);*/
		}
	}
	
	IEnumerator playerLose()
	{
		thisRB.drag += 10;
		yield return new WaitForSeconds(.5f);
		fading = true;
		Debug.Log("beginFadeOut");
		yield return new WaitForSeconds(2f);
		SceneManager.LoadScene("Player");
	}
}
