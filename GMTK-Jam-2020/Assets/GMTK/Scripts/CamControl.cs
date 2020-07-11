using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public float lowerLimit = -89f;
    public float upperLimit = 30f;

    public Vector2 camMove;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        camMove.x -= Input.GetAxis("Mouse Y");
        camMove.y += Input.GetAxis("Mouse X");

        camMove.x = Mathf.Clamp(camMove.x, lowerLimit, upperLimit);

        Quaternion camRot = Quaternion.Euler(camMove.x, camMove.y, 0f);

        GetComponent<Transform>().rotation = camRot;
    }

    void OnDestroy()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
