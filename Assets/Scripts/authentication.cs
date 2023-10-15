using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Firebase;
using Firebase.Auth;
using System.Threading.Tasks;
using System;
using TMPro;
public class authentication : MonoBehaviour
{
    FirebaseAuth auth;

    public TMP_InputField emailInput;
    public TMP_InputField passwordInput;
    public Button transitionButton;
    public TextMeshProUGUI debugLogText; // Reference to the Text component

    private void Start()
    {
        auth = FirebaseAuth.DefaultInstance;
        transitionButton.interactable = false;
    }


    public void SignUp()
    {
        string email = emailInput.text;
        string password = passwordInput.text;

        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            if (task.IsCanceled || task.IsFaulted)
            {
                string errorMessage = "Sign-up failed: " + task.Exception;
                Debug.LogError(errorMessage);
                // Display the error message in the Text component
                debugLogText.text = errorMessage;
            }
            else
            {
                Debug.Log("Sign-up successful!");
                transitionButton.interactable = true;
                // Display success message in the Text component
                debugLogText.text = "Sign-up successful!";
            }
        });
    }

    public void Login()
    {
        string email = emailInput.text;
        string password = passwordInput.text;

        auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            if (task.IsCanceled || task.IsFaulted)
            {
                string errorMessage = "Login failed: " + task.Exception;
                Debug.LogError(errorMessage);
                // Display the error message in the Text component
                debugLogText.text = errorMessage;
            }
            else
            {
                Debug.Log("Login successful!");
                transitionButton.interactable = true;
                // Display success message in the Text component
                debugLogText.text = "Login successful!";
            }
        });
    }


    public void MoveToAnotherScene()
    {
        SceneManager.LoadScene("Lab");
    }
}


