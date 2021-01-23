using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleLockSingletonController : SingletonObj
{
    private static DoubleLockSingletonController Ins = null;
    static readonly object Lock = new object();
    //get the instance Ins
    public static DoubleLockSingletonController Instance
    {
        get
        {
            //check if DoubleLockSingletonController haven't instantiated
            if (Ins == null)
            {
                //block other thread to instantiate Ins
                lock (Lock)
                {
                    //check if DoubleLockSingletonController haven't instantiated before lock
                    if (Ins == null)
                    {
                        Ins = new DoubleLockSingletonController();
                    }
                }
            }
            return Ins;
        }
    }
}
