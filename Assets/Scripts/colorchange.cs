using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    public float cycleDuration = 2f; // Duration of each color cycle in seconds

    public Camera cameraComponent;
    private Color[] colors = { Color.red, Color.green, Color.blue }; // Add more colors as needed
    private int currentColorIndex = 0;
    private float timeElapsed = 0f;

    void Start()
    {
        cameraComponent = GetComponent<Camera>();
        if (cameraComponent == null)
        {
            Debug.LogError("Camera component not found on the GameObject. Add a Camera component to the GameObject.");
        }
    }

    void Update()
    {
        // Increment timeElapsed based on real time
        timeElapsed += Time.deltaTime;

        // Check if it's time to change color
        if (timeElapsed >= cycleDuration)
        {
            // Reset timeElapsed
            timeElapsed = 0f;

            // Change to the next color
            currentColorIndex = (currentColorIndex + 1) % colors.Length;
            cameraComponent.backgroundColor = colors[currentColorIndex];
        }
    }
}

