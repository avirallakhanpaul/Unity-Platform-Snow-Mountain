using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    
	public Transform Follow;
	public Vector3 offset;

    void Update() {

    	transform.position = Follow.position + offset;
    }
}
