using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadApple : MonoBehaviour
{
    public static float bottomY = -20f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        


    }

    public void Caught()
    {
        Destroy(this.gameObject);
        ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
        apScript.BadApple();
    }
}