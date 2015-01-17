using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour
{
    public float Speed = 2f;
    public float[] Pos = new float[3];


	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
	{
	    transform.position -= Vector3.right * Time.deltaTime * Speed;
        if (transform.position.x <= -19)
	    {
            transform.position = new Vector3(Pos[0], Pos[1], Pos[2]);
	    }
	}
} 