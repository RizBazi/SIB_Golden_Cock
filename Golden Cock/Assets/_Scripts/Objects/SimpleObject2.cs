using UnityEngine;
using System.Collections;


public class SimpleObject2 : iActive_Action
{
	[System.Serializable]
	public struct Play_State
	{
		public string trigger_name;
		public AudioClip audio;
	}

	public System.Collections.Generic.List<Play_State> a = new System.Collections.Generic.List<Play_State> ();

	void Start ()
	{
	}

	void Update ()
	{
	}

	public override void Action ()
	{

	}
}
