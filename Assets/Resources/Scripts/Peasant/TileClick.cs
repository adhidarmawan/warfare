using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Assets.Resources.Scripts.Peasant
{
    public class TileClick : MonoBehaviour
    {
        RaycastHit raycastHit;
        Ray ray;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnMouseDown()
        {
            if (this.gameObject.activeSelf)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out raycastHit, 100, -1))
                {
                    RCast.currentState = RCast.States.HIDE_POPUP;
                    Debug.Log("Tile-nya kena Raycast. State: " + RCast.currentState + ". Tile tag: " + this.tag + ".");
                }
            }
        }
    }
}