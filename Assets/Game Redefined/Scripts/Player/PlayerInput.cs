using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{


    

    // Start is called before the first frame update
    private struct PlayerInputConstants {
        public const string Horizontal = "Horizontal";
        public const string Jump = "Jump";
        public const string Vertical = "Vertical";

    }



    void Update()
    {
        // Debug.Log(isInputButtonDown());
        
    }
   


    public bool isInputButtonDown() {
        bool isTouchDown = Input.GetTouch(0).phase == TouchPhase.Began ? isTouchDown = true : isTouchDown = false;
        bool isMouseDown = Input.GetMouseButtonDown(0);
        if (isMouseDown) {
            return isMouseDown;
        } else {
            return isTouchDown;
        }
        // return isMouseDown || isTouchDown;
    }

    public bool isInputButtonUp() {
        bool isTouchUp = Input.GetTouch(0).phase == TouchPhase.Ended ? isTouchUp = true : isTouchUp = false;
        bool isMouseUp = Input.GetMouseButtonDown(0);
        if(isMouseUp) {
            return isMouseUp;
        } else {
            return  isTouchUp;
        }
    }

    public Vector3 InputPosition() {
        if (Input.touchCount == 1) {
            return Input.GetTouch(0).position;
        } 
        else {
            return Input.mousePosition;
        }
    }

   // public void InputPosition() {
//         inputPosition =  Input.GetTouch(0).position;
//         inputPosition = Input.mousePosition;

//     }
}
