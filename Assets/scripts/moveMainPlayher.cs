using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMainPlayher : MonoBehaviour {

	public AudioClip destructiveSound;

	public GameObject audiObject;

	private AudioSource audioSourceMain;

	public GameObject explosion;

	public float speed;
	private Vector3 positionCar;

	// Use this for initialization
	void Start () {
		audioSourceMain = audiObject.GetComponent<AudioSource>();
	}



	IEnumerator delayForExplosion()
	{
		
		Instantiate (explosion, transform.position, transform.rotation);


		yield return new WaitForSeconds(1);


		Destroy (this.gameObject);
		Application.LoadLevel ("GUI_Scene");

	}


	void OnTriggerEnter2D(Collider2D col)
	{
		

		if(col.gameObject.tag == "enemy")
		{

			audioSourceMain.PlayOneShot (destructiveSound,1f);




			Instantiate (explosion, col.gameObject.transform.position, col.gameObject.transform.rotation);
			Destroy (col.gameObject);



			StartCoroutine(delayForExplosion());


		}
	}



	// Update is called once per frame
	void FixedUpdate () {
		
		positionCar = transform.position;

		if(Input.GetKey(KeyCode.D) && (positionCar.x <= 1.80f)){
			transform.Translate(Vector3.right * Time.deltaTime*speed);
		}

		if(Input.GetKey(KeyCode.A) && (positionCar.x >= -1.80f)){
			transform.Translate(Vector3.left * Time.deltaTime*speed);
		}
	}
}
