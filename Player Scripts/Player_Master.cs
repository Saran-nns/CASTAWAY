using UnityEngine;
using System.Collections;

namespace M
{
	public class Player_Master:MonoBehaviour{
		public delegate void GeneralEventHandler();
		public event GeneralEventHandler EventInventoryChanged;
		public event GeneralEventHandler EventHandsEmpty;
		public event GeneralEventHandler EventToolChanged;

		public delegate void ToolPickupEventHandler(string toolName, int quantity);
		public event ToolPickupEventHandler EventPickedupTool;

		public delegate void PlayerHealthEventHandler(int healthChange);
		public event PlayerHealthEventHandler EventPlayerHealthDeduction;
		public event PlayerHealthEventHandler EventPlayerHealthIncrease;

		public void CallEventInventoryChanged()
		{
			if (EventInventoryChanged != null) {
			
				EventInventoryChanged ();
			}
		}
		public void CallEventHandsEmpty()
		{
			if (EventHandsEmpty != null) {
				EventHandsEmpty ();
			}
		}
		public void CallEventToolChanged()
		{
			if (EventToolChanged != null) {
				EventToolChanged ();
			}
		}
		public void CallEventPickedUpTool(string toolName,int quantity)
		{
			if (EventPickedupTool != null) {
				EventPickedupTool (toolName, quantity);
			}
		}
		public void CallEventPlayerHealthDeduction(int dmg)
		{
			if (EventPlayerHealthDeduction != null) {
				EventPlayerHealthDeduction (dmg);
			}
		}
		public void CallEventPlayerHealthIncrease(int increase)
		{
			if (EventPlayerHealthIncrease != null) {
				EventPlayerHealthIncrease (increase);
			}
		}

	}
}

