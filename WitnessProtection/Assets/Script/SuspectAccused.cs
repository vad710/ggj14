using UnityEngine;
using System.Collections;

public class SuspectAccused : MonoBehaviour {
	bool increasing;
	bool decreasing;
	bool fullSize;
	bool tinySize;
	public string finalText;
	public GameObject clickAgainText;
	public GameObject accusationHolder;
	public TextMesh accusationText;
	public GameObject undoLayer;

	// Use this for initialization
	void Start () {
		clickAgainText.SetActive(false);
		increasing = false;
		decreasing = false;
		fullSize = false;
		tinySize = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(increasing){
			float newScale = this.transform.localScale.x + .05f;
			if(newScale >= .6f){
				increasing = false;
				fullSize = true;
				newScale = .6f;
				clickAgainText.SetActive(true);
				undoLayer.SetActive(true);
			}
			this.transform.localScale = new Vector3(newScale, newScale, 1);
		}
		else if(decreasing){
			float newScale = this.transform.localScale.x - .05f;
			if(newScale <= .4f){
				decreasing = false;
				tinySize = true;
				newScale = .4f;
				clickAgainText.SetActive(false);
			}
			this.transform.localScale = new Vector3(newScale, newScale, 1);
		}
	}

	public void shrink(){
		clickAgainText.SetActive(false);
		decreasing = true;
		increasing = false;
		fullSize = false;
		this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 1);

	}

	void OnMouseDown(){
	//	renderer.material.color = new Color(0, 0, 0,);
	    if (!fullSize)
	    {
	        increasing = true;
	        decreasing = false;
	        tinySize = false;
	        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x,
	            this.gameObject.transform.position.y, -1);

	    }
	    else
	    {
	        accuseMe();
	    }

        var soundSource = GameObject.FindObjectOfType<AudioSource>();
        soundSource.PlayOneShot(soundSource.clip);
	}

	void accuseMe(){
	//	accusationText.text = finalText;
		accusationHolder.SetActive(true);
		clickAgainText.SetActive(false);

		this.gameObject.transform.position = new Vector3(-4.3f,0,-7);
		this.transform.localScale = new Vector3(.5f, .5f, 1);
	}
}
