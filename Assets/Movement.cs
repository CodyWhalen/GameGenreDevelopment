using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2.0f;
    public Animator anim;
    
    //anim.SetBool("IsJumping", true);
    
    void Update()
    {
        float xMov = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        this.transform.position = new Vector3(this.transform.position.x + xMov, this.transform.position.y, this.transform.position.z);
    }
}
