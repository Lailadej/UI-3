using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField inputPassword;
    public string password = "manzana";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckPassword()
    {

        if (inputPassword.text == password)
        {
            Debug.Log("Access granted");
        }

        else
        {
            Debug.Log("Access denied");
        }

     }

    }
