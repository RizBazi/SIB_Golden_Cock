using UnityEngine;
using System.Collections;

[System.Serializable]
public class Page {
	public Sprite Picture;
	[Multiline]
	public string Text;
	public AudioClip Audio;
}
