using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RNG : MonoBehaviour {
    public int randomNum;
    public int correctNum = 24;
    public int numRange;
    public bool ispaused = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(SceneManager.GetActiveScene().name);
       if(Input.GetKey(KeyCode.W))
        {
            randomNum = Random.Range(0, numRange);
            if (randomNum == correctNum && SceneManager.GetActiveScene().name == "Test_1")
            {
                SceneManager.LoadScene("Enemy_Test");
            }
        }



        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().name == "Enemy_Test")
        {
            if (ispaused == false)
            {
                Time.timeScale = 0.0f;
                GameObject.Find("Canvas").GetComponent<CanvasTest>().childObj.gameObject.SetActive(true);
                ispaused = true;
            }
            else if(ispaused == true)
            {
                SetTrueFalse();
            }
        }
	}

    public void SetTrueFalse()
    {
        Time.timeScale = 1.0f;
        GameObject.Find("Canvas").GetComponent<CanvasTest>().childObj.gameObject.SetActive(false);
        ispaused = false;
    }
}
