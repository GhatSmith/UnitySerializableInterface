using UnityEngine;


namespace OddTales.Framework.Core.Other.Examples
{
    public class InterfaceImplementationA : MonoBehaviour, ISerializedInterfaceExample
    {
        int ISerializedInterfaceExample.MyProperty { get { return 0; } }

        void ISerializedInterfaceExample.MyMethod()
        {
            Debug.Log("InterfaceImplementationA");
        }
    }
}