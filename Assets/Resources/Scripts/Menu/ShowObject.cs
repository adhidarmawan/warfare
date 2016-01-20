using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShowObject : MonoBehaviour {

	public GameObject main;

	public List<GameObject> others;

	public void Show () {
		main.SetActive(true);
		for(int i=0; i<others.Count; i++){
			others[i].SetActive(false);
		}
	}
}
