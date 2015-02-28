using UnityEngine;
using System.Collections;

public class Swipetxt : MonoBehaviour {

	public Transform textObject;
	public float MoveRange = 5f;
	public float SwipeZarib = 1f;

	float FirstObjectY;
	float LastY;

	// Use this for initialization
	void Start () {
		FirstObjectY = textObject.position.y;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		LastY = Input.mousePosition.y;
	}

	void OnMouseDrag()
	{
		float NewY = Input.mousePosition.y;

		textObject.Translate ((new Vector3 (0, 1, 0)) * (NewY - LastY) * SwipeZarib,Space.World);

		if(textObject.position.y<FirstObjectY)
		{
			textObject.position = new Vector3(textObject.position.x,FirstObjectY,textObject.position.z);
		}

		if(textObject.position.y-FirstObjectY>MoveRange)
		{
			textObject.position = new Vector3(textObject.position.x,FirstObjectY+MoveRange,textObject.position.z);
		}

		LastY = NewY;
	}
}
