using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        this.transform.Translate(Vector3.left * 5f * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Enemy"))
        {
            Debug.Log("Die");
        }
	}

    
    void Jump()
    {
        this.GetComponent<Rigidbody>().AddForce(Vector3.up * 9001f);
    }
}
