using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : GAgent 
{
    protected override void Start() 
    {
        base.Start();
        SubGoal s1 = new SubGoal("treatPatient", 1, false);
        goals.Add(s1, 3);

        SubGoal s2 = new SubGoal("rested", 1, false);
        goals.Add(s1, 3);

        Invoke("GetTired", Random.Range(10, 20));
    }

    void GetTired()
    {
        beliefs.ModifyState("exausted", 0);
        Invoke("GetTired", Random.Range(10, 20));
    }
}