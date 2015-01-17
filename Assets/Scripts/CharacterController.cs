using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{

    public float Speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKey("up"))
	    {
	        transform.position += Vector3.up * Time.deltaTime * Speed;
	    }
        if (Input.GetKey("down"))
        {
            transform.position += Vector3.down * Time.deltaTime * Speed;
        }
        if (Input.GetKey("left"))
        {
            transform.position += Vector3.left * Time.deltaTime * Speed;
        }
        if (Input.GetKey("right"))
        {
            transform.position += Vector3.right * Time.deltaTime * Speed;
        }

        if (transform.position.y <= -2.5f)
            transform.position = new Vector3(transform.position.x, -2.5f, transform.position.z);
    }
}
