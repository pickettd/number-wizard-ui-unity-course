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
		guess = (max+min) / 2;
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
		guess = 500;
		text.text = guess.ToString();
		max += 1;

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
