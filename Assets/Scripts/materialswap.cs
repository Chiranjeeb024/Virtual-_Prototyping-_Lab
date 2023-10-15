using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialswap : MonoBehaviour
{
    public Material material1;
    public Material material2;
    public Material material3;
    public Material originalMaterial;
    public GameObject objectToChangeMaterial;

    void Start()
    {
        // Set the original material
        objectToChangeMaterial.GetComponent<Renderer>().material = originalMaterial;
    }

    public void OnButton1Click()
    {
        // Change material to material1
        objectToChangeMaterial.GetComponent<Renderer>().material = material1;
    }

    public void OnButton2Click()
    {
        // Change material to material2
        objectToChangeMaterial.GetComponent<Renderer>().material = material2;
    }

    public void OnButton3Click()
    {
        // Change material to material3
        objectToChangeMaterial.GetComponent<Renderer>().material = material3;
    }

    public void OnResetButtonClick()
    {
        // Reset to the original material
        objectToChangeMaterial.GetComponent<Renderer>().material = originalMaterial;
    }
}
