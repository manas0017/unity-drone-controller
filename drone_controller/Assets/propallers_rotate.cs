using UnityEngine;

public class DroneController : MonoBehaviour
{
    public Transform bladesCenter;  // Assign the center of the blades to this field
    public float rotationSpeed = 100.0f;

    void Update()
    {
        RotateBlades();
    }

    void RotateBlades()
    {
        // Rotate the blades around the local Z-axis from their center
        bladesCenter.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
