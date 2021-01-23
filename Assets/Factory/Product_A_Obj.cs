using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product_A_Obj : IFactory
{
    public void Action1()
    {
        Debug.Log("A_Action1");
    }
    public void Action2()
    {
        Debug.Log("A_Action2");
    }
    public void Action3()
    {
        Debug.Log("A_Action3");
    }
}
