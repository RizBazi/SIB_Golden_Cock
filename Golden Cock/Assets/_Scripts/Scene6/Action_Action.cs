using UnityEngine;
using System.Collections;

public class Action_Action : iActive_Action
{
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
		foreach(SpriteRenderer tsr in gameObject.GetComponentsInChildren<SpriteRenderer>())
			tsr.enabled = !tsr.enabled;
		yield return new WaitForSeconds (0);
	}
	
	public override IEnumerator Play_Audio ()
	{
		yield return new WaitForSeconds (0);
	}
}
