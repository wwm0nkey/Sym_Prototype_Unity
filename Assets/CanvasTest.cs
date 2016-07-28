using UnityEngine;
using System.Collections;

public class CanvasTest : MonoBehaviour {

    public Transform childObj;
	// Use this for initialization
	void Start () {
        childObj = transform.GetChild(0);
        childObj.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
