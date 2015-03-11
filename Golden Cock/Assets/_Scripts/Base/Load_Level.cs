using UnityEngine;
using System.Collections;

public class Load_Level : iActive_Action
{
	public string Level_Name;
	public override void Action ()
	{
		Application.LoadLevel (Level_Name);
	}
}
