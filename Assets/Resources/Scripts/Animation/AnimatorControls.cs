using UnityEngine;
using System.Collections;

public class AnimatorControls : MonoBehaviour {

	public Animator thisAnimator;

	public void StopAnimation(){
		thisAnimator.Stop();
	}
	public void StartAnimation(){
		thisAnimator.StartPlayback();
	}
	// Update is called once per frame
	void Update () {
	
	}
}
