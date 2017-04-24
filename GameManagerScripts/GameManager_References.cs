using UnityEngine;
using System.Collections;

namespace M
{
	public class GameManager_References : MonoBehaviour 
	{
		// Handle some important references like player tag, enemy tag and player game object
	    public string playerTag;
	    public static string _playerTag;


	    public string enemyTag;
	    public static string _enemyTag;

	    public static GameObject _player;

		void OnEnable()
		{
			if (playerTag == "") 
			{
				Debug.LogWarning ("Name of player tag in GameManager_Reference is missing");

			}
			if (enemyTag == "") 
			{
				Debug.LogWarning ("Name of enemy tag in GameManager_Reference is missing");

			}
			_playerTag = playerTag;
			_enemyTag = enemyTag;

			_player = GameObject.FindGameObjectWithTag (_playerTag);

		}

	}
}
