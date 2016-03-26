/*
 * Sourcefile name : PlayerFollow
 * Author’s name: Anjith Babu
 * Last	Modifiedby: Anjith Babu
 * Date	lastModified : March 25, 2016	
 * Program	description: 
 * Player Follow is used provide AI for the enemy to folow the player
 */

using UnityEngine;
using System.Collections;

public class PlayerFollow : MonoBehaviour {

    Transform player_tranform;
    float f_rot = 3.0f;
    float f_mov = 1.0f;

	// Use this for initialization
	void Start () {
        player_tranform = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

        // rotate the enemy if player moves to back side of enemy and fix enemy in correct direction towards player
        transform.rotation = Quaternion.Slerp(transform.rotation,
                                Quaternion.LookRotation(player_tranform.position - transform.position)
                                , f_rot * Time.deltaTime);
        transform.position += transform.forward * f_mov * Time.deltaTime; // move the enemy forward
	}
}
