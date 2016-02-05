using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private int _scoreValue;
    private int _livesValue;


    // Public access methods
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {

            this._scoreValue = value;
            this.ScoreLabel.text = "Score:" + this._scoreValue;
        }
    }

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else
            {
                this.LivesLabel.text = "Lives:" + this._livesValue;
            }

        }
    }


    // PUBLIC VARIABLE
    public int asteroidNumber = 4;
    public AsteroidController asteroids;
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
    public UFOController UFO;
    public MapController map;
    public Text HighScoreLabel;
    public Button RestartButton;

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
        this.ScoreValue = 0;
        this.LivesValue = 5;
        this.GameOverLabel.enabled = false;
        this.HighScoreLabel.enabled = false;
        //this.RestartButton.enabled = false;
        this.RestartButton.gameObject.SetActive(false);
        for (int asteroidCount=0; asteroidCount<this.asteroidNumber;asteroidCount++)
        {
            Instantiate(asteroids.gameObject);
        }

    }

    private void _endGame()
    {
        this.HighScoreLabel.text = "High Score:" + this._scoreValue;
        this.GameOverLabel.enabled = true;
        this.UFO.gameObject.SetActive(false);
        this.map.gameObject.SetActive(false);
        this.LivesLabel.enabled = false;
        this.ScoreLabel.enabled = false;
        this.HighScoreLabel.enabled = true;
        this.RestartButton.gameObject.SetActive(true);

    }

    public void RestartButtonClick()
    {
        Application.LoadLevel("Main");
    }

}
