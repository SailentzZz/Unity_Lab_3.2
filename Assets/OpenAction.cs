using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Open(GameObject obj)
	{
		obj.SetActive(true);
	}
}
