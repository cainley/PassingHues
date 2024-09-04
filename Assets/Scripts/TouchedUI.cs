using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchedUI : MonoBehaviour
{

    public IntVariable timesTouch;
    public Text touchText;

    // Update is called once per frame
    void Update()
    {
        touchText.text = timesTouch.value.ToString();
    }
}
