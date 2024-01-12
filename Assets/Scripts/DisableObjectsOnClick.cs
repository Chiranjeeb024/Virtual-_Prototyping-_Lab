using UnityEngine;

public class DisableObjectsOnClick : MonoBehaviour
{
    // An array of game objects to be disabled
    public GameObject[] objectsToDisable;

    public void DisableObjects()
    {
        // Loop through each object in the array and disable it
        foreach (GameObject obj in objectsToDisable)
        {
            obj.SetActive(false);
        }
    }
}
