using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// If apples go flying, check physics layers

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject applePrefab;
    public GameObject badApple;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirctions = 0.1f;
    public float secondsBetweenAppleDrops = 1f;
    public float badAppleChance = 0.4f;



    // Start is called before the first frame update
    void Start()
    { 
        Invoke("DropApple", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }

        if (RoundCounter.round == 2)
        {

            badAppleChance = .2f;
        }
        if (RoundCounter.round == 3)
        {
      
            badAppleChance = .3f;
        }
        if (RoundCounter.round == 4)
        {

            badAppleChance = .35f;
        }


    }

    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirctions)
        {
            speed *= -1;
        }
    }

    void DropApple()
    {
        float bAppleChance = Random.value;
        if(bAppleChance < badAppleChance)
        {
            GameObject BadApple = Instantiate<GameObject>(badApple);
            badApple.transform.position = transform.position;
            Invoke("DropApple", secondsBetweenAppleDrops);
        }
        else
        {
            GameObject apple = Instantiate<GameObject>(applePrefab);
            apple.transform.position = transform.position;
            Invoke("DropApple", secondsBetweenAppleDrops);
        }

    }
}
