using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //为了减少客户端与其他功能类的耦合
    void Start()
    {
        Facade facade = new Facade();
        facade.Asset();
        facade.Battle();
        facade.Net();
    }

}
