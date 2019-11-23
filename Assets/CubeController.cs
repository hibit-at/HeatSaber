using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	public GameObject ParticlePrefab;

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

		if(transform.position.y < -2 && transform.position.y > -2.1){
			GameObject director = GameObject.Find("ScoreDirector");
			director.GetComponent<ScoreDirector>().TmpScoreMiss();
		}

		if(transform.position.y<-3){
			Destroy(gameObject);
		}

	}

	void OnTriggerEnter2D(Collider2D other){
		if(transform.rotation.z < 0 && Input.GetKey(KeyCode.LeftArrow)){
			Destroy(gameObject);
			GameObject go = Instantiate(ParticlePrefab) as GameObject;
			Vector3 currentPos = transform.position;
			go.transform.position = currentPos;
			GameObject director = GameObject.Find("ScoreDirector");
			director.GetComponent<ScoreDirector>().IncreaseScore();
			director.GetComponent<ScoreDirector>().TmpScoreHit();
		}
		if(transform.rotation.z < 0 && Input.GetKey(KeyCode.A)){
			Destroy(gameObject);
			GameObject go = Instantiate(ParticlePrefab) as GameObject;
			Vector3 currentPos = transform.position;
			go.transform.position = currentPos;
			GameObject director = GameObject.Find("ScoreDirector");
			director.GetComponent<ScoreDirector>().IncreaseScore();
			director.GetComponent<ScoreDirector>().TmpScoreHit();
		}
		if(transform.rotation.z > 0 && Input.GetKey(KeyCode.RightArrow)){
			Destroy(gameObject);
			GameObject go = Instantiate(ParticlePrefab) as GameObject;
			Vector3 currentPos = transform.position;
			go.transform.position = currentPos;
			GameObject director = GameObject.Find("ScoreDirector");
			director.GetComponent<ScoreDirector>().IncreaseScore();
			director.GetComponent<ScoreDirector>().TmpScoreHit();
		}
		if(transform.rotation.z > 0 && Input.GetKey(KeyCode.D)){
			Destroy(gameObject);
			GameObject go = Instantiate(ParticlePrefab) as GameObject;
			Vector3 currentPos = transform.position;
			go.transform.position = currentPos;
			GameObject director = GameObject.Find("ScoreDirector");
			director.GetComponent<ScoreDirector>().IncreaseScore();
			director.GetComponent<ScoreDirector>().TmpScoreHit();
		}
	}
}
