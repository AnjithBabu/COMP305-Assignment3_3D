using UnityEngine;
using System.Collections;

public class EnemyHit : MonoBehaviour {

    public GameObject enemy;
    public GameController gameController;

    // private varibles
    private Vector3 playerSpawnPoint;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // check if player has collided with enemy
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemy").gameObject);
            Instantiate(enemy, new Vector3(4.57f, 1.12f, -2.46f), Quaternion.identity);
            this.playerSpawnPoint = new Vector3(5.58f, 1.36f, -7.35f);
            this.gameObject.transform.position = this.playerSpawnPoint;
            gameController.LivesValue -= 1;
        }
    }
}
