using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UselessScript : MonoBehaviour
{
    // вообще не понял задание со слайдером RGBa
    // почему он четвертый? Мы не создавали 3 других...
    // зачем вообще это задание? В чем его сакральный смысл?? Слайдер просто занимает место на экране...
    // тупо скопировал код из методички

    private float sliderValue;
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(1000, 700, 200, 100));
        GUILayout.BeginHorizontal();
        GUILayout.BeginVertical();
        if (GUILayout.RepeatButton("Min"))
            sliderValue = 0.0f;
        if (GUILayout.RepeatButton("Max"))
            sliderValue = 100.0f;
        GUILayout.EndVertical();
        GUILayout.BeginVertical();
        GUILayout.Label("RGBa: ");
        sliderValue = GUILayout.HorizontalSlider(sliderValue, 0.0f, 100.0f);
        GUILayout.EndVertical();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}

