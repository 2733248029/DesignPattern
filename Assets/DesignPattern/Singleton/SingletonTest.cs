using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Singleton.Instance.TestFunction();
    }

}
