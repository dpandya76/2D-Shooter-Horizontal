using UnityEngine;
using System.Collections;

public class UFOCollider : MonoBehaviour {

   private AudioSource[] _audioSources;
   private AudioSource _mapSound;
   private AudioSource _asteroidSound;

    //Public instance variables
   public GameController gameController;

    // Use this for initialization
    void Start()
    {
        // Initialize the audioSource array
       this._audioSources = gameObject.GetComponents<AudioSource>();
       this._mapSound = this._audioSources[2];
       this._asteroidSound = this._audioSources[1];

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Map"))
        {
            this._mapSound.Play();
            this.gameController.ScoreValue += 1;
            //Debug.Log("Map Collision");
        }

        if (other.gameObject.CompareTag("Asteroid"))
        {
            this._asteroidSound.Play();
            this.gameController.LivesValue -= 1;
            //Debug.Log("Asteroid Collision");
        }
    }
}
