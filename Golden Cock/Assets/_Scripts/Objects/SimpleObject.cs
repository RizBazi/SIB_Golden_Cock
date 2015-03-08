using UnityEngine;
using System.Collections;

public class SimpleObject : iActive_Action
{
	[System.Serializable]
	public struct Game_Data
	{
		public string Phone;
		public string FName;
		public string LName;
		public string Email;
		public string File_Name;
	}
	public string url;
	public Game_Data game_data;
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
	}
	public override void Action ()
	{
		Debug.Log ("WTF?!!!");
		StartCoroutine (Upload_Data (game_data));
	}
	public IEnumerator Upload_Data(Game_Data gd)
	{
		yield return new WaitForEndOfFrame ();
		WWWForm wwwform = new WWWForm ();
		wwwform.AddField ("Phone", gd.Phone);
		wwwform.AddField ("FName", gd.FName);
		wwwform.AddField ("LName", gd.LName);
		wwwform.AddField ("Email", gd.Email);
		wwwform.AddField ("File_Name", gd.File_Name);
		wwwform.AddBinaryData ("Upload_File", Take_Photo(), "myphoto.png", "image/png");
		WWW w = new WWW (url, wwwform);
		yield return w;
		if(!string.IsNullOrEmpty(w.error))
			print(w.error);
		else
			print ("File sent succesfully!");
	}

	public byte[] Take_Photo()
	{
		Texture2D tex2d = new Texture2D (Screen.width, Screen.height, TextureFormat.RGB24, false);
		tex2d.ReadPixels (new Rect (0, 0, Screen.width, Screen.height), 0, 0);
		tex2d.Apply ();
		return tex2d.EncodeToPNG ();
	}
}
