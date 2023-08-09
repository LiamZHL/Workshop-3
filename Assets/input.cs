using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    private float moveSpeed = 20f;
    private float yValue = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Mouse X") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Mouse Y") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }


}
