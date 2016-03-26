/*
 * Sourcefile name : Player Shooting
 * Author’s name: Anjith Babu
 * Last	Modifiedby: Anjith Babu
 * Date	lastModified : March 25, 2016	
 * Program	description: 
 * Used to control the player wand firing and hitting of the object
 */

using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject magicFlash;
    public GameObject impactFlash;
    public GameObject magicExplosion;
    

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
                if (hit.transform.gameObject.CompareTag("Chest"))
                {
                    // start the explosion, destroy the object and increase score by 100
                    Instantiate(this.magicExplosion, hit.point, Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                    this.gameController.ScoreValue += 100;
                }
                Instantiate(this.impactFlash, hit.point, Quaternion.identity);
            }
        }
    }

    
}
