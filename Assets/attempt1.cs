using UnityEngine;
using UnityEditor;
using System;


public class attempt1 : MonoBehaviour {

    void Awake()
    {
        
    }

    // Use this for initialization
    void Start () {
        //Debug.Log("hello");
        //pointless();
        //Import();
	}

    void pointless()
    {
        Debug.Log("checking");
    }

    void Import()
    {
        TextMesh rects = this.GetComponent<TextMesh>();
        Debug.Log(rects.text); 
        Debug.Log(rects.font.name); 

        Vector2 size = new Vector2(2F, 6F);
        Font font = new Font();
        var _splitFile = new string[] { "\r\n", "\r", "\n" };
        var _splitLine = new char[] { ',' };

        string[] lines = rects.text.Split(_splitFile, StringSplitOptions.None);

        CharacterInfo[] info = new CharacterInfo[lines.Length];

        for (var i = 0; i < lines.Length; i++)
        {
            string[] line = lines[i].Split(_splitLine, StringSplitOptions.None);
            int x = Convert.ToInt32(line[0]);
            int y = Convert.ToInt32(line[1]);
            int width = Convert.ToInt32(line[2]);
            int height = Convert.ToInt32(line[3]);
            int offset = Convert.ToInt32(line[4]);
            /*info[i].uv.x = x / size.x;
            info[i].uv.y = y / size.y;
            info[i].uv.width = width / size.x;
            info[i].uv.height = height / size.y;
            info[i].minX = 0;info[i].vert.x = 0;
            info[i].minY = -offset;info[i].vert.y = -offset;
            info[i].maxX = width;info[i].vert.width = width;
            info[i].maxY = -height;info[i].vert.height = -height;
            info[i].advance = width;info[i].width = width;*/
            info[i].index = i;
        }
        font.characterInfo = info;
        AssetDatabase.SaveAssets();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
