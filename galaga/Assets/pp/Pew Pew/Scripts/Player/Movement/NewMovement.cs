using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewMovement : MonoBehaviour
{
    public Slider slider;
    private float sliderValue;

    // Update is called once per frame
    void Update()
    {
        sliderValue = slider.value;
        Vector3 temp = transform.position;
        temp.x = sliderValue;
        transform.localPosition = temp;
    }
}
