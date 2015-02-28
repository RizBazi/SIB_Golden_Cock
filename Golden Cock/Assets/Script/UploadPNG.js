#pragma strict

function UploadPNG() {
	// We should only read the screen after all rendering is complete
	yield WaitForEndOfFrame();
	// Create a texture the size of the screen, RGB24 format
	var width = Screen.width;
	var height = Screen.height;
	var tex = new Texture2D( width, height, TextureFormat.RGB24, false );
	// Read screen contents into the texture
	tex.ReadPixels( Rect(0, 0, width, height), 0, 0 );
	tex.Apply();
	// Encode texture into PNG
	var bytes = tex.EncodeToPNG();
	Destroy( tex );
	// Create a Web Form
	var form = new WWWForm();
	form.AddField("frameCount", Time.frameCount.ToString());
	form.AddBinaryData("file", bytes, "screenShot.png", "image/png");
	// Upload to a cgi script
	var w = WWW("http://moft.xzn.ir/test.php", form);
	yield w;
	print(w.text);
	if (w.error != null){
		print(w.error);
		Application.ExternalCall( "debug", w.error);
		//print(screenShotURL);
	}		
	else{
		print("Finished Uploading Screenshot");
		//print(screenShotURL);
		Application.ExternalCall( "debug", "Finished Uploading Screenshot");
	}
}

function Update () {
	if(Input.GetKeyUp(KeyCode.A)){
		UploadPNG();
	}
}