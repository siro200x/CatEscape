using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void LButtonDown()
    {
        if (transform.position.y < 4)
        {
            transform.Translate(-2, 0, 0);
        }
    }

    public void RButtonDown()
    {
        if (transform.position.y > -4)
        {
            transform.Translate(2, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 左矢印が押された時
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (transform.position.y < 4)
            {
                transform.Translate(-2, 0, 0); // 左に「3」動かす
            }
        }

        // 右矢印が押された時
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (transform.position.y > -4)
                transform.Translate(2, 0, 0); // 右に「3」動かす
        }
    }
}
