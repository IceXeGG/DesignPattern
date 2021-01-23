using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory_A_Obj
{
    private FactoryObj factory;

    public Factory_A_Obj(FactoryObj f)
    {
        factory = f;
    }

    public Product_A_Obj A_Order()
    {
        Product_A_Obj A = new Product_A_Obj();
        A.Action1();
        A.Action2();
        A.Action3();
        return A;
    }

    public Product_B_Obj B_Order()
    {
        Product_B_Obj B = new Product_B_Obj();
        B.Action1();
        B.Action2();
        B.Action3();
        return B;
    }

    public IFactory ProductOrder(string product)
    {
        IFactory f;
        f = factory.CreatProduct(product);

        f.Action1();
        f.Action2();
        f.Action3();

        return f;
    }
}
