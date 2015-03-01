using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using ArabicSupport;

public class BookManager : MonoBehaviour {
	//Story Components
//	public Text TextContainer;
//	public Image ImageContainer;
	public TextMesh TextContainer;
	public int MaxCharactersInRow = 50;

	public SpriteRenderer ImageContainer;
	public AudioSource AudioPerformer;

	int index;

	//Story Pages
	public Page [] pages;

	void Awake()
	{
		index = 0;
	}

	// Use this for initialization
	void Start () {
		ShowNextStory ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ShowNextStory()
	{
		Page p = pages [index];


		TextContainer.text = RTLWrapFix( ArabicFixer.Fix(p.Text,false,true),MaxCharactersInRow);
		ImageContainer.sprite = p.Picture;
		AudioPerformer.clip = p.Audio;
		AudioPerformer.Play ();

		index++;
	}

	string RTLWrapFix(string text,int MaxChars)
	{
		string [] Lines = text.Split (new char[1]{'\n'});

		string newStr = string.Empty;

		foreach(string s in Lines)
		{
			string [] words = s.Split(new char[1]{' '});
			string temp =string.Empty;
			for(int i =words.Length-1;i>=0;i--)
			{
				if((temp+words[i]).Length>MaxChars)
				{
					newStr = newStr + "\n" + words[i] + " " + temp;
					temp = string.Empty;
				}else
				{
					temp = words[i] + " " + temp;
				}
			}

			newStr = newStr + "\n" + temp;
		}

		return newStr;
	}
}
