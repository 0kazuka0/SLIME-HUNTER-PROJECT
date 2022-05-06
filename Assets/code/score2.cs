using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class score2 : MonoBehaviour
{
    public static int scorevalue = 10;
    Text scor;
    // Start is called before the first frame update
    void Start()
    {
        scor = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scor.text = "Get kills:" + scorevalue;
        if (scorevalue == 0)
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
