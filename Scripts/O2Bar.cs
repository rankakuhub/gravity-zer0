using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O2Bar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill2;

    public void SetMaxO2(int o2)
    {
        slider.maxValue = o2;
        slider.value = o2;

        fill2.color = gradient.Evaluate(1f);
    }

    public void SetO2(int o2)
    {
        slider.value = o2;

        fill2.color = gradient.Evaluate(slider.normalizedValue);
    }

}
