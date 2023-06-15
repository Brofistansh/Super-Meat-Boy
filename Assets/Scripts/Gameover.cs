using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{   private void FixedUpdate() {
    Debug.Log("hmm");
}
private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Oof");
        
        if (other.tag =="Player")
        {
            Debug.Log("Player hi he");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        
    }
    
    

}
