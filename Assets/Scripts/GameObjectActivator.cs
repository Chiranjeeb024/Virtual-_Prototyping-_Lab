using UnityEngine;

public class GameObjectActivator : MonoBehaviour
{
    public GameObject[] objectsToToggle;

    public void ToggleGameObjects(int objectIndex)
    {
        foreach (GameObject obj in objectsToToggle)
        {
            obj.SetActive(false);
        }

        if (objectIndex >= 0 && objectIndex < objectsToToggle.Length)
        {
            objectsToToggle[objectIndex].SetActive(true);
        }
    }
}
