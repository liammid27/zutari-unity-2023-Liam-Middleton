using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;

public class jsonController : MonoBehaviour
{
    //Variables for UI and URL
    public string jsonURl;
    public TextMeshProUGUI text;


    void Start()
    {
        //Start coroutine to get url and json data
        StartCoroutine(getData());
    }

    IEnumerator getData()
    {
        Debug.Log("Processing Data, Please Wait");

        WWW _www = new WWW(jsonURl);
        yield return _www;
        if(_www.error == null)
        {
            //if data is found it is processed in the json method
            processJsonData(_www.text);
        }
        else
        {
            //if no data is found logged error
            Debug.Log("Oops something went wrong");
        }
    }

    private void processJsonData(string _url)
    {
        //Reading and interpretting json data and then formatting a string for the provinces data
        jsonData jsonData = JsonUtility.FromJson<jsonData>(_url);
        text.text = " Capitol City: " + jsonData.name + "\n Temperature: " + jsonData.main.temp + "\u00B0C" + "\n Description : " + jsonData.weather[0].description;
        
    }

}
