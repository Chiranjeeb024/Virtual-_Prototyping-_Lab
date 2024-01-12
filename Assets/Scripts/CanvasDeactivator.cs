using UnityEngine;

public class CanvasDeactivator : MonoBehaviour
{
    // Reference to the Canvas component
    public Canvas canvasToDeactivate;

    public void ToggleCanvas()
    {
        // Toggle the active state of the Canvas
        canvasToDeactivate.gameObject.SetActive(!canvasToDeactivate.gameObject.activeSelf);
    }
}
