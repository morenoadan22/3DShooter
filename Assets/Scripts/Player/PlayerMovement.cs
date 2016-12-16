using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed = 6.0f;

    Vector3 movement;
    Animator playerAnimator;
    Rigidbody playerRigidBody;
    int floorMask;
    float camRayLength = 100f;

    void Awake(){

    	floorMask = LayerMask.GetMask("Floor");
    	playerAnimator = GetComponent <Animator> ();
    	playerRigidBody = GetComponent <Rigidbody> ();
    }

    void FixedUpdate(){
    	float h = Input.GetAxisRaw("Horizontal");
    	float v = Input.GetAxisRaw("Vertical");
    	Move(h, v);
    	Turning();
    	Animating(h, v);
    }

    void Move(float h, float v){

    	movement.Set(h, 0f, v);
    	movement = movement.normalized * speed * Time.deltaTime;
    	playerRigidBody.MovePosition ( transform.position + movement );    	    	
    }

    void Turning(){
    	Ray camRay = Camera.main.ScreenPointToRay( Input.mousePosition );
    	RaycastHit floorHit;
    	if( Physics.Raycast ( camRay, out floorHit, camRayLength, floorMask) ){
    		Vector3 playerToMouseRay = floorHit.point - transform.position;
    		playerToMouseRay.y = 0f;

    		Quaternion newRotation = Quaternion.LookRotation(playerToMouseRay);
    		playerRigidBody.MoveRotation(newRotation);
    	}
    }

    void Animating(float h, float v){
    	bool isWalking = h != 0f || v != 0f;
    	playerAnimator.SetBool("IsWalking", isWalking);
    }

}
