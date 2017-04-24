using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace M
{
	
    public class GameManager_GoToMenuScene : MonoBehaviour {

		private GameManager_Master gameManagerMaster;

		void OnEnable()
		{
			SetInitialReference ();
			gameManagerMaster.GotoMenuSceneEvent += GoToMenuScene;
		}

		void OnDisable()
		{
			gameManagerMaster.GotoMenuSceneEvent -= GoToMenuScene;

		}

		void SetInitialReference()
		{
			gameManagerMaster = GetComponent<GameManager_Master> ();
		}

		void GoToMenuScene()
		{
			//Application.LoadLevel (0);
			SceneManager.LoadScene(0);
		}

}
}
