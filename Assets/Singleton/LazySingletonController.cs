using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazySingletonController : SingletonObj
{
    //get the instance Ins
    public static LazySingletonController Instance
    {
        get
        {
            return LazySingletonObj.Ins;
        }
    }
    //instantiate Ins when Instance going to be used
    class LazySingletonObj
    {
        static LazySingletonObj()
        {

        }
        internal static readonly LazySingletonController Ins = new LazySingletonController();
    }
}
