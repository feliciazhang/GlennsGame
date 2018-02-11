using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {


	public GameObject dBox_Instruct_Out;
	public GameObject dBox_Instruct_In;
	public Text dText_Instructions;
	public GameObject dBox_Mica;
	public GameObject dBox_Mica_IN;
	public Text dText_Mica;
	public GameObject dBox_Felicia;
	public GameObject dBox_Felicia_IN;
	public Text dText_Felicia;
	public GameObject dBox_Catu;
	public GameObject dBox_Catu_IN;

	public Text dText_Catu;
	private bool dialogueActive;
	private int newFontSize = 400;

	private bool option_M;
	private bool option_F;
	private bool option_C;

	// Use this for initialization
	void Start () {
		dBox_Felicia.SetActive (false);
		dBox_Catu.SetActive (false);
		dBox_Mica.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			dBox_Mica.SetActive (!dialogueActive);
			dBox_Felicia.SetActive (!dialogueActive);
			dBox_Catu.SetActive (!dialogueActive);
			dialogueActive = !dialogueActive;
			dText_Instructions.text = "Choose your sidekick:\n(M)ica, (C)atu, (F)elicia\nSPACE for more options.";
			dText_Instructions.fontSize = 380;
		} 
			
		if (Input.GetKeyDown (KeyCode.M)) {
			dText_Mica.fontSize = newFontSize;
			dBox_Mica.SetActive (true);
			dText_Mica.text = "\"Mana is too low. I must take a nap to restore energy.\"";
			dText_Felicia.text = "";
			dText_Catu.text = "";
			dBox_Felicia.SetActive (false);
			dBox_Catu.SetActive (false);
			option_M = true;
		}

		if (Input.GetKeyDown (KeyCode.F)) {
			dText_Felicia.fontSize = newFontSize;
			dBox_Felicia.SetActive (true);
			dText_Felicia.text = " \"Sorry Glenn, I lost my glasses and I can't see.\"";
			dText_Mica.text = "";
			dText_Catu.text = "";
			dBox_Mica.SetActive (false);
			dBox_Catu.SetActive (false);
			option_F = true;

		}


		if (Input.GetKeyDown (KeyCode.C)) {
			dText_Catu.fontSize = newFontSize;
			dBox_Catu.SetActive (true);
			dText_Catu.text = "\"Unless I'm the protagonist, I refuse to participate.\"";
			dText_Mica.text = "";
			dText_Felicia.text = "";
			dBox_Mica.SetActive (false);
			dBox_Felicia.SetActive (false);
			option_C = true;
		}

		if (option_M && option_F && option_C && Input.GetKeyDown (KeyCode.Space)) {
			dBox_Mica.SetActive (false);
			dBox_Felicia.SetActive (false);
			dBox_Catu.SetActive (false);
			dText_Instructions.text = "Seems like you must venture forth alone. Good luck!";
		}
	
	}


}
