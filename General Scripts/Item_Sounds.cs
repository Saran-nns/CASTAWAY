using UnityEngine;
using System.Collections;

namespace M
{
    public class Item_Sounds : MonoBehaviour {

		public float defaultVolume;
		public AudioClip pickupSound;

		void PickItemSound()
		{
			if(pickupSound!=null)
			{
				AudioSource.PlayClipAtPoint (pickupSound, transform.position, defaultVolume);
			}
		}

	}
}


	

