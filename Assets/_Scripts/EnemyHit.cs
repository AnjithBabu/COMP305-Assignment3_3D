/*
 * Sourcefile name : EnemyHit
 * Author’s name: Anjith Babu
 * Last	Modifiedby: Anjith Babu
 * Date	lastModified : March 25, 2016	
 * Program	description: 
 * Used to check if the enemy hit the player
 */

using UnityEngine;
using System.Collections;

public class EnemyHit : MonoBehaviour {

    public GameObject Player;
    public GameController gameController;
    private AudioSource[] audioSources;
    private AudioSource killSound;

    // private varibles
    private Vector3 playerSpawnPoint;


	// Use this for initialization
	void Start () {
        this.audioSources = gameObject.GetComponents<AudioSource>();
        this.killSound = this.audioSources[0];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // check if player has collided with enemy
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {

            this.playerSpawnPoint = new Vector3(5.58f, 1.36f, -7.35f); // reset player to starting point
            this.Player.transform.position = this.playerSpawnPoint;
            gameController.LivesValue -= 1;
            killSound.Play();
        }
    }
}
