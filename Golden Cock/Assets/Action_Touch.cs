using UnityEngine;
using System.Collections;

public class Action_Touch : iActive_Action {

	public Sprite[] sprites;

	
	public override void Action ()
	{
		print (123);
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
		yield return new WaitForSeconds (0);
		transform.GetComponent<SpriteRenderer> ().sprite = sprites [0];
	}

	public override IEnumerator Play_Audio ()
	{
		yield return new WaitForSeconds (0);
		print ("Play_Audio");
	}
}
