using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copypos : MonoBehaviour
{
    public Material newMaterial; 
    public GameObject objectBase1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == objectBase1)
        {
            
            Renderer baseRenderer = objectBase1.GetComponent<Renderer>();
            if (baseRenderer != null && newMaterial != null)
            {
                baseRenderer.material = newMaterial;
                Debug.Log("Material Color changed!");
            }

            
            Destroy(gameObject);
            Debug.Log("Object part 1 Destroyed!");
        }
    }
}

