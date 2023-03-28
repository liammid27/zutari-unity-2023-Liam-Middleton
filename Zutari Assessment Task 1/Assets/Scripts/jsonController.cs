using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;

public class jsonController : MonoBehaviour
{
    public string jsonURl;
    public TextMeshProUGUI text;


    void Start()
    {
        StartCoroutine(getData());
    }

    IEnumerator getData()
    {
        Debug.Log("Processing Data, Please Wait");

        WWW _www = new WWW(jsonURl);
        yield return _www;
        if(_www.error == null)
        {
            processJsonData(_www.text);
        }
        else
        {
            Debug.Log("Oops something went wrong");
        }
    }

    private void processJsonData(string _url)
    {
        jsonData jsonData = JsonUtility.FromJson<jsonData>(_url);
        text.text = " Capitol City: " + jsonData.name + "\n Temperature: " + jsonData.main.temp + "\u00B0C" + "\n Description : " + jsonData.weather[0].description;
        Debug.Log(jsonData.main.temp);
        Debug.Log(jsonData.weather[0].description);
        Debug.Log(jsonData.name);
    }

}
