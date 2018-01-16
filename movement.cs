using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{

    public GameObject obj;
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, 0, 1);
        Vector3 pos = obj.transform.localPosition;
        Renderer ren = GetComponent<Renderer>();
        ren.material.shader = Shader.Find("Standard");
        if (pos.z > -5 && pos.z <= -2)
        {

            ren.material.SetColor("_Color", Color.red);

        }
        else if (pos.z > -2 && pos.z <= 1)
        {

            ren.material.SetColor("_Color", Color.blue);

        }
        else if (pos.z > 1 && pos.z <= 5)
        {
            ren.material.SetColor("_Color", Color.green);

        }
    }
}
