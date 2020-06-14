using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

public class register : MonoBehaviour
{

	//private string form;
	//private bool EmailValid = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RegisterButton()
    {/*
    	bool UN = false;
    	bool EM = false;
    	bool PW = false;
    	bool VPW = false;

    	if(Username != "")
    	{
    		if(!System.IO.File.Exists(&"F:/UnityTestFolder/" + Username + ".txt"))
    		{
    			UN = true;
    		}
    		else
    		{
    			Debug.LogWarning("Username Taken");
    		}	
    	}
    	else
    	{
    		Debug.LogWarning("Username Field is Empty");
    	}

    	if(Email != "")
    	{
    		EmailValid = Regex.IsMatch(Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
    		if(EmailValid && Email.Contains("@") && Email.Contains("."))
    		{
    			EM = true;
    		}
    		else
    		{
    			Debug.LogWarning("Email is Incorrect");
    		}
    	}
    	else
    	{
    		Debug.LogWarning("Email Field is Empty");
    	}

    	if(Password != "")
    	{
    		if(Password.Length > 5)
    		{
    			PW = true;
    		}
    		else
    		{
    			Debug.LogWarning("Password Must Be Atleast 6 Characters Long");
    		}

    	}
    	else
    	{
    		Debug.LogWarning("Password Field is Empty");
    	}

    	if(Vpassword != "")
    	{
    		if(Vpassword == Password)
    		{
    			VPW = true;
    		}
    		else
    		{
    			Debug.LogWarning("Password Don't Match");
    		}
    	}
    	else
    	{
    		Debug.LogWarning("Verify Password Field is Empty");
    	}

    	if(UN == true && EM == true && PW == true && VPW == true)
    	{
    		bool Clear = true;
    		int i = 1;
    		foreach(char c in Password)
    		{
    			if(Clear)
    			{
    				Password = "";
    				Clear = false;
    			}
    			i++;
    			char Ecnrypted = (char) (C * i)
    			Password += Encrypted.ToString();
    		}
    		form = (Username + "\n" + Email + "\n" + Password + "\n");
    		System.IO.File.WriteAllText(@"F:/UnityTestFolder/" + Username + ".txt", form);
    		username.GetComponent<InputField>().text = "";
        	email.GetComponent<InputField>().text = "";
        	password.GetComponent<InputField>().text = "";
       		vpassword.GetComponent<InputField>().text = "";
       		Debug.LogWarning("Registration Successful");
       		//print ("Registration Successful");
    	}*/
    }

    // Update is called once per frame
    void Update()
    {
		/*
    	if(Input.GetKeyDown(KeyCode.Tab))
    	{
    		if(username.GetComponent<InputField>().isFocused)
    		{
    			email.GetComponent<InputField>().Select();
    		}
    		if(email.GetComponent<InputField>().isFocused)
    		{
    			password.GetComponent<InputField>().Select();
    		}
    		if(password.GetComponent<InputField>().isFocused)
    		{
    			vpassword.GetComponent<InputField>().Select();
    		}
    		if(vpassword.GetComponent<InputField>().isFocused)
    		{
    			username.GetComponent<InputField>().Select();
    		}
    	}

    	if(Input.GetKeyDown(KeyCode.Return))
    	{
    		if(Username != "" && Email != "" && Password != "" && Vpassword != "")
    		{
    			RegisterButton();
    		}
    	}

        Username = username.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        Vpassword = vpassword.GetComponent<InputField>().text;
		*/
    }
}
