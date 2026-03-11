using UnityEngine;
using UnityEngine.InputSystem;

public class MagnusSoccerKick : MonoBehaviour
{
    public float kickForce;
    public float spinAmount;
    public float magnusStrength = 0.5f;

    Rigidbody rb;
    bool isShot = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !isShot)
        {
            rb.AddForce(Vector3.left * kickForce, ForceMode.Impulse);

            rb.AddTorque(Vector3.up * spinAmount);
            isShot = true;
        }
    }
    void FixedUpdate()
    {
        if (!isShot) return;
        Vector3 velocity = rb.linearVelocity;
        Vector3 spin = rb.angularVelocity;
        Vector3 magnusforce = magnusStrength * Vector3.Cross(spin, velocity);

        rb.AddForce(magnusforce);
    }
}
