using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dandilion_Script : MonoBehaviour
{
    float time = 5f;
    float x, y, z;

    //call pollen
    public GameObject whitePollen;
    public GameObject redPollen;
    public GameObject greenPollen;
    public GameObject pinkPollen;

    //flower
    public GameObject whiteFlower;
    public GameObject redFlower;
    public GameObject greenFlower;
    public GameObject pinkFlower;
    //bool hideOneTime = false;

    //database
    int color = dataInsert.collect.value;


    void Start()
    {
        x = -5.5f;
        y = -3.5f;
        z = 0;
        transform.position = new Vector3(x,y,z);
        //soundWind = soundCollect.GetComponent<AudioSource>();
    }

    public void FixedUpdate()
    {
        StartCoroutine(DelayPollen());
            if (color == 1)
            {
                Invoke("sendPollenW", 2f);
                sendPollenW();
                sendWhiteFlower();
            }
            if (color == 2)
            {
                Invoke("sendPollenR", 2f);
                sendPollenR();
                sendRedFlower();
        }
            if (color == 3)
            {
                Invoke("sendPollenG", 2f);
                sendPollenG();
                sendGreenFlower();
        }
            if (color == 4)
            {
                Invoke("sendPollenP", 2f);
                sendPollenP();
                sendPinkFlower();
        }
            if (color == 0)
            {
                Invoke("sendPollenW", 2f);
                sendPollenW();
                sendWhiteFlower();
        }

    }
     public void sendPollenW() 
    {
        int value = Arduino_Initial.value;
         
        if (value >= 500)
        {
            Instantiate(whitePollen, transform.position,transform.rotation);
        }
    }

     public void sendPollenR()
    {
        int value = Arduino_Initial.value;

        if (value >= 500)
        {
            Instantiate(redPollen, transform.position, transform.rotation);
        }
    }

    public void sendPollenG()
    {
        int value = Arduino_Initial.value;

        if (value >= 500)
        {
            Instantiate(greenPollen, transform.position, transform.rotation);
        }
    }

    public void sendPollenP()
    {
        int value = Arduino_Initial.value;

        if (value >= 500)
        {
            Instantiate(pinkPollen, transform.position, transform.rotation);
        }
    }
    public void sendWhiteFlower()
    {
        if (color == 1) 
        {
            whiteFlower.gameObject.SetActive(true);
            //false
            redFlower.gameObject.SetActive(false);
            greenFlower.gameObject.SetActive(false);
            pinkFlower.gameObject.SetActive(false);
        }
    }

    public void sendRedFlower()
    {
        if (color == 2)
        {
            redFlower.gameObject.SetActive(true);
            //false
            whiteFlower.gameObject.SetActive(false);
            greenFlower.gameObject.SetActive(false);
            pinkFlower.gameObject.SetActive(false);
        }
    }

    public void sendGreenFlower()
    {
        if (color == 3)
        {
            greenFlower.gameObject.SetActive(true);
            //false
            whiteFlower.gameObject.SetActive(false);
            redFlower.gameObject.SetActive(false);
            pinkFlower.gameObject.SetActive(false);
        }
    }

    public void sendPinkFlower()
    {
        if (color == 4)
        {
            pinkFlower.gameObject.SetActive(true);
            //false
            whiteFlower.gameObject.SetActive(false);
            redFlower.gameObject.SetActive(false);
            greenFlower.gameObject.SetActive(false);
        }
    }
    IEnumerator DelayPollen()
    {
        yield return new WaitForSeconds(2);
    }
}

