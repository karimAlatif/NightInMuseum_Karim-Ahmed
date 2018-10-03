using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private static GameManager instance;
	public static GameManager Instance{ get { return instance; } }  //Make Instance to this game script so i can call it from any othe script


	public List<GameObject> AllVideoPlayer= new List<GameObject>();
	public GameObject SceneLight;

	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TurnOnCinemaRoom(int RoomIndex){

		AllVideoPlayer [RoomIndex].gameObject.SetActive (true); //Turn on room video
		SceneLight.gameObject.SetActive (false); //turn off the light

	}

	public void TurnOffCinemaRoom(int RoomIndex){

		AllVideoPlayer [RoomIndex].gameObject.SetActive (false); //Turn off room video
		SceneLight.gameObject.SetActive (true); //turn on the light

	}
}
