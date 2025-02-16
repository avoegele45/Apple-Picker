using TMPro;
using UnityEngine;

public class RoundCounter : MonoBehaviour
{

    static public int round = 1;
    public TextMeshProUGUI scoreGT;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI gt = this.GetComponent<TextMeshProUGUI>();
        gt.text = "Round : " + round;
        int score = int.Parse(scoreGT.text);
        if (score < 500)
        {
            round = 1;
        }

        if (score == 500)
        {
            round = 2;

        }
        if (score == 1000)
        {
            round = 3;

        }
        if (score == 1500)
        {
            round = 4;

        }


    }
}
