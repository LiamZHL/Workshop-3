// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;

public class XAxisSpin : MonoBehaviour
{
    [SerializeField] private float spinSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float zAxisChange;
    [SerializeField] private Vector3 rotationAxis;
    private float lastFrame;
    //[SerializeField] private Vector3 startPos;
    //[SerializeField] private Vector3 goalPos;
    // Update() is called once *per frame*. It is called *after* the Start()
    // method, which is only called once when the component is enabled for the
    // first time. You'll find that the execution order of these lifecycle
    // methods matters, and this can be fairly nuanced when components reference
    // each other, and/or if you are enabling and disabling components at
    // runtime.
    //
    // Recommended reading:
    // - https://docs.unity3d.com/Manual/ExecutionOrder.html


    private void Update()
    {
        
       
        var rotationAngle = this.rotationSpeed * (Time.time - lastFrame);


        var angle = this.spinSpeed * (Time.time - lastFrame);
        var axis = new Vector3(1.0f, 0.0f, 0.0f);
        transform.localRotation *= Quaternion.AngleAxis(angle, axis);


        transform.RotateAround(new Vector3(0f, 0.0f, 0.0f), transform.right, rotationAngle);





        if (transform.position.z > 5.0f)
        {
            zAxisChange = -zAxisChange;
            transform.position += new Vector3(0f, 0f, zAxisChange * (Time.time - lastFrame));
        }
        else if (transform.position.z < -5.0f)
        {
            zAxisChange = -zAxisChange;
            transform.position += new Vector3(0f, 0f, zAxisChange * (Time.time - lastFrame));
        }
        else
        {
            transform.position += new Vector3(0f, 0f, zAxisChange * (Time.time - lastFrame));
        }

        lastFrame = Time.time;

    }

    

}
