using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace M
{
	[RequireComponent(typeof(AudioSource))]
	public class pickup : MonoBehaviour {

		public GameObject inventoryPanel;
		public GameObject[] inventoryIcons;
		public AudioClip Pickup;
		AudioSource pickupitem;
		private int itemscount=0;

		void Start() {
			pickupitem = GetComponent<AudioSource>();
		}
		void OnTriggerEnter(Collider collision)
		{
			
			foreach(Transform child in inventoryPanel.transform)
			{
				//if Item already in the inventory
				if(child.gameObject.tag==collision.gameObject.tag)
				{
					//Transform temptext;

					string c = child.Find ("Text").GetComponent<Text> ().text;
					//temptext=child.Find("Text");
					//Debug.Log (child.gameObject.tag);
					//Debug.Log (child.gameObject.GetInstanceID ());
					//Debug.Log (child.gameObject.name);
					//Text itemrope = temptext.GetComponent<Text> ();
					//string c = itemrope.text;
					//string c = temptext.GetComponent<Text> ().text;
					int tcount = System.Int32.Parse (c) + 1;
					child.Find ("Text").GetComponent<Text> ().text = "" + tcount;
					itemscount += 1;
					Debug.Log (itemscount);
					pickupitem.PlayOneShot(Pickup, 0.7f);
					Destroy (collision.gameObject);
					if (itemscount == 4) {
						SceneManager.LoadScene (2);   // If all items are collected Player wins
					}
					return;
				}

				
					
			}

			GameObject i;
			if(collision.gameObject.tag=="axe"){
				i = inventoryIcons [0];
				i.transform.SetParent (inventoryPanel.transform);
				//Destroy (collision.gameObject);
			}
			else if(collision.gameObject.tag=="knife"){
				i =inventoryIcons [1];
				i.transform.SetParent (inventoryPanel.transform);
				//Destroy (collision.gameObject);
			}
			else if(collision.gameObject.tag=="rope"){
				i = inventoryIcons [2];
				i.transform.SetParent (inventoryPanel.transform);
				//Destroy (collision.gameObject);
			}
			else if(collision.gameObject.tag=="spear"){
				i =  (inventoryIcons [3]);
				i.transform.SetParent (inventoryPanel.transform);
				//Destroy (collision.gameObject);
			}
			else if(collision.gameObject.tag=="wood"){
				i =  (inventoryIcons [4]);
				i.transform.SetParent (inventoryPanel.transform);
				//Destroy (collision.gameObject);
		}
	}
}
}
