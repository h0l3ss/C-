using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBoolValue : MonoBehaviour
{

    public Animator AnimatorChange;
 
    void Start()
    {

        AnimatorChange = GameObject.Find("Cube (39)").GetComponent<Animator>();

    }

    void OnCollisionEnter()
    {

        AnimatorChange.SetBool("liga", true);
   
    }

}

