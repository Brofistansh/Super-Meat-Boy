using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCam : MonoBehaviour
{
    public Transform rb;
    public Transform cam;

    private void FixedUpdate() {
        Vector3 position = rb.position;
        position.z = -15;
        position.y = 0;
        
        cam.position = position ;
    }
}
