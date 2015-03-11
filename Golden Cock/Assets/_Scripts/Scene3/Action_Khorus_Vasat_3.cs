using UnityEngine;
using System.Collections;

public class Action_Khorus_Vasat_3 : iActive_Action {
	
	//public AudioClip audio;
	
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
		transform.GetComponent<Animator> ().SetTrigger ("khorus vasat");
		yield return new WaitForSeconds (0);
	}
	
	public override IEnumerator Play_Audio ()
	{
		yield return new WaitForSeconds (0);
		
	}
}
