using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectionObject : MonoBehaviour
{
    public string nameTag;
    public AudioClip audiobenar;
    public AudioClip audiosalah;
    public AudioSource Mediaplayerbenar;
    public AudioSource Mediaplayersalah;
    // Start is called before the first frame update
    void Start()
    {
        Mediaplayerbenar = gameObject.AddComponent<AudioSource>();
        Mediaplayerbenar.clip = audiobenar;
        Mediaplayersalah = gameObject.AddComponent<AudioSource>();
        Mediaplayersalah.clip = audiosalah;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nameTag))
        {
            ScoreScript.scoreValue += 10;
            Debug.Log("true");
            Destroy(collision.gameObject);
            Mediaplayerbenar.Play();
        }
        else
        {
            ScoreScript.scoreValue -= 5;
            Debug.Log("false");
            Destroy(collision.gameObject);
            Mediaplayersalah.Play();
        }
    }
}