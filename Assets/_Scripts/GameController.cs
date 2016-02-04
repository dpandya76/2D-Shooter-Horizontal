using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    // PUBLIC VARIABLE
    public int asteroidNumber = 4;
    public AsteroidController asteroids;

	// Use this for initialization
	void Start () {
        this._initialize();
       
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //private methods
    private void _initialize()
    {
       for(int asteroidCount=0; asteroidCount<this.asteroidNumber;asteroidCount++)
        {
            Instantiate(asteroids.gameObject);
        }

    }
}
