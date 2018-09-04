using UnityEngine;


namespace OddTales.Framework.Core.Other.Examples
{
    /// <summary> File example showing how to implement a serializable interface</summary>
    [System.Serializable]
    public class SerializedInterfaceExample : SerializableInterface<ISerializedInterfaceExample>
    {
    }

    public interface ISerializedInterfaceExample
    {
        int MyProperty { get; }
        void MyMethod();
    }


#if UNITY_EDITOR
    [UnityEditor.CustomPropertyDrawer(typeof(SerializedInterfaceExample))]
    public class SerializableInterfaceExampleDrawer : UnityEditor.PropertyDrawer
    {
        public override void OnGUI(Rect position, UnityEditor.SerializedProperty property, GUIContent label)
        {
            SerializableInterfaceDrawer<SerializedInterfaceExample, ISerializedInterfaceExample>.Draw(position, label, property);
        }
    }
#endif
}