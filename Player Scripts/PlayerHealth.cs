using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
namespace M
{
	[RequireComponent(typeof(AudioSource))]
	public class PlayerHealth : MonoBehaviour
	{
		
		private GameManager_Master gameManagerMaster;
		public float startingHealth = 100.0f;                            // The amount of health the player starts the game with.
		public float currentHealth;                                   // The current health the player has.
		public Slider healthSlider;                                 // Reference to the UI's health bar.
		public Image damageImage;                                   // Reference to an image to flash on the screen on being hurt.
		public float flashSpeed = 0.1f;                               // The speed the damageImage will fade at.
		public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.
		private const float coef = 1.0f;                                 //Reduce player health over time
		public AudioClip pickuphealth;
		public AudioClip hurt;
		AudioSource audio1,audio2;

		bool isDead;                                                // Whether the player is dead.
		bool damaged;                                               // True when the player gets damaged.

		void Start() {
			audio1 = GetComponent<AudioSource>();
			audio2 = GetComponent<AudioSource>();
		}
		void Awake ()
		{
			
			// Set the initial health of the player.

			currentHealth = startingHealth;


		}


		void Update ()
		{
			// Reduce player health over time
			currentHealth -= coef * Time.deltaTime;
			//healthSlider.value -= coef * Time.deltaTime;
			healthSlider.value = currentHealth;

			// If the player has just been damaged...
			if(damaged)
			{
				// ... set the colour of the damageImage to the flash colour.
				damageImage.color = flashColour;
			}
			// Otherwise...
			else
			{
				// ... transition the colour back to clear.
				damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
			}

			// Reset the damaged flag.
			damaged = true;
		}
		void OnTriggerEnter(Collider other)
		{
			if (other.gameObject.CompareTag ("Pick")) {
				other.gameObject.SetActive (false);
				currentHealth += 10;
				audio1.PlayOneShot(pickuphealth, 0.7F);
				//healthSlider.value = currentHealth;
			}
		}


		public void TakeDamage (int amount=10)
		{
			// Set the damaged flag so the screen will flash.
			damaged = true;
			audio2.PlayOneShot(hurt, 0.7F);   // Play the hurt sound effect.

			// Reduce the current health by the damage amount.
			currentHealth -= amount;
			//Debug.Log (currentHealth);

			// Set the health bar's value to the current health.
			healthSlider.value = currentHealth;


			// If the player has lost all it's health and the death flag hasn't been set yet...
			if(currentHealth <= 0 )
			{
				// ... it should die.
				//Death ();
				SceneManager.LoadScene(3);
			}
		}


		//void Death ()
		//{
			// Set the death flag so this function won't be called again.
			//isDead = true;
			//gameManagerMaster.CallEventGameOver ();

			// Turn off any remaining shooting effects.
			//playerShooting.DisableEffects ();

			// Tell the animator that the player is dead.
			//anim.SetTrigger ("Die");

			// Set the audiosource to play the death clip and play it (this will stop the hurt sound from playing).
			//playerAudio.clip = deathClip;
			//playerAudio.Play ();

			// Turn off the movement and shooting scripts.
			//playerMovement.enabled = false;
			//playerShooting.enabled = false;
		}       
	}

