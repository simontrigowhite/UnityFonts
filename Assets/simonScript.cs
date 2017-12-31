using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEditor;
using UnityEngine;

public class simonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        UnityEngine.UI.Text textObject = this.GetComponent<UnityEngine.UI.Text>();
        Debug.Log("the text object is called " + textObject.name);

        GenerateComicyFont();
	}
	
    void GenerateComicyFont()
    {
        // to see this working, first delete the comicy2.mat and comicy2.fontsettings files from the Resources folder in Assets

        TextAsset comicyFontXml = Resources.Load<TextAsset>("comicy2");

        BitmapFontImporter.GenerateFontFromAsset(comicyFontXml);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
