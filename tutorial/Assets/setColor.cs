using UnityEngine;
using System.Collections;

public class setColor : MonoBehaviour {

    public GameObject obj;

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color = Color.red;

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
