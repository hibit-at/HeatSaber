using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeController : MonoBehaviour {

	public GameObject ParticlePrefab;
    GameObject Saber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void Update () {
		
		int direction;

		if(transform.rotation.z < 0){
			direction = 1;
		}else{
			direction = -1;
		}
		transform.Translate(0.02f*direction,0,0);

		if(transform.position.y < -1.6 && transform.position.y > -1.62){
			GameObject director = GameObject.Find("ScoreDirector");
			director.GetComponent<ScoreDirector>().TmpScoreMiss();
		}

		if(transform.position.y<-3){
			Destroy(gameObject);
		}

	}

	void OnTriggerEnter2D(Collider2D other){
        this.Saber = GameObject.Find("RedSaber");
        float Rot = Saber.transform.rotation.z;
        if (transform.rotation.z < 0 && Input.GetKey(KeyCode.A)){
			Destroy(gameObject);
			GameObject go = Instantiate(ParticlePrefab) as GameObject;
			Vector3 currentPos = transform.position;
			go.transform.position = currentPos;
			GameObject director = GameObject.Find("ScoreDirector");
			director.GetComponent<ScoreDirector>().TmpScoreHit(Rot+0.1f);
        }
		if(transform.rotation.z > 0 && Input.GetKey(KeyCode.D)){
			Destroy(gameObject);
			GameObject go = Instantiate(ParticlePrefab) as GameObject;
			Vector3 currentPos = transform.position;
			go.transform.position = currentPos;
			GameObject director = GameObject.Find("ScoreDirector");
			director.GetComponent<ScoreDirector>().TmpScoreHit(Rot-0.1f);
        }
	}
}
