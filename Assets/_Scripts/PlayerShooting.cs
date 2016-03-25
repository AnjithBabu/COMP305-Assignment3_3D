using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject magicFlash;
    public GameObject impactFlash;

    public GameController gameController;

    // private varriables
    private Transform _transform;

	// Use this for initialization
	void Start () {
	   this._transform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(this.magicFlash, spawnPoint.position, Quaternion.identity);

            RaycastHit hit; //stores the information of the ray

            if (Physics.Raycast(this._transform.position, this._transform.forward, out hit, 60f))
            {
                Instantiate(this.impactFlash, hit.point, Quaternion.identity);
            }
        }
    }
}
