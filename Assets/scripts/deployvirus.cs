using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployvirus : MonoBehaviour
{
	public GameObject virusPrefab;
	public float respawnTime = 10.0f;
	private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector3( -1,0,0));
        StartCoroutine(virusWave());
    }
       private void spawnEnemy(){
		GameObject a = Instantiate(virusPrefab) as GameObject;
		a.transform.position=new Vector2(screenBounds.x * -2,Random.Range(-screenBounds.y,screenBounds.y));
	}
	IEnumerator virusWave(){
		 while(true){
			yield return new WaitForSeconds(respawnTime);
			spawnEnemy();}
	   }
   
}
