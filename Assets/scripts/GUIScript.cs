using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScript : MonoBehaviour {



	public void newGameFunction()
	{

		Application.LoadLevel ("mainGameScene");
	
	}

	public void quitGameFunction()
	{
		Application.Quit();
	}

}
