using System.Collections.Generic;
using UnityEngine;


namespace OddTales.Framework.Core.Other.Examples
{
    public class MyClassExample : MonoBehaviour
    {
        [SerializeField] private SerializedInterfaceExample myInterface;
        [SerializeField] private List<SerializedInterfaceExample> listOfInterfaces;
        [SerializeField] private SerializedInterfaceExample[] arrayOfInterfaces;
    }
}
