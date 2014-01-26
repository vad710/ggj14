using UnityEngine;
using System.Collections;

namespace Assets.Script
{
	[RequireComponent(typeof(AudioSource))]
	public class NewsMaker : MonoBehaviour {
		private float ticks;
		public GameObject tvScreen;
		public GameObject tickerTape;
		public AudioClip impact;

		//	public GameObject tvScreenOff;
		bool shuttingOff;
		
		// Use this for initialization
		void Start () {
			ticks = 0;
			shuttingOff = false;
		}
		
		// Update is called once per frame
		void Update () {
			if(ticks > 20f){
				if(tvScreen.activeSelf){
					shutOff();
				}
			}
			if(ticks > 22f){
				GameState.Instance().previousSceneString = "NewsScene";
				Application.LoadLevel("DesktopScene");
			}
			tickerTape.transform.position = new Vector3(tickerTape.transform.position.x-.015f,tickerTape.transform.position.y,tickerTape.transform.position.z);
			ticks += Time.deltaTime;
		}
		
		void shutOff(){
			if(!shuttingOff){
				shuttingOff = true;
				audio.PlayOneShot(impact);
			}
			float scaleHeight = tvScreen.transform.localScale.y;
			//	scaleHeight -= .1f;
			scaleHeight *= .7f;
			if(scaleHeight <= 0){
				tvScreen.SetActive(false);
			}
			else{
				tvScreen.transform.localScale = new Vector3(tvScreen.transform.localScale.x,scaleHeight,1);
			}
		}
	}
}