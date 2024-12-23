using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{

    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 destination = new Vector3(horizontal, 0, vertical);
        GetComponent<Rigidbody>().velocity = destination * speed;
        //Debug.Log(Input.GetAxisRaw("Horizontal"));
    }
}
