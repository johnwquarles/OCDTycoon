﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneScript : MonoBehaviour {
	public float speed;
	public Text evilMsg;
	public Text nervousMsg;
	private string[] evilMsgs;
	private string[] nervousMsgs;
	private AudioSource sound;


	// Use this for initialization
	void Start () {
		speed = 75 * (1f + GameState.state.levelCount / 6);
		evilMsgs = new string[] {"HEY, SHAKE MY HAND GUY!", "PUT 'ER THERE!", "GUESS WHERE THIS HAND HAS BEEN!", "GREAT PLACE TO SHAKE!", "I FOUND A QUARTER IN THE TOILET!", "QUICK, BEFORE WE WASH OUR HANDS!", "SHAKE! SHAAAAAKE!", "LET'S MAKE A DEEEEAL!", "GREET ME PROPERLY!", "SHAKE WHAT MY MOMMA GAVE ME!!", "ONE HANDSHAKE, STAT!", "SHAKE ON IT!!!", "SHAKE 'N BAKE and handshake"};
		nervousMsgs = new string[] {"Err, well...", "Gee, I...", "OK, I guess...", "s..sure...", "If that's what you're into...", "I, well...", "aww, jeez...", "that's, well...", "I suppose...", "But I...", "Uh..."};
		evilMsg.text = evilMsgs[Random.Range(0, evilMsgs.Length)];
		nervousMsg.text = nervousMsgs[Random.Range(0, nervousMsgs.Length)];
		sound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void explosionSound () {
		sound.pitch = Random.Range (0.7f, 1.6f);
		sound.Play();
	}
}