using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenReset : MonoBehaviour
{
    public string nameOfLevel;

    public DZscript ballDZ;
    public GameObject player;
    public GameObject lostScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(nameOfLevel);
        }

        if (ballDZ.ballCount == 3)
        {
            lostScreen.SetActive(true);
            player.SetActive(false);

        }
    }
}
