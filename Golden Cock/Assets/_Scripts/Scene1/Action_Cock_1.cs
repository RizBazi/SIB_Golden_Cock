using UnityEngine;
using System.Collections;

public class Action_Cock_1 : iActive_Action {

	public Sprite[] sprites;
	private int count = 0; 
	
	public override void Action ()
	{
//		if(Can_Access)
//		{
//			if(Have_Animation)
//				StartCoroutine(Play_Animation());
//			if(Have_Audio)
//				StartCoroutine(Play_Audio());
//		}
	}
	
	public override IEnumerator Play_Animation ()
	{
		count = (count + 1) % 2;
		yield return new WaitForSeconds (0);
		transform.GetComponent<SpriteRenderer> ().sprite = sprites [count];
	}
	
	public override IEnumerator Play_Audio ()
	{
		yield return new WaitForSeconds (0);
	}
}
