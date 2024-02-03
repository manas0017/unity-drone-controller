using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // The drone's transform
    public Vector3 offset = new Vector3(0f, 5f, -10f);  // Adjust this to set the camera's position relative to the drone
    public float smoothSpeed = 0.5f;  // Adjust this to control the smoothness of camera movement

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogError("CameraFollow: Target not set!");
            return;
        }

        // Calculate the desired position for the camera
        Vector3 desiredPosition = target.position + offset;

        // Smoothly move the camera towards the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Update the camera's position
        transform.position = smoothedPosition;

        // Make the camera look at the drone
        transform.LookAt(target);
    }
}
