using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System.Threading;

public class Arduino_Initial : MonoBehaviour
{
    public static SerialPort sp = new SerialPort("COM4", 9600);
    public static int value;

    // Use this for initialization
    void Start()
    {
        OpenConnection();
    }

    // Update is called once per frame
    void Update()
    {
        // print(UnityReadData());
        try
        {
            //print (sp.ReadLine());
            //sp.WriteLine("aaaa");
            value = int.Parse(sp.ReadLine());

        }
        catch (System.Exception) { }

    }

    public void OpenConnection()
    {
        if (sp != null)
        {
            if (sp.IsOpen)
            {
                sp.Close();
                print("Closing port, because it was already open!");
            }
            else
            {
                sp.Open(); // opens the connection
                sp.ReadTimeout = 100; //sets the timeout value before reporting error
                print("Port Opend!");
            }
        }
        else
        {
            if (sp.IsOpen)
                print("Port is already open");
            else
                print("Port == null");
        }
    }

    void OnApplicationQuit()
    {
        sp.Close();
    }

    public static void UnitySendData(string m)
    {
        sp.Write(m);
    }

    /* public static string UnityReadData()
     {
         string me;
         try
         {
             return(sp.ReadLine());
         }catch(System.Exception){ return "0"; }

         //return me;
     }*/

}

