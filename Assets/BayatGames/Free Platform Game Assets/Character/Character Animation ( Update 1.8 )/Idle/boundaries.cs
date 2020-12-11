using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaries : MonoBehaviour
{
	private Vector2 screenBounds;
	private float objectHeight;
    // Start is called before the first frame update
    void Start()
    {
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector3( Screen.height, Camera.main.transform.position.z));
        objectHeight= transform.GetComponent<SpriteRenderer>().bounds.size.y/2;
    }

    // Update is called once per frame
    void LateUpdate()
    {
		Vector3 viewPos = transform.position;
		//viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x, screenBounds.x * -1);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y+objectHeight, screenBounds.y * -1-objectHeight);
		transform.position=viewPos;
    }
}
