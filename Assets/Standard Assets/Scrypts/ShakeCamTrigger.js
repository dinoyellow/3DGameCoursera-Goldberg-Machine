 #pragma strict
 
 var DragCamShakeEfectHere : GameObject;
 
 function Start ()
 {
     DragCamShakeEfectHere.GetComponent.<ShakeCam>().enabled = false;
 }
      
 function OnTriggerEnter (col : Collider)
 {
     if (col.tag == "Player")
     {
         DragCamShakeEfectHere.GetComponent.<ShakeCam>().enabled = true;
     }
 }
      
 function OnTriggerExit ()
 {
     DragCamShakeEfectHere.GetComponent.<ShakeCam>().enabled = false;
 }