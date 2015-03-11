using UnityEngine;
using System.Collections;

public class Action_Dar_2 : iActive_Action {
	
	private int count = 0;
	
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
		count = (count + 1) % 2;

		if(count == 1)
			transform.GetComponent<Animator> ().SetTrigger ("darbaz");
		else
			transform.GetComponent<Animator>().SetTrigger("darbaste");
		yield return new WaitForSeconds (1);
	}
	
	public override IEnumerator Play_Audio ()
	{
		yield return new WaitForSeconds (0);
		
	}
}
