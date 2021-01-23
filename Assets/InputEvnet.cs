using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class InputEvnet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Task.Run(() =>
            {
                EagerSingletonController.Instance.GetNum();
            });
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Task.Run(() =>
            {
                LazySingletonController.Instance.GetNum();
            });
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Task.Run(() =>
            {
                DoubleLockSingletonController.Instance.GetNum();
            });
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            Factory_A_Obj factory_A = new Factory_A_Obj(new FactoryObj());
            factory_A.A_Order();
        }
        else if (Input.GetKey(KeyCode.X))
        {
            Factory_A_Obj factory_A = new Factory_A_Obj(new FactoryObj());
            factory_A.B_Order();
        }
        else if (Input.GetKey(KeyCode.C))
        {
            Factory_A_Obj factory_A = new Factory_A_Obj(new FactoryObj());
            factory_A.ProductOrder("").Action1();
        }
    }
}
