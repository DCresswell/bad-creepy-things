using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways] // edit mode and play mode - be carefull!!!
public class CoordinateLabeler : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
       if(!Application.isPlaying) //only run in editor mode
       {
           //do something
       } 
    }
}
