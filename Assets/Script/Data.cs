using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{
	public string userName;
	public string userEmail;
    public string userVideoLink;
	public string userImageLink;
	
	public Data()
	{
		userName = DatabaseController.strUserName;
		userEmail = DatabaseController.strUserEmail;
		userImageLink = DatabaseController.strImageLink;
		userVideoLink = DatabaseController.strVideoLink;
	}
	
}
