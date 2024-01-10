using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GetDescription : MonoBehaviour
{
    public GameObject description;

    void Update()
    {
        string readFromFile = "/Users/kieuly/Documents/GitHub/AIArtExtendedPlus/Prompt/prompt.txt";

        string line = File.ReadAllText(readFromFile);
        description.GetComponent<Text>().text = line;
    }
    
}
