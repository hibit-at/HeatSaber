using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCubeController : MonoBehaviour {

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
		//transform.Translate(0.02f*direction,0,0);
	}

	void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "Saber")
        {
            this.Saber = GameObject.Find("BlueSaber");
            float Rot = Saber.transform.rotation.z;
            if (transform.rotation.z < 0 && Input.GetKey(KeyCode.LeftArrow))
            {
                Destroy(gameObject);
                GameObject go = Instantiate(ParticlePrefab) as GameObject;
                Vector3 currentPos = transform.position;
                go.transform.position = currentPos;
                GameObject director = GameObject.Find("ScoreDirector");
                director.GetComponent<ScoreDirector>().TmpScoreHit(Rot + 0.1f);
            }
            if (transform.rotation.z > 0 && Input.GetKey(KeyCode.RightArrow))
            {
                Destroy(gameObject);
                GameObject go = Instantiate(ParticlePrefab) as GameObject;
                Vector3 currentPos = transform.position;
                go.transform.position = currentPos;
                GameObject director = GameObject.Find("ScoreDirector");
                director.GetComponent<ScoreDirector>().TmpScoreHit(Rot - 0.1f);
            }
            if (transform.rotation.z < 0 && Input.GetKey(KeyCode.RightArrow))
            {
                GameObject director = GameObject.Find("ScoreDirector");
                director.GetComponent<ScoreDirector>().TmpScoreMiss();
                Destroy(gameObject);
            }
            if (transform.rotation.z > 0 && Input.GetKey(KeyCode.LeftArrow))
            {
                GameObject director = GameObject.Find("ScoreDirector");
                director.GetComponent<ScoreDirector>().TmpScoreMiss();
                Destroy(gameObject);
            }
        }
        if (other.gameObject.tag == "Miss")
        {
            GameObject director = GameObject.Find("ScoreDirector");
            director.GetComponent<ScoreDirector>().TmpScoreMiss();
            Destroy(gameObject);
        }
    }
}
