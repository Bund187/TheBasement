using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarManager : MonoBehaviour {

	int i=0,j=11;
	Image rend;
	bool pause;

	public Sprite[] bars = new Sprite[11];

	void Start(){
		rend=transform.GetComponent<Image> ();
	}

	void Update () {
		Bar ();
		if (Input.GetKeyDown (KeyCode.F)) {
			if (transform.parent.GetComponent<Canvas> ().sortingOrder > 0) {
				j = j + 4;
				if (j > 10)
					j = 10;
				print ("j=" + j);
				rend.sprite = bars [j];
			}
		}

		if (Input.GetKeyDown (KeyCode.P)) {
			pause = !pause;
		}
		if (pause) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}
	}

	void Bar(){
		if (rend.sprite != bars [0]) {
			if (Time.time >= i) {
				i += 1;
				j = j - 1;
				rend.sprite = bars [j];
				print (j + " Time=" + Time.time);
			}
		} else {
			j = 0;
		}
	}
}
