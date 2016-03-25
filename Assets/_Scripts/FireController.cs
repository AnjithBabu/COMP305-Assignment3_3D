using UnityEngine;
using System.Collections;

public class FireController : MonoBehaviour {

    public float lifeTime;
    private float dieTIme;

	// Use this for initialization
	void Start () {
        dieTIme = Time.time + lifeTime; 
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= dieTIme)
        {
            Destroy(gameObject);
        }
	}
}
