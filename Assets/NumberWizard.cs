using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	public int maxGuessesAllowed = 5;

	public Text text;

	void Guess () {
		guess = Random.Range(min, max+1);
		text.text = guess.ToString();
		maxGuessesAllowed -= 1;
		if (maxGuessesAllowed == 0) {
			Application.LoadLevel("Win");
		}
	}
	
	// Use this for initialization
	void Start () {
		max = 1000;
		min = 1;
		guess = Random.Range(min, max+1);
		text.text = guess.ToString();

	}

	public void GuessHigher() {
		min = guess;
		Guess ();
	}

	public void GuessLower() {
		max = guess;
		Guess ();
	}
}
