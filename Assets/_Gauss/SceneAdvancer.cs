using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneAdvancer : MonoBehaviour {
	//public float timeRemainingInScene = 20.0f; //custimize time (s) for each level if desired
	public float DoubleClickBuffer = 1.0f; 
	public bool lastScene = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//timeRemainingInScene -= Time.deltaTime;
		DoubleClickBuffer-= Time.deltaTime;
		//if (timeRemainingInScene <= 0) {
		//if (DoubleClickBuffer < 0) {
		if (Input.GetMouseButtonDown (0) &&DoubleClickBuffer < 0) {
				if (lastScene) {
					SceneManager.LoadScene (0);
				} else {
					int nextScene = SceneManager.GetActiveScene ().buildIndex + 1;
					SceneManager.LoadScene (nextScene);
				}
			}
		//}
	}
		
}
