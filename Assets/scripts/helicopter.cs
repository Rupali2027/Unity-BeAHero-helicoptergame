using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.PlayerManagement;

public class helicopter : MonoBehaviour
{
      
    void Update()
    {
        if(Input.GetMouseButton(0))
	{
		transform.Translate(0.01f,0.1f, 0f);
	}
	else{
		transform.Translate(0f, -0.1f,0f);
	}

    }
    private void OnCollisionEnter2D(Collision2D other)
 
{
	if(other.gameObject.tag== "Enemy"){
		playermanager.gameOver = true;
}
}}
