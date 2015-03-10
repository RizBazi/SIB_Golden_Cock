using UnityEngine;
using System.Collections;

public class Action_Khorus_5 : iActive_Action {
	
	
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
		if(count == 1)
		{
			transform.GetChild (0).GetComponent<SpriteRenderer> ().enabled = false;
			transform.GetChild (1).GetComponent<SpriteRenderer> ().enabled = false;
		}
		else{
			transform.GetChild (0).GetComponent<SpriteRenderer> ().enabled = true;
			transform.GetChild (1).GetComponent<SpriteRenderer> ().enabled = true;
		}
		count = (count + 1) % 2;
		yield return new WaitForSeconds (0);
	}
	
	public override IEnumerator Play_Audio ()
	{
		yield return new WaitForSeconds (0);
		
	}
}
