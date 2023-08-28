using UnityEngine;

public class CanvasActivator : MonoBehaviour
{
    public Canvas canvasToToggle;

    public void ToggleCanvas()
    {
        canvasToToggle.gameObject.SetActive(!canvasToToggle.gameObject.activeSelf);
    }
}
