using UnityEngine;
using System.Collections;

public class Action_Animation_Audio : iActive_Action
{
	public string trigger_name;
	public override void Action ()
	{
		base.Action ();
	}
	public override IEnumerator Play_Animation ()
	{
		if(!trigger_name.Equals(""))
			GetComponent<Animator> ().SetTrigger (trigger_name);
		yield return new WaitForSeconds (0);
	}
	public override IEnumerator Play_Audio ()
	{
		audio.Play ();
		yield return new WaitForSeconds (audio.clip.length);
	}
}
