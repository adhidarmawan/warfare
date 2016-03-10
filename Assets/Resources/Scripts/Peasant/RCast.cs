using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Assets.Resources.Scripts.Peasant
{
    public class RCast : MonoBehaviour
    {
        public enum States { IDLE, SHOW_POPUP, HIDE_POPUP }
        public static States currentState;
        RaycastHit raycastHit;
        Ray ray;
        public static bool popupTriggered;
        public GameObject tile;
        GameObject leftTile;
        GameObject rightTile;
        GameObject frontTile;
        GameObject backTile;

        // Use this for initialization
        void Start()
        {
            //popupTriggered = false;
            Debug.Log(this.gameObject.tag);
            leftTile = Instantiate(tile, transform.position + new Vector3(-1, 0, 0), Quaternion.identity) as GameObject;
            leftTile.tag = "Left Tile";
            rightTile = Instantiate(tile, transform.position + new Vector3(+1, 0, 0), Quaternion.identity) as GameObject;
            rightTile.tag = "Right Tile";
            frontTile = Instantiate(tile, transform.position + new Vector3(0, 0, -1), Quaternion.identity) as GameObject;
            frontTile.tag = "Front Tile";
            backTile = Instantiate(tile, transform.position + new Vector3(0, 0, +1), Quaternion.identity) as GameObject;
            backTile.tag = "Back Tile";
            hideTiles();
        }

        // Update is called once per frame
        void Update()
        {
            if (currentState == States.HIDE_POPUP)
            {
                hidePopupMenu();
            }
        }

        void OnMouseDown()
        {
            if (currentState == States.IDLE)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out raycastHit, 1000, -1))
                {
                    Debug.Log("Kena Raycast. State: " + currentState);
                    currentState = States.SHOW_POPUP;
                }
            }
        }

        void OnGUI()
        {
            Debug.Log("masuk OnGUI");
            if (currentState == States.SHOW_POPUP)
            {
                showPopupMenu();
                showTiles();
            }
        }

        void showPopupMenu()
        {
            if (GUI.Button(new Rect(100, 100, 100, 50), "Create Peasant"))
            {
                Debug.Log("masuk Create Peasant");
                currentState = States.HIDE_POPUP;
            }

            if (GUI.Button(new Rect(100, 150, 100, 50), "Action"))
            {
                Debug.Log("masuk Action");
                currentState = States.HIDE_POPUP;
            }

            if (GUI.Button(new Rect(100, 200, 100, 50), "Convert"))
            {
                Debug.Log("masuk Convert");
                currentState = States.HIDE_POPUP;
            }

            if (GUI.Button(new Rect(100, 250, 100, 50), "Create Building"))
            {
                Debug.Log("masuk Create Building");
                currentState = States.HIDE_POPUP;
            }

            if (GUI.Button(new Rect(100, 300, 100, 50), "Cancel"))
            {
                Debug.Log("masuk Cancel");
                currentState = States.HIDE_POPUP;
            }
        }

        void showTiles()
        {
            leftTile.SetActive(true);
            rightTile.SetActive(true);
            frontTile.SetActive(true);
            backTile.SetActive(true);
        }

        void hidePopupMenu()
        {
            currentState = States.HIDE_POPUP;
            hideTiles();
        }

        void hideTiles()
        {
            leftTile.SetActive(false);
            rightTile.SetActive(false);
            frontTile.SetActive(false);
            backTile.SetActive(false);

            currentState = States.IDLE;
        }
    }
}