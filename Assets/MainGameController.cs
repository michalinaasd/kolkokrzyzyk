using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class MainGameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Clear();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clear() {
        foreach (Text text in GetComponentsInChildren<Text>()) {
            text.text = "-";
        }
    }
}
