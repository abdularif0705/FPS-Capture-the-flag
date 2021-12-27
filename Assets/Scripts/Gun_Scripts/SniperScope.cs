using UnityEngine;
using System.Collections;

public class SniperScope : MonoBehaviour {

     public Animator animator;

     private bool isScoped = false; 

     void Update () {
        if (Input.GetButtonDown("Fire2")) {
            isScoped = !isScoped; // opposite of what isScoped is
            animator.SetBool("SniperScope", isScoped); // has to be exact to the name on the animator
        }
     }
}