using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musuh : MonoBehaviour {

	public bool GameAktif = true;
    bool isPaused = false;
    public GameObject GameOverPanel;
    public AudioSource suaraKalah;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == "Player"){
			print("kena deh");
			Destroy(collision.gameObject);
				Debug.Log("Game Kalah");
                GameOverPanel.SetActive(true);
                Time.timeScale = 0;
                isPaused = true;
                suaraKalah.Play();
		}
	}
}
