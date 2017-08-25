using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGenerator : MonoBehaviour {

	public GameObject enemyGeneratorObj;

	public GameObject[] enemyCars;




	void OnTriggerEnter2D(Collider2D col)
	{
		
		if(col.gameObject.tag == "enemy")
		{

			Vector3 carPos = new Vector3(Random.Range(-1.2f, 1.8f), enemyGeneratorObj.transform.position.y, enemyGeneratorObj.transform.position.z);
			int carNumber = Random.Range(0,5);
			GameObject enemyCarObjInstance =  Instantiate(enemyCars[carNumber], carPos, enemyGeneratorObj.transform.rotation) as GameObject;


			enemyCarObjInstance.transform.Rotate (0,0,180);
		}
	}

}
