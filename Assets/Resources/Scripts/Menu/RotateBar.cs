using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RotateBar : MonoBehaviour {

	public Scrollbar horizontalBar;
	public Scrollbar verticalBar;
	public Scrollbar zoomBar;

	public GameObject gameBoard;

	public void Horizontal(){
		gameBoard.transform.rotation = Quaternion.Euler(new Vector3(gameBoard.transform.rotation.eulerAngles.x,360*(horizontalBar.value),gameBoard.transform.rotation.eulerAngles.z));
	}
	public void Vertical(){
		gameBoard.transform.rotation = Quaternion.Euler(new Vector3(360*(verticalBar.value),gameBoard.transform.rotation.eulerAngles.y,gameBoard.transform.rotation.eulerAngles.z));
	}
	public void Zoom(){
		gameBoard.transform.position = new Vector3(gameBoard.transform.position.x,gameBoard.transform.position.y,-10*(zoomBar.value));
	}
}
