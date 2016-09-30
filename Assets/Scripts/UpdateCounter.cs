using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateCounter : MonoBehaviour {

	private float counter;
	private bool running = false;

	public Text label; 

	void Start () {
		counter = 0;
	}

	void Update () {
		if (this.running && counter > 0) {
			counter -= Time.deltaTime;
			UpdateCounterLabel ();
		}
	}

	private void UpdateCounterLabel() {
		this.label.text = ((int)this.counter).ToString() + " second(s) left";
	}

	public void SetCounter(float counter) {
		this.counter = counter;
		UpdateCounterLabel ();
	}

	public void MakeItRun() {
		this.running = true;
	}

	public void MakeItStop() {
		this.running = false;
	}
}
