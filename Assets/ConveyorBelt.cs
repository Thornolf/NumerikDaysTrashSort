using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 public class ConveyorBelt : MonoBehaviour
{

    public float speed = 15f;
    public float beltSpeed = 1;
    bool on = true;
    Vector2 offset = new Vector2(0f, 0f);


    void OnCollisionStay(Collision obj)
    {
        float beltVelocity = speed * Time.deltaTime;
        obj.gameObject.GetComponent<Rigidbody>().velocity = beltVelocity * transform.forward;
    }

    void Update()
    {
        offset += new Vector2(0, beltSpeed / speed) * Time.deltaTime;
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", offset);
    }
}