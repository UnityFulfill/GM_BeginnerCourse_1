using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // #1. 속력 바꾸기
        // rigid.velocity = new Vector3(2, 4, 3);

        // #2. 힘을 가하기
        // if(Input.GetButtonDown("Jump")) {
        //     rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
        // }
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);
        rigid.AddForce(vec, ForceMode.Impulse);


        // #3. 회전력
        // rigid.AddTorque(Vector3.back);
    }

    private void OnTriggerStay(Collider collider) {
        if(collider.name == "Cube") {
            rigid.AddForce(Vector3.up*2, ForceMode.Impulse);
        }
    }

    public void Jump() {
        rigid.AddForce(Vector3.up*20, ForceMode.Impulse);
    }
}
