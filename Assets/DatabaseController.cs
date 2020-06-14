using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;

public class DatabaseController : MonoBehaviour
{
	public InputField userName;
	public InputField userEmail;
    public InputField videoLink;
	public InputField imageLink;
	
	public static string strUserName;
	public static string strUserEmail;
	public static string strVideoLink;
	public static string strImageLink;
	
	
	public void OnSubmit()
	{
		strUserName = userName.text;
		strUserEmail = userEmail.text;
		strImageLink = imageLink.text;
		strVideoLink = videoLink.text;
		PostToDatabase();
		Toast.Instance.Show("Your data has been registered");
	}
	
	public void PostToDatabase()
	{
		Data data = new Data();
		RestClient.Put("https://ardiuno-a1a23.firebaseio.com/"+strUserName+".json",data);
	}
}
