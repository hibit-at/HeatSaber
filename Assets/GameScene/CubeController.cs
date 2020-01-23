using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	public GameObject BlueParticlePrefab;
    public GameObject RedParticlePrefab;
    GameObject BlueSaber;
    GameObject RedSaber;

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
        this.BlueSaber = GameObject.Find("BlueSaber");
        this.RedSaber = GameObject.Find("RedSaber");
        float Brot = BlueSaber.transform.rotation.z;
        float Rrot = RedSaber.transform.rotation.z;
        if (transform.rotation.z < 0 && Input.GetKey(KeyCode.LeftArrow)){
			Destroy(gameObject);
			GameObject go = Instantiate(BlueParticlePrefab) as GameObject;
            go.transform.parent = transform;
            Vector3 currentPos = transform.position;
			go.transform.position = currentPos;
			GameObject director = GameObject.Find("ScoreDirector");
			director.GetComponent<ScoreDirector>().TmpScoreHit(Brot+0.1f);
        }
		if(transform.rotation.z < 0 && Input.GetKey(KeyCode.A)){
			Destroy(gameObject);
			GameObject go = Instantiate(RedParticlePrefab) as GameObject;
            go.transform.parent = transform;
            Vector3 currentPos = transform.position;
			go.transform.position = currentPos;
			GameObject director = GameObject.Find("ScoreDirector");
			director.GetComponent<ScoreDirector>().TmpScoreHit(Rrot+0.1f);
        }
		if(transform.rotation.z > 0 && Input.GetKey(KeyCode.RightArrow)){
			Destroy(gameObject);
			GameObject go = Instantiate(BlueParticlePrefab) as GameObject;
            go.transform.parent = transform;
            Vector3 currentPos = transform.position;
			go.transform.position = currentPos;
			GameObject director = GameObject.Find("ScoreDirector");
			director.GetComponent<ScoreDirector>().TmpScoreHit(Brot-0.1f);
        }
		if(transform.rotation.z > 0 && Input.GetKey(KeyCode.D)){
			Destroy(gameObject);
			GameObject go = Instantiate(RedParticlePrefab) as GameObject;
            go.transform.parent = transform;
            Vector3 currentPos = transform.position;
			go.transform.position = currentPos;
			GameObject director = GameObject.Find("ScoreDirector");
			director.GetComponent<ScoreDirector>().TmpScoreHit(Rrot-0.1f);
        }
	}
}
