using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeandLaps : MonoBehaviour
{
    [SerializeField] private Text timer;

    // Update is called once per frame
    void Update()
    {
        timer.text = $"Time: {Time.realtimeSinceStartup:0.000}";
    }
}
