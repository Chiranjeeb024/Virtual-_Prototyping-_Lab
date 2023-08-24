using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animation : MonoBehaviour

{
    public Animator animator; // Reference to the Animator component
    public Button playButton;
    public Button resetButton;

    private void Start()
    {
        // Get references to the buttons and add click event listeners
        playButton.onClick.AddListener(PlayAnimation);
        resetButton.onClick.AddListener(ResetAnimation);
    }

    private void PlayAnimation()
    {
        // Trigger the animation by setting a parameter in the Animator
        animator.SetBool("PlayAnimation", true);
    }

    private void ResetAnimation()
    {
        // Reset the animation by resetting the parameter in the Animator
        animator.SetBool("PlayAnimation", false);
    }
}




