using UnityEngine;
using System.Collections;

namespace Assets.Script
{

public class NewsMaker : MonoBehaviour {
	private int ticks;

	// Use this for initialization
	void Start () {
		ticks = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(ticks > 1100){
			GameState.Instance().previousSceneString = "NewsScene";
			Application.LoadLevel("DesktopScene");
		}

		ticks += 1;
	}
}
}