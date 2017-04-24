using UnityEngine;
using System.Collections;


namespace M
{
	public class TestGameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKey (KeyCode.O)) {
				GetComponent<GameManager_Master> ().CallEventGameOver ();
			}
	
	}
}
}
