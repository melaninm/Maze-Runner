using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gerak : MonoBehaviour {
	public float speed = 5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D)){
			transform.Translate(speed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey(KeyCode.A)){
			transform.Translate(-speed * Time.deltaTime, 0, 0);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate(0, -speed * Time.deltaTime, 0);
		}
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(0, speed * Time.deltaTime, 0);
		}
	}
	private void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == "keys"){
			Destroy(collision.gameObject);
		}
		if(collision.gameObject.tag == "enemies"){
			SceneManager.LoadScene(SceneManager.GetActiveScene().name); //load current scene
		}
		if(collision.gameObject.tag == "walls"){
			if(Input.GetKey(KeyCode.D)){
			transform.Translate(-speed * Time.deltaTime, 0, 0);
			}
			if (Input.GetKey(KeyCode.A)){
				transform.Translate(speed * Time.deltaTime, 0, 0);
			}
			if(Input.GetKey(KeyCode.S)){
				transform.Translate(0, speed * Time.deltaTime, 0);
			}
			if(Input.GetKey(KeyCode.W)){
				transform.Translate(0, -speed * Time.deltaTime, 0);
			}
		}
	}
}
