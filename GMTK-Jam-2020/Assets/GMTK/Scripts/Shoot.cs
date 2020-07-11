using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    Camera cam;

    public int ammunition;

    public Manager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }

        if(ammunition <= 0)
        {

        }
    }

    void Fire()
    {
        Vector3 pos, forward;

        Transform camTransform = cam.GetComponent<Transform>();

        pos = camTransform.position;
        forward = camTransform.forward;

        RaycastHit outInfo;

        if(Physics.Raycast(pos, forward, out outInfo, 700f, LayerMask.GetMask("Interact")))
        {
            Interact objInfo;
            if (outInfo.transform.TryGetComponent<Interact>(out objInfo))
            {
                objInfo.Break();
            }
        }
    }
}
