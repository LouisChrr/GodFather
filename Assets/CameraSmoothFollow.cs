using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmoothFollow : MonoBehaviour
{
        public Transform t1,t2,t3,t4;
        public List<Transform> transforms;
        public Camera cam;

        private void Start() {
            cam = this.GetComponent<Camera>();
        }


   // Follow Two Transforms with a Fixed-Orientation Camera
 public void FixedCameraFollowSmooth()
 {
     // How many units should we keep from the players
     float zoomFactor = 1.5f;
     float followTimeDelta = 0.8f;
 
     // Midpoint we're after
     Vector3 transformes = new Vector3(0,0,0);
        foreach(Transform tf in transforms){
transformes+=tf.position;
        }

     Vector3 midpoint = (transformes) / 2f;
 
     // Distance between objects
     transformes = new Vector3(0,0,0);
        foreach(Transform tf in transforms){
transformes+=tf.position;
        }
     float distance = (t1.position - t2.position).magnitude;
 
     // Move camera a certain distance
     Vector3 cameraDestination = midpoint - cam.transform.forward * distance * zoomFactor;
 
     // Adjust ortho size if we're using one of those
     if (cam.orthographic)
     {
         // The camera's forward vector is irrelevant, only this size will matter
         cam.orthographicSize = distance;
     }
     // You specified to use MoveTowards instead of Slerp
     cam.transform.position = Vector3.Slerp(cam.transform.position, cameraDestination, followTimeDelta);
         
     // Snap when close enough to prevent annoying slerp behavior
     if ((cameraDestination - cam.transform.position).magnitude <= 0.05f)
         cam.transform.position = cameraDestination;
 }
}
