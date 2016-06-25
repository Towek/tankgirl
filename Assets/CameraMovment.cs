using UnityEngine;
using System.Collections;

public class CameraMovment : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public class CamFollow : MonoBehaviour {
        void Main() {
            Camera.main.transform.position = transform.position;
        }
    }
}
