using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Context context = new Context();
        context.SetState(new ConcreteStateA(context));
        context.Request(5);
        context.Request(15);
        context.Request(25);
        context.Request(35);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
