using UnityEngine;
using System.Collections;

public class UFOController : MonoBehaviour {

    //private instance variable
    private float _playerInputY;
    private float _playerInputX;
    private Transform _transform;
    private Vector2 _currentPosition;
    public float speed = 5f;

    // Use this for initialization
    void Start()
    {
        this._transform = gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;

        this._playerInputY = Input.GetAxis("Vertical");
        this._playerInputX = Input.GetAxis("Horizontal");
        
        //move up
        if (this._playerInputY > 0)
        {
            this._currentPosition += new Vector2(0,this.speed);

        }

        //move down
        if (this._playerInputY < 0)
        {
            this._currentPosition -= new Vector2(0,this.speed);
        }

        //move front
        if(this._playerInputX>0)
        {
            this._currentPosition += new Vector2(this.speed,0);
        }

        //move back
        if(this._playerInputX<0)
        {
            this._currentPosition -= new Vector2(this.speed,0);
        }

        this._checkBounds();

        this._transform.position = this._currentPosition;

    }

    //private method for check bound.......................................
    private void _checkBounds()
    {
        if (this._currentPosition.y < -208)
        {
            this._currentPosition.y = -208;
        }

        if (this._currentPosition.y > 208)
        {
            this._currentPosition.y = 208;
        }

        if (this._currentPosition.x>-40)
        {
            this._currentPosition.x = -40;
        }

        if(this._currentPosition.x<-273)
        {
            this._currentPosition.x = -273;
        }
    }
}
