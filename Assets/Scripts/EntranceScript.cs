using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceScript : MonoBehaviour {


	public int RoomIndex;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   
	private void OnTriggerEnter(Collider col){
		if(col.gameObject.name=="Player")
		GameManager.Instance.TurnOnCinemaRoom (RoomIndex);
	}

	private void OnTriggerExit(Collider col){
		
		if(col.gameObject.name=="Player")
		GameManager.Instance.TurnOffCinemaRoom (RoomIndex);

	}
}
