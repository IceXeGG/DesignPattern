using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product_B_Obj : IFactory
{
    public void Action1()
    {
        Debug.Log("B_Action1");
    }
    public void Action2()
    {
        Debug.Log("B_Action2");
    }
    public void Action3()
    {
        Debug.Log("B_Action3");
    }
}
