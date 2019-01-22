using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
	public bool isGrounded;

	public float speed = 20;
	public float turnSpeed = 15;

	public Vector3 velocity;

	private Rigidbody rb;
	private float horizontal;
	private float vertical;

	public float distToGround;


	// get the distance to ground


	bool IsGrounded(isGroun): 
    {
		return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1);
	}

{
	if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
	{
		rigidbody.velocity.y = jumpSpeed;
	}
}

void Start()
{
	distToGround = collider.bounds.extents.y;
	rb = GetComponent<Rigidbody>();
}

void FixedUpdate()
{
	vertical = Input.GetAxis("Vertical");
	horizontal = Input.GetAxis("Horizontal");

	Turn(); AcelerateAndStop();
}

private void AcelerateAndStop()
{
	if (vertical > 0)
	{
		velocity = (vertical * transform.forward) * speed;
		velocity.y = rb.velocity.y;

		rb.velocity = velocity;
		//rb.velocity = (transform.forward * vertical) * speed;
		//rb.AddForce((transform.forward * vertical),ForceMode.VelocityChange);



	}
	else
	{
		//rb.velocity = transform.forward * vertical * speed;
		//rb.AddForce((transform.forward * vertical), ForceMode.VelocityChange);
	}
}

private void Turn()
{
	if (horizontal != 0)
	{
		transform.Rotate((transform.up * horizontal) * turnSpeed);

		//Quaternion quad = Quaternion.AngleAxis((horizontal * turnSpeed), transform.up) * transform.rotation;
		//rb.MoveRotation(quad);
		//float mag = rb.velocity.magnitude;
		//rb.velocity = transform.forward * mag * 0.995f;
	}
}
}






