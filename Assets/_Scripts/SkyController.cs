﻿using UnityEngine;
using System.Collections;

public class SkyController : MonoBehaviour {

    private Transform _transform;
    public float speed = 5;
    private Vector2 _currentPosition;

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
        this._currentPosition -= new Vector2(this.speed,0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -580)
        {
            this.Reset();
        }

    }

    public void Reset()
    {
        this._transform.position = new Vector2(575f , 0);
    }
}
