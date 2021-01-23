using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryObj
{
    public IFactory CreatProduct(string product)
    {
        IFactory f;
        if (product == "A")
        {
            return f = new Product_A_Obj();
        }
        else if(product == "B")
        {
            return f = new Product_B_Obj();
        }

        return null;
    }
}
