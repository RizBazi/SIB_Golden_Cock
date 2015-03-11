using UnityEngine;
using System.Collections;

public class Action_Mard_4 : iActive_Action {


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
		transform.GetChild (count).GetComponent<SpriteRenderer> ().enabled = false;
		count = (count + 1) % 2;
		transform.GetChild (count).GetComponent<SpriteRenderer> ().enabled = true;
		yield return new WaitForSeconds (0);
	}
	
	public override IEnumerator Play_Audio ()
	{
		yield return new WaitForSeconds (0);
		
	}
}