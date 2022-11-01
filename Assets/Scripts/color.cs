using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class color : MonoBehaviour
{
    public int ballnum;
    public DZscript ballDZ;
    // Start is called before the first frame update
    public Image ballH1;
    public Image ballH2;
    public Image ballH3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ballnum =ballDZ.ballCount;
        if (ballnum == 1)
        {
            ballH1.color = UnityEngine.Color.red;
        }
        if (ballnum == 2)
        {
            ballH2.color = UnityEngine.Color.red;
        }
        if (ballnum == 3)
        {
            ballH3.color = UnityEngine.Color.red;
        }
    }
}
