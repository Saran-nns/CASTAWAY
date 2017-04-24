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