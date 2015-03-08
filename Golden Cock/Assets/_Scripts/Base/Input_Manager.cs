using UnityEngine;
using System.Collections;

public class Input_Manager : MonoBehaviour
{
	public bool Enable_Access;
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Enable_Access)
		{
			switch(Application.platform)
			{
				case RuntimePlatform.Android:
				case RuntimePlatform.IPhonePlayer:
					if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
					{
						CheckInput(Input.GetTouch(0).position);
					}
				break;
				
				case RuntimePlatform.WindowsPlayer:
				case RuntimePlatform.WindowsEditor:
					if(Input.GetMouseButtonDown(0))
					{
						CheckInput(Input.mousePosition);
					}
				break;
			}
		}
	}
	void CheckInput(Vector3 position)
	{
		Vector3 vector3 = Camera.main.ScreenToWorldPoint (position);
		Vector2 vector2 = new Vector2 (vector3.x, vector3.y);
		Collider2D hit = Physics2D.OverlapPoint (vector2);
		if(hit!=null)
		{
			hit.GetComponent<iActive_Action>().Action();
		}
	}
}
