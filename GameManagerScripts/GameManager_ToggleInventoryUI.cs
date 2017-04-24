using UnityEngine;
using System.Collections;

namespace M
{
	public class GameManager_ToggleInventoryUI : MonoBehaviour
	{
		[Tooltip("Does this game mode has Inventory? Set to true if that in case")]
		public bool hasInventory;
		public GameObject inventoryUI;
		public string toggleInventoryButton;
		private GameManager_Master gameManagerMaster;

		void Start () 
		{
			SetInitialReferences ();
		}


		void Update () 
		{
			CheckForInventoryUIToggleRequest ();

		}
		void SetInitialReferences()
		{
			gameManagerMaster = GetComponent<GameManager_Master>();
			if(toggleInventoryButton=="")
			{
				Debug.LogWarning("Type in the name of button used to toggle the inventory in Game Manager Toggle InventoryUI");
				this.enabled = false;
			}
		}
		void CheckForInventoryUIToggleRequest()
		{
			if(Input.GetButtonUp(toggleInventoryButton) && !gameManagerMaster.isMenuOn &&
				!gameManagerMaster.isGameOver && hasInventory)
			{
				ToggleInventoryUI ();
			}
		}
		public void ToggleInventoryUI()
		{
			if (inventoryUI != null)
			{
				inventoryUI.SetActive (!inventoryUI.activeSelf);
				gameManagerMaster.isInventoryUIOn = !gameManagerMaster.isInventoryUIOn;
				gameManagerMaster.CallEventInventoryUIToggle ();
			}

		}
	}

}
