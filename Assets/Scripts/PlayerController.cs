using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float lookSpeed = 1f;
    public Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Translate(Vector3.right * moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.Rotate(Vector3.up * lookSpeed * Input.GetAxis("Mouse X") * Time.deltaTime);
        Quaternion initialRotation = camera.rotation;
        camera.Rotate(Vector3.left * lookSpeed * Input.GetAxis("Mouse Y") * Time.deltaTime);
        if (camera.rotation.x < Mathf.Deg2Rad * -40 || camera.rotation.x > Mathf.Deg2Rad * 40) {
            camera.rotation = initialRotation;
        }
        Debug.Log(camera.rotation.x * Mathf.Rad2Deg);
    }
}
