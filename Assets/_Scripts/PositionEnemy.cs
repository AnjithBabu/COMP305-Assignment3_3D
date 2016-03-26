/*
 * Sourcefile name : PositionEnemy
 * Author’s name: Anjith Babu
 * Last	Modifiedby: Anjith Babu
 * Date	lastModified : March 25, 2016	
 * Program	description: 
 * It is used to bring back the enemy if it falls of the plane.
 */

using UnityEngine;
using System.Collections;

public class PositionEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.transform.position.y < 0.5)
        {
            this.gameObject.transform.position = new Vector3(4.57f, 1.12f, -2.46f);
        }
	}
}
