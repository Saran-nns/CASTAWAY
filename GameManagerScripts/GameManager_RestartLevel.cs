using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace M
{
	
    public class GameManager_RestartLevel : MonoBehaviour {

		private GameManager_Master gameManagerMaster;

		void OnEnable()
		{
			SetInitialReference ();
			gameManagerMaster.RestartLevelEvent += RestartLevel;
		}

		void OnDisable()
		{
			gameManagerMaster.RestartLevelEvent -= RestartLevel;

		}

		void SetInitialReference()
		{
			gameManagerMaster = GetComponent<GameManager_Master> ();
		}

		void RestartLevel()
		{
			//Application.LoadLevel (Application.loadedLevel);
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}

	}
}
