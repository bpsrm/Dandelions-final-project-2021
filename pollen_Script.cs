using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class pollen_Script : MonoBehaviour
{
    float x, y, z;
    public float speedRot1;
    public float speedRot2;
    float width1, width2, heigh1, heigh2, time;
    public float speed = 0.1f;


    void Start()
    {
        width1 = -5.4f;
        width2 = 10f;
        heigh1 = 1.5f;
        heigh2 = -8f;
        x = -4.7f;
        y = -2f;
        z = 3;
        transform.position = new Vector3(x,y,z);
    }

    void FixedUpdate()
    {
        int value = Arduino_Initial.value;
        time = 0.005f;
        //WhitePollenEffect();
        if (value >= 35)
        {
            transform.position += Vector3.down / 40f;
            transform.position += Vector3.right / 40f;
            transform.Rotate(0, 0, Random.Range(speedRot1, speedRot2) * 0.5f);
        }

        if (value >= 40) 
        {
            StartCoroutine(DelayTime());
            int color = dataInsert.collect.value;
            //Debug.Log(color);
            
            if (color == 1) 
            {
                WhitePollenEffect();
            }
            if (color == 2)
            {
                RedPollenEffect();
            }
            if (color == 3)
            {
                GreenPollenEffect();
            }
            if (color == 4)
            {
                PinkPollenEffect();
            }
            if (color == 0)
            {
                WhitePollenEffect();
            }
        }//endColorCollect

        StartCoroutine(Die());

    }
    void WhitePollenEffect()
    {
        float width = Random.Range(width1, width2);
        float height = Random.Range(heigh1, heigh2);

        transform.position = new Vector3(width + speed, height);
        transform.Rotate(0, 0, Random.Range(speedRot1, speedRot2) * 0.5f);
    }//White

    void RedPollenEffect()
    {
        float width = Random.Range(width1, width2);
        float height = Random.Range(heigh1, heigh2);

        transform.position = new Vector3(width + speed, height);
        transform.Rotate(0, 0, Random.Range(speedRot1, speedRot2) * 0.5f);
    }//Red

    void GreenPollenEffect()
    {
        float width = Random.Range(width1, width2);
        float height = Random.Range(heigh1, heigh2);

        transform.position = new Vector3(width + speed, height);
        transform.Rotate(0, 0, Random.Range(speedRot1, speedRot2) * 0.5f);
    }//Green

    void PinkPollenEffect()
    {
        float width = Random.Range(width1, width2);
        float height = Random.Range(heigh1, heigh2);

        transform.position = new Vector3(width + speed, height);
        transform.Rotate(0, 0, Random.Range(speedRot1, speedRot2) * 0.5f);
    }//Pink


    IEnumerator Die()
    {
        yield return new WaitForSeconds(2); 
        Destroy(GameObject.Find("pollen_white(Clone)"));
        Destroy(GameObject.Find("pollen_red(Clone)"));
        Destroy(GameObject.Find("pollen_green(Clone)"));
        Destroy(GameObject.Find("pollen_pink(Clone)"));
    }
    IEnumerator DelayTime() 
    {
        yield return new WaitForSeconds(5);
    }

}
        

