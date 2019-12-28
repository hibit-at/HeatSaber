using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour {

	public GameObject BlueCubePrefab;
	public GameObject RedCubePrefab;
	public int count = 0;
	float span = 1.0f;
	float delta = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.delta += Time.deltaTime;
		if(this.delta > this.span && count < 52){
			this.delta = 0;
			count += 1;
			int kind = Random.Range(0,4);
			if(kind == 0){
				GameObject go = Instantiate(RedCubePrefab) as GameObject;
				go.transform.position = new Vector3(-1.5f,6,0);
				go.transform.Rotate(0,0,90);
                go.transform.parent = transform;
			}else if(kind == 1){
				GameObject go = Instantiate(RedCubePrefab) as GameObject;
				go.transform.position = new Vector3(-1.5f,6,0);
				go.transform.Rotate(0,0,-90);
                go.transform.parent = transform;
            }
            else if(kind == 2){
				GameObject go = Instantiate(BlueCubePrefab) as GameObject;
				go.transform.position = new Vector3(1.5f,6,0);
				go.transform.Rotate(0,0,90);
                go.transform.parent = transform;
            }
            else{
				GameObject go = Instantiate(BlueCubePrefab) as GameObject;
				go.transform.position = new Vector3(1.5f,6,0);
				go.transform.Rotate(0,0,-90);
                go.transform.parent = transform;
            }
		}
	}
}
