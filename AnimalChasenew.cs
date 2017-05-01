//Most crucial script in the game
//Attached with the Enemy game objects that asks the enemy to chase the player (tagged as "Prey") only when he is in range.

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace M
{
	public class AnimalChasenew: MonoBehaviour{

		public Transform player;  //Exposed variable in the inspector so that the animal knows the distance between them and the player

		void Start()
		{

		}
		void Update()
		{
			if(player==GameObject.FindWithTag("Prey").transform){

				if (Vector3.Distance (player.position, this.transform.position) < 10) { // Check the vector3 distance between the player and the animal and if it is less than 10
					Vector3 direction = player.position - this.transform.position; //Variable to measure and change the Direction of animal towards the position of the player.Difference in distance.

					direction.y = 0; //Remove the rotation along the y axis.Since animal is not going to follow the player depend on their height difference

					this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f); //Change the look direction of the animal by Rotation with Slerp function 

					if (direction.magnitude > 1)
					{  //if the magnitude(vector length ) of direction calculated above is greater than 5
						this.transform.Translate (0, 0, 0.05f); //tranform the animal towards z direction(forward direction)

					}

				}
			}
		}
	}
}
	


