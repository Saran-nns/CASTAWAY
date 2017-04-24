using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace M
{
	public class Player_ToolBox : MonoBehaviour {

		private Player_Master playerMaster;

		[System.Serializable]
		public class ToolTypes
		{
			public string toolName;
			public int toolMaxQuantity;
			public int toolCurrentCarried;

			public ToolTypes (string aName, int aMaxQuantity, int aCurrentCarried)
			{
				toolName = aName;
				toolMaxQuantity = aMaxQuantity;
				toolCurrentCarried = aCurrentCarried;
			}
		}

		public List<ToolTypes> typesOfTools = new List <ToolTypes> ();
		void OnEnable()
		{
			SetInitialReferences ();
			playerMaster.EventPickedupTool += PickedUpTool;

		}

		void OnDisable()
		{
			playerMaster.EventPickedupTool -= PickedUpTool;
		}
		void SetInitialReferences()
		{
			playerMaster = GetComponent<Player_Master> ();
		}
		void PickedUpTool(string toolName,int quantity)
		{
			for (int i =0;i<typesOfTools.Count;i++)
			{
				if(typesOfTools[i].toolName == toolName)
				{
					typesOfTools[i].toolCurrentCarried += quantity;

					if (typesOfTools [i].toolCurrentCarried > typesOfTools [i].toolMaxQuantity) {
						typesOfTools [i].toolCurrentCarried = typesOfTools [i].toolMaxQuantity;
					}

					playerMaster.CallEventToolChanged ();
					break;


				}

			}
		}
	}
}

