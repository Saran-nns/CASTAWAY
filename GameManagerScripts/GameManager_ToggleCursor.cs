using UnityEngine;
using System.Collections;

namespace M
{
	public class GameManager_ToggleCursor : MonoBehaviour
	{
		private GameManager_Master gameManagerMaster;
		private bool isCursorLocked=true;

		void OnEnable ()
		{
			SetInitialReferences ();
			gameManagerMaster.MenuToggleEvent += ToggleCursorState;
			gameManagerMaster.InventoryUIToggleEvent += ToggleCursorState;

		}
	    void OnDisable () 
		{
			gameManagerMaster.MenuToggleEvent -= ToggleCursorState;
			gameManagerMaster.InventoryUIToggleEvent -= ToggleCursorState;
			
	
	    }
		void Update()
		{
			isCursorLocked = !isCursorLocked;
		}
		void SetInitialReferences()
		{
			gameManagerMaster = GetComponent<GameManager_Master> ();

		}
		void ToggleCursorState()
		{
		}
		void CheckIfCursorShouldBeLocked()
		{
			if (isCursorLocked) {
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
			
			} else 
			{
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}

		}
}
}
