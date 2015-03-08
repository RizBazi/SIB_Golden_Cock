using UnityEngine;
using System.Collections;

public class Screen_Manager : MonoBehaviour
{
	public ScreenOrientation screen_orientation;
	public int sleeptimeout = -1;
	ScreenOrientation Pre_Screen_Oriention;

	void Start ()
	{
		Pre_Screen_Oriention = Screen.orientation;
		if(sleeptimeout == 0)
			Screen.sleepTimeout = SleepTimeout.NeverSleep;
		else
			Screen.sleepTimeout = sleeptimeout;
	}

	void FixedUpdate ()
	{
		if(Pre_Screen_Oriention != Screen.orientation && screen_orientation == Screen.orientation)
		{
			//change screen oriention
			Pre_Screen_Oriention = Screen.orientation;
		}
	}
}
