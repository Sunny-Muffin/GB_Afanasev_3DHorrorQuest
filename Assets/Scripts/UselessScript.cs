using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UselessScript : MonoBehaviour
{
    // ������ �� ����� ������� �� ��������� RGBa
    // ������ �� ���������? �� �� ��������� 3 ������...
    // ����� ������ ��� �������? � ��� ��� ���������� �����?? ������� ������ �������� ����� �� ������...
    // ���� ���������� ��� �� ���������

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

