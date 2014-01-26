using UnityEngine;
using System.Collections;

public class UnSolve : MonoBehaviour {

	public SuspectAccused oliviaSuspect;
	public SuspectAccused eliSuspect;
	public SuspectAccused ethanSuspect;
	public SuspectAccused martaSuspect;
	public SuspectAccused calebSuspect;
	public SuspectAccused dannySuspect;

	// Use this for initialization
	void Start () {
		this.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		this.gameObject.SetActive(false);
		oliviaSuspect.shrink();
		eliSuspect.shrink();
		ethanSuspect.shrink();
		martaSuspect.shrink();
		calebSuspect.shrink();
		dannySuspect.shrink();
	}
}
