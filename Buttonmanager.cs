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

			SceneManager.LoadScene(1);
		}

		public void ExitButton()
		{

			Application.Quit();

		}
	}
}
