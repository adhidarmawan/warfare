using UnityEngine;
using System.Collections;

public class MenuControl : MonoBehaviour {

	public GameObject options;

	public void ToggleOptions(){
		options.SetActive(!options.activeInHierarchy);
	}

}