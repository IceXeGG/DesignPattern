using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagerSingletonController : SingletonObj
{
    //instantiate EagerSingletonController
    private static EagerSingletonController Ins = new EagerSingletonController();
    //get the instance Ins
    public static EagerSingletonController Instance
    {
        get
        {
            return Ins;
        }
    }
}
