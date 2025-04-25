using System;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float verticalStrength = 16;
    //public float _devOobY = 20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //this._gravityScale = this.rigidbody2D.gravityScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.linearVelocity = Vector2.up * this.verticalStrength;
        }
        //Debug.Log($"this.transform.position.y: {this.transform.position.y}, {-this._devOobY}");
        //if (this.transform.position.y < -this._devOobY)
        //{
        //    this.transform.position.Set(this.transform.position.x, this._devOobY, this.transform.position.z);
        //}
    }
}
