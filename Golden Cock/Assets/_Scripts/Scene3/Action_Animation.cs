using UnityEngine;
using System.Collections;

public class Action_Animation : iActive_Action {
	
	public string Animation_trigger;
	
	public override void Action ()
	{
		if(Can_Access)
		{
			if(Have_Animation)
				StartCoroutine(Play_Animation());
			if(Have_Audio)
				StartCoroutine(Play_Audio());
		}
	}
	
	public override IEnumerator Play_Animation ()
	{
		transform.GetComponent<Animator> ().SetTrigger (Animation_trigger);
		yield return new WaitForSeconds (0);
	}
	
	public override IEnumerator Play_Audio ()
	{
		yield return new WaitForSeconds (0);
	}
}

