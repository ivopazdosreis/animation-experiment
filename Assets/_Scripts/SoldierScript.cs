using UnityEngine;
using System.Collections;

public class SoldierScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		transform.GetComponent<Animation>().Play ("death");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
