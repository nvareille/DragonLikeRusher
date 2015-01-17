using UnityEngine;
using System.Collections;

public class DifficultyInc : MonoBehaviour
{
    private float Difficulty;
    public GameObject[] Objects;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Difficulty < 30f)
	    {
	        Difficulty += 0.02f;
	        Objects[0].GetComponent<BackgroundScroller>().Speed += 0.02f;
	        Objects[1].GetComponent<BackgroundScroller>().Speed += 0.02f;
	        Objects[2].GetComponent<BackgroundScroller>().Speed += 0.01f;
	        Objects[3].GetComponent<BackgroundScroller>().Speed += 0.01f;
	    }
	}
}
