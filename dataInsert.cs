using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dataInsert : MonoBehaviour
{
    string URL = "http://localhost/data_wishLand/insertData.php";

    //username
    public InputField insertUsername;
    private string input;

    //color
    public Dropdown colorSet;
    public static Dropdown collect;
    public static string colorPick;
    List<string> colors = new List<string>() {};

    
    void Start()
    {
        colors.Insert(0, "Choose Color");
        colors.Insert(1, "White");
        colors.Insert(2, "Red");
        colors.Insert(3, "Green");
        colors.Insert(4, "Pink");
        ListDropdown();

        collect = colorSet;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) InsertData(insertUsername.ToString(),colorSet.ToString());
        Debug.Log(collect.value);
    }

    public void ReadInputField(string name)
    {
        input = insertUsername.ToString();
        input = name;
        Debug.Log(input);
    }//inoutFieldUsername

    public void ReadColorPick(Dropdown senders)
    {
        colorPick = colorSet.ToString();
        colorPick = senders.ToString();

        Debug.Log(senders.value);
    }//colorDropdown

    public void InsertData(string username,string color_pick) 
    {
        string arrayColor = colorSet.options[colorSet.value].text;
        username = input;
        color_pick = arrayColor;

        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
        form.AddField("colorPost", color_pick);

        WWW www = new WWW(URL, form);
    }//database

    void ListDropdown()
    {
        colorSet.AddOptions(colors);
    }//dropdown

}
