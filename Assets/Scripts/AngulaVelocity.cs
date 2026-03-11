using UnityEngine;
using UnityEngine.InputSystem;

public class AngulaVelocity : MonoBehaviour
{
    public float angularSpeed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, angularSpeed, 0);
        }
        else
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
