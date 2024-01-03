using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GateController : MonoBehaviour
{
    public Animator gateAnimator;
    public bool isPlayerNear = false;

    public void OnTriggerEnter(Collider other)
    {
        XRBaseController xrController = other.GetComponent<XRBaseController>();

        if (xrController != null)
        {
            // XR Controller (Player) is near, trigger the gate opening animation
            isPlayerNear = true;
            gateAnimator.SetTrigger("OpenTrigger");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        XRBaseController xrController = other.GetComponent<XRBaseController>();

        if (xrController != null)
        {
            // XR Controller (Player) has moved away, trigger the gate closing animation
            isPlayerNear = false;
            gateAnimator.SetTrigger("CloseTrigger");
        }
    }

    // Additional method to manually open/close the gate (optional)
    public void OpenGate()
    {
        if (!isPlayerNear)
        {
            gateAnimator.SetTrigger("OpenTrigger");
        }
    }

    public void CloseGate()
    {
        if (!isPlayerNear)
        {
            gateAnimator.SetTrigger("CloseTrigger");
        }
    }
}