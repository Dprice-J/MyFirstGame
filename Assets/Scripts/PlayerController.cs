using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Translate(Vector3.right * moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
    }
}
