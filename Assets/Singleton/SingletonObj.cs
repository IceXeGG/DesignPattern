using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class SingletonObj
{
    private static readonly object Lock = new object();
    protected int Count = 0;
    public int GetNum()
    {
        //get current thread
        Thread thread = Thread.CurrentThread;
        //block other thread do something to the Count
        lock (Lock)
        {
            Count++;
            Debug.Log(string.Format("{0} \nthread now : {1}", Count, thread.ManagedThreadId));
            return Count;
        }
    }
}
