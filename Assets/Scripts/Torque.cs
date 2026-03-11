using UnityEngine;

public class Torque : MonoBehaviour
{
    public float torqueSpeed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            rb.AddTorque(Vector3.forward * torqueSpeed);
        }
    }
}
