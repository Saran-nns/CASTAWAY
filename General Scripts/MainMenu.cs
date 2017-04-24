using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace M
{
    public class MainMenu : MonoBehaviour {
		public void PlayGame()
		{
			//Application.LoadLevel (1);
			SceneManager.LoadScene(1);
		}
		public void ExitGame()
		{
			//Application.Quit ();
			Application.Quit();

		}
}
}	