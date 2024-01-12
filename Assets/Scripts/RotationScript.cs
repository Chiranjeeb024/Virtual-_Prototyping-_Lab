using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public float rotationSpeed = 30f; // Adjust the speed as needed

    void Update()
    {
        // Rotate the object around its forward axis (Z-axis) based on the input or a constant speed
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
