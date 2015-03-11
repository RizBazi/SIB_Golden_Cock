using UnityEngine;
using System.Collections;

public class Action_Mard_6 : iActive_Action {
	
	
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
			transform.GetChild (2).GetComponent<SpriteRenderer> ().enabled = false;
			transform.GetChild (3).GetComponent<SpriteRenderer> ().enabled = true;
		}
		else{
			transform.GetChild (0).GetComponent<SpriteRenderer> ().enabled = true;
			transform.GetChild (1).GetComponent<SpriteRenderer> ().enabled = true;
			transform.GetChild (2).GetComponent<SpriteRenderer> ().enabled = true;
			transform.GetChild (3).GetComponent<SpriteRenderer> ().enabled = false;
		}
		count = (count + 1) % 2;
		yield return new WaitForSeconds (0);
	}
	
	public override IEnumerator Play_Audio ()
	{
		yield return new WaitForSeconds (0);
		
	}
}
