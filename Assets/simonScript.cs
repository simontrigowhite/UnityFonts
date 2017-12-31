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
        Debug.Log("its font is " + textObject.font.name);

        //Font arialFont = Resources.GetBuiltinResource<Font>("Arial.ttf");
        //textObject.font = arialFont;

        //Debug.Log("its font is " + textObject.font.name);

        GenerateComicyFont();

        Font comicyFont = Resources.Load<Font>("comicy2");
        textObject.font = comicyFont;

        Debug.Log("its font is " + textObject.font.name);

	}
	
    void GenerateComicyFont()
    {
        // to see this working, first delete the comicy2.mat and comicy2.fontsettings files from the Resources folder in Assets.
        // if they already exist, it will overwrite them.

        TextAsset comicyFontXml = Resources.Load<TextAsset>("comicy2");

        BitmapFontImporter.GenerateFontFromAsset(comicyFontXml);
    }

    private int i = 0;

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)))
        {
            Debug.Log("clicked " + i);
            i++;
        }
    }
}
