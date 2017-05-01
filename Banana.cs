//Script not in use as the game story has changed

// Script make a count of number of banana/gameobjects collected by the player and update the count in the canvas text panel(bananaText)

using UnityEngine;
using System.Collections;

public class Banana : MonoBehaviour {


		public GUIText bananaText;

		void OnTriggerEnter(Collider other)
		{
			int score = int.Parse (bananaText.text) + 1;
			bananaText.text = score.ToString();
			Destroy(gameObject);
		}
	}
