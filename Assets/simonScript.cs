using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Simon();

	}
	
	// Update is called once per frame
	void Update () {
		
	}



    void Simon()
    {
        UnityEngine.UI.Text textAsset = this.GetComponent<UnityEngine.UI.Text>();
        //var x =this.GetComponent(text)
        Debug.Log(textAsset.name);
    }

}
