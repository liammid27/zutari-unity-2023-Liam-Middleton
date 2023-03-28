using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;

public class SliderScript : MonoBehaviour
{
    //Variables needed to update slider text
    public TextMeshProUGUI text;
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        //Updating text with slider value
        slider.onValueChanged.AddListener((x) =>
        {
            text.text = x.ToString("0.00");

        });
    }
}
