using UnityEngine;
using System.Collections;

public class SelectScene : MonoBehaviour {

	public string scene;

	// Use this for initialization
	void Start () {
	
	}
	
	public void OpenScene() {
		Application.LoadLevel(scene);
	}

	public void NextScene(){
		Application.LoadLevel(Application.loadedLevel+1);
	}
	public void PrevScene(){
		Application.LoadLevel(Application.loadedLevel-1);
	}
}
