using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediatorTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MediatorCenter mediator = new MediatorCenter();
        ColleageSon_A colleageSon_A = new ColleageSon_A(mediator);
        ColleageSon_B colleageSon_B = new ColleageSon_B(mediator);
        mediator.SetColleageA(colleageSon_A);
        mediator.SetColleageB(colleageSon_B);
        colleageSon_A.Action();
        colleageSon_B.Action();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
