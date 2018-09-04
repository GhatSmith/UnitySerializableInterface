using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif


namespace OddTales.Framework.Core.Other
{
    /// <summary>
    /// Used to refernce Interface in inspector.
    /// Note : Class constraint means this can't be used for struct implementing interface. But struct can't be referenced through inspector so we don't care.
    /// </summary>
    [System.Serializable]
    public abstract class SerializableInterface<TInterface> where TInterface : class
    {
        [SerializeField] private Object serializedValue;

        private TInterface value = null;
        public TInterface Value
        {
            get
            {
                if (value == null && serializedValue != null) value = (TInterface)(object)serializedValue; // No memory allocation
                return value;
            }
            set
            {
                serializedValue = (Object)(object)value;
                this.value = null; // To trigger new caching for next get call
            }
        }

        public static implicit operator TInterface(SerializableInterface<TInterface> serializableInterface)
        {
            return serializableInterface.Value;
        }
    }


    // Compatibility for project without Odin Inspector
    public class SerializableInterfaceDrawer<TClass, TInterface> : PropertyDrawer
        where TClass : SerializableInterface<TInterface>
        where TInterface : class
    {
        public static void Draw(Rect position, GUIContent content, SerializedProperty property)
        {
            SerializedProperty serializedValueProperty = property.FindPropertyRelative("serializedValue");
            serializedValueProperty.objectReferenceValue = EditorGUI.ObjectField(position, content, serializedValueProperty.objectReferenceValue, typeof(TInterface), true);
        }
    }
}