using UnityEngine;

public class Movement : MonoBehaviour {

	public Rigidbody rd;
	public float gravity = 1.0f;
	public float ForwardForce = 2000f;
	public float SidewaysForce = 40f;
	public float JumpForce = 50f;
	private bool onGround = true;

	// void Start() {

	// 	onGround = true;
	// }

    void FixedUpdate() {

    	rd.AddForce(0, 0, ForwardForce * Time.deltaTime);
    	rd.AddForce(0, -gravity * rd.mass, 0);

        if(Input.GetKey("a") || Input.GetKey("left")) {

        	rd.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("d") || Input.GetKey("right")) {

        	rd.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("space") && onGround == true) { 

        	rd.AddForce(0, JumpForce * Time.deltaTime, 0, ForceMode.Impulse);
        	onGround = false;
        	Debug.Log("Inside if");
        }
    }

    void OnCollisionEnter(Collision col) {

    	if(col.collider.tag == "Platform") {

    		onGround = true;
    	}
	}
}
