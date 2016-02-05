using UnityEngine;
using System.Collections;

public class AsteroidController : MonoBehaviour {

    // Public instance variables
    public float minHorizontalSpeed = 5f;
    public float maxHorizontalSpeed = 10f;
    public float minVerticalSpeed = -2f;
    public float maxVerticalSpeed = 2f;

    // Private instance variables
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _horizontalSpeed;
    private float _verticalDrift;
    
    
    // Use this for initialization
    void Start()
    {
        //make a reference with the transform component
        this._transform = gameObject.GetComponent<Transform>();
        this.Reset();

    }

    // Update is called once per frame
    void Update()
    {

        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this._horizontalSpeed,this._verticalDrift);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -355)
        {
            this.Reset();
        }

    }
    // Method to reset the asteroids location
    public void Reset()
    {
        this._horizontalSpeed = Random.Range(this.minHorizontalSpeed, this.maxHorizontalSpeed);
        this._verticalDrift = Random.Range(this.minVerticalSpeed, this.maxVerticalSpeed);
        float yPosition = Random.Range(-207, 207);
        this._transform.position = new Vector2(355f, yPosition);
    }
}
