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

        transform.rotation = Quaternion.Slerp(transform.rotation,
                                Quaternion.LookRotation(player_tranform.position - transform.position)
                                , f_rot * Time.deltaTime);
        transform.position += transform.forward * f_mov * Time.deltaTime;

        //float step = speed * Time.deltaTime;
        //this._target.position = this._player.transform.position;
        //this._transform.position = Vector3.MoveTowards(this._transform.position, this._target.position, step);
        //tansform.pos
	}
}
