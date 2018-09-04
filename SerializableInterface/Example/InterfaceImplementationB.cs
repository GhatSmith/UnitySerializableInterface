using UnityEngine;


namespace OddTales.Framework.Core.Other.Examples
{
    public class InterfaceImplementationB : MonoBehaviour, ISerializedInterfaceExample
    {
        int ISerializedInterfaceExample.MyProperty { get { return 100; } }

        void ISerializedInterfaceExample.MyMethod()
        {
            Debug.Log("InterfaceImplementationB");
        }
    }
}