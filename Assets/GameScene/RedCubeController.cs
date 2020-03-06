﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeController : MonoBehaviour {

	public GameObject ParticlePrefab;
    GameObject Saber;
    bool already = false;

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
        if (already) return;
        if (other.gameObject.tag == "Saber")
        {
            this.Saber = GameObject.Find("RedSaber");
            float Rot = Saber.transform.rotation.z;
            if (transform.rotation.z < 0 && Input.GetKey(KeyCode.A))
            {
                already = true;
                Destroy(gameObject);
                GameObject go = Instantiate(ParticlePrefab) as GameObject;
                Vector3 currentPos = transform.position;
                go.transform.position = currentPos;
                GameObject director = GameObject.Find("ScoreDirector");
                director.GetComponent<ScoreDirector>().TmpScoreHit(Rot + 0.1f);
            }
            if (transform.rotation.z > 0 && Input.GetKey(KeyCode.D))
            {
                already = true;
                Destroy(gameObject);
                GameObject go = Instantiate(ParticlePrefab) as GameObject;
                Vector3 currentPos = transform.position;
                go.transform.position = currentPos;
                GameObject director = GameObject.Find("ScoreDirector");
                director.GetComponent<ScoreDirector>().TmpScoreHit(Rot - 0.1f);
            }
            if (transform.rotation.z < 0 && Input.GetKey(KeyCode.D))
            {
                GameObject director = GameObject.Find("ScoreDirector");
                director.GetComponent<ScoreDirector>().TmpScoreMiss();
                Destroy(gameObject);
            }
            if (transform.rotation.z > 0 && Input.GetKey(KeyCode.A))
            {
                GameObject director = GameObject.Find("ScoreDirector");
                director.GetComponent<ScoreDirector>().TmpScoreMiss();
                Destroy(gameObject);
            }
        }
        if (other.gameObject.tag == "Miss")
        {
            Debug.Log("miss");
            GameObject director = GameObject.Find("ScoreDirector");
            director.GetComponent<ScoreDirector>().TmpScoreMiss();
            Destroy(gameObject);
        }
	}
}
