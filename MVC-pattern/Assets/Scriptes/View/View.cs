using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    public Text cubeCount;
    public Text sphereCount;
    public void ChangeCubeView(int value)
    {
        cubeCount.text = value.ToString();
    }
    public void ChangeSphereView(int value)
    {
        sphereCount.text = value.ToString();
    }
}
