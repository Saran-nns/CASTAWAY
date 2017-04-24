//This script enables underwater effects. Attach to main camera.
//Source: http://wiki.unity3d.com/index.php?title=Underwater_Script

using UnityEngine;
using System.Collections;

namespace M{

	public class Underwater : MonoBehaviour {



		//Define variable
		public float underwaterLevel = 0.01f;                //Height of the camera attched to Player//
		public Material defaultSkybox = RenderSettings.skybox;   //Default skybox is overwritten as user defined in inspector //
		//The scene's default fog settings
		private bool defaultFog = RenderSettings.fog;
		private Color defaultFogColor = RenderSettings.fogColor;
		private float defaultFogDensity = RenderSettings.fogDensity;
		private Material noSkybox;

		void Start () {
			//Set the background color
			Camera.main.backgroundColor = new Color(0, 0.4f, 0.7f, 1);   //Error in the Source script //
		}

		void Update () {
			if (transform.position.y < underwaterLevel)
			{
				RenderSettings.fog = true;
				RenderSettings.fogColor = new Color(0.5f, 0.5f, 0.5f, 0.3f);
				RenderSettings.fogDensity = 0.05f;
				RenderSettings.skybox = defaultSkybox;
			}
			else
			{
				RenderSettings.fog = defaultFog;
				RenderSettings.fogColor = defaultFogColor;
				RenderSettings.fogDensity = defaultFogDensity;
				RenderSettings.skybox = defaultSkybox;
			}
		}
	}
}
	