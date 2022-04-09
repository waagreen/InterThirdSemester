using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visao : MonoBehaviour
{
    public float mouseSense;
    public Transform focus;
    float rotX;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float rotY = Input.GetAxis("Mouse X") * mouseSense;
        transform.Rotate(0, rotY, 0);

        rotX -= Input.GetAxis("Mouse Y") * mouseSense;
        rotX = Mathf.Clamp(rotX, -60, 60);
        focus.localEulerAngles = new Vector3(rotX, 0, 0);
    }
}
