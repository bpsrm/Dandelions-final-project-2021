using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bg_Script : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    [SerializeField] Image image;

    void Start()
    {
        float r = Random.Range(0,sprites.Length);
        image.sprite = sprites[(int)r];
    }
    void Update()
    {
        
    }
}
