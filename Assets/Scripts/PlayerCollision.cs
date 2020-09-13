using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public Movement movement;

    void OnCollisionEnter(Collision col) {

    	if(col.collider.tag == "Obstacle") {

    		movement.enabled = false;
    		Debug.Log("GAME OVER!");
    	} 
    }
}
