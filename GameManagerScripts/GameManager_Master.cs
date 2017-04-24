using UnityEngine;
using System.Collections;

namespace M
{
public class GameManager_Master : MonoBehaviour
{
		public delegate void GameManagerEventHandler();
		public event GameManagerEventHandler MenuToggleEvent;
		public event GameManagerEventHandler InventoryUIToggleEvent;
		public event GameManagerEventHandler RestartLevelEvent;
		public event GameManagerEventHandler GotoMenuSceneEvent;
		public event GameManagerEventHandler GameOverEvent;

		public bool isGameOver;
		public bool isInventoryUIOn;
		public bool isMenuOn;



	//Define all Call Event methods

		public void CallEventMenuToggle()
		{
			if (MenuToggleEvent != null) 
			{
				MenuToggleEvent ();
			 
			}
		}

		public void CallEventInventoryUIToggle()
		{
			if (InventoryUIToggleEvent != null) 
			{
				InventoryUIToggleEvent ();
			}
		}

		public void CallEventRestartLevelEvent()
		{
			if (RestartLevelEvent != null) 
			{
				RestartLevelEvent ();
			}
		}

		public void CallEventGotoMenuSceneEvent()
		{
			if (GotoMenuSceneEvent!= null) 
			{
				GotoMenuSceneEvent();
			}
		}
		public void CallEventGameOver()
		{
			if (GameOverEvent != null) 
			{
				isGameOver = true;
				GameOverEvent ();
			}
	    }
	}
}
