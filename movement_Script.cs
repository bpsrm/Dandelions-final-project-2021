using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_Script : MonoBehaviour
{
    public SpriteRenderer trunkDan;
    public Sprite[] image;
    int count;

    public GameObject soundCollect;
    AudioSource soundWind;

    void Start()
    {
        count = 0;
    }

    void Update()
    {
        if (Arduino_Initial.value >= 500) 
        {
            soundWind = soundCollect.GetComponent<AudioSource>();
            
            trunkDan.sprite = image[count];
            count++;
            if (count >= 6)
            {
                StartCoroutine(DelayPollen());
                count = 0;
                soundWind.Play();
            }
        }
    }
    IEnumerator DelayPollen()
    {
        yield return new WaitForSeconds(5);
    }
}
