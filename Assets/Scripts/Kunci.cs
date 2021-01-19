using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kunci : MonoBehaviour
{
    public AudioSource suaraKunci;
    //Text hitungKunciText;
    public static int hitungKunci;
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag.Equals ("player"))
        {
            print("kunci diambil");
            suaraKunci.Play();
            Destroy (gameObject);
            hitungKunci += 1;
        }        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        hitungKunci = 0;
        //hitungKoinText = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        //hitungKoinText.text = hitungKoin.ToString();
    }
}