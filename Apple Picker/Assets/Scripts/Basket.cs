using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;


public class Basket : MonoBehaviour
{

    [Header("Set Dynamically")]
    public TextMeshProUGUI scoreGT;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<TextMeshProUGUI>();
        scoreGT.text = "0";

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos2D = Input.mousePosition;

        mousePos2D.z = -Camera.main.transform.position.z;

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

    }

    void OnCollisionEnter(Collision coll)
    {


        GameObject collidedWith = coll.gameObject;

        if (collidedWith.tag == "Apple")
        {
            int score = int.Parse(scoreGT.text);
            Destroy(collidedWith);

            score += 100;
            scoreGT.text = score.ToString();

            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }

        if(collidedWith.tag == "BadApple")
        {
            SceneManager.LoadScene("GameOver");
            
        }


    }

}