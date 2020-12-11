﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virus : MonoBehaviour
{
	public float speed= 3.0f;
	private Rigidbody2D rb;
	private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
		rb=this.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(-speed,0);
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(-1,0,0));
        
    }

    // Update is called once per frame
 void Update()
    {
		if(transform.position.x<screenBounds.x){
			Destroy(this.gameObject);
		}
        
    }
}
