using UnityEngine;
using System.Collections;

public abstract class iActive_Action : MonoBehaviour,IAnimation,IAudio
{
	public bool Can_Access;
	public bool Have_Animation;
	public bool Have_Audio;

	public virtual void Action()
	{
		if(Can_Access)
		{
			if(Have_Animation)
				StartCoroutine(Play_Animation());
			if(Have_Audio)
				StartCoroutine(Play_Audio());
		}
	}
	public virtual IEnumerator Play_Animation ()
	{
		yield return new WaitForSeconds (0);
	}
	public virtual IEnumerator Play_Audio()
	{
		yield return new WaitForSeconds (0);
	}
}
