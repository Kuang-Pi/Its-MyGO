using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerSound : MonoBehaviour
{
    private AudioSource AudioPlayer;
    // Start is called before the first frame update
    void Start()
    {
        this.AudioPlayer = GetComponent<AudioSource>();
        this.AudioPlayer.PlayDelayed(1.642f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if(collision.tag == "Player") { this.AudioPlayer.Play(0); }
        //this.AudioPlayer.Play(0);
    }
}
