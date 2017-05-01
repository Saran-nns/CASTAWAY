// Attach the script to the  Canvas-Panel-Button which gives its corresponding functionality.

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
namespace M{

	public class Buttonmanager : MonoBehaviour 
	{
		void Start(){
			Cursor.visible = true;
		}

		public void PlayButton(string Play)
		{

			SceneManager.LoadScene(1);  // Check the Build settings and pass/change the argument value for Load scene
		}

		public void ExitButton()
		{

			Application.Quit();

		}
	}
}
