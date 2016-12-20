using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class uiManagementScript : MonoBehaviour {

	GameObject[] pauseObjects;
	GameObject[] gameOverObjects;

		public static bool isGameOver;

	// Use this for initialization
	void Start () {
//		isGameOver = false;
//		Time.timeScale = 1;
//		pauseObjects = GameObject.FindGameObjectsWithTag("onPause");
//		gameOverObjects = GameObject.FindGameObjectsWithTag("onGameOver");
//		hidePaused();
//		hideGameOver();
	}

//void hideGameOver() {
//	foreach(GameObject g in gameOverObjects){
//		g.SetActive(false);
//	}
//
//}
//public void loadGameOver() {
//	//gameOverObjects = GameObject.FindGameObjectsWithTag("onGameOver");
//	foreach(GameObject g in gameOverObjects){
//		g.SetActive(true);
//	}
//}
//	//shows objects with ShowOnPause tag
//	void showPaused(){
//
//		foreach(GameObject g in pauseObjects){
//			g.SetActive(true);
//		}
//	}
//
//	//hides objects with ShowOnPause tag
//	void hidePaused(){
//		foreach(GameObject g in pauseObjects){
//			g.SetActive(false);
//		}
//	}
//
//
//
//
//
//	public void resume() {
//		Time.timeScale = 1;
//		hidePaused();
//	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
		{
			print("hello!");
//			if ( Time.timeScale == 1 ) {
//				print( "PAUSED");
//					Time.timeScale = 0;
//					showPaused();
//			} else if (Time.timeScale == 0) {
//				print ("Resume");
//				Time.timeScale = 1;
//				hidePaused();
//			}
	}
//	if ( isGameOver ) {
//		if ( Time.timeScale == 1 ) {
//				Time.timeScale = 0;
//				loadGameOver();
//		}
//	}
}

}
