using System.Globalization;
using TMPro;
using UnityEngine;

namespace Utils
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(TMP_InputField))]
    public class FloatFromInput : Modifier<TMP_InputField>
    {
        public FloatProperty prop;

        void Start()
        {
            modified.text = prop.Value.ToString(CultureInfo.InvariantCulture);
            modified.onValueChanged.AddListener(OnInput);
            
        }

        void OnDestroy()
        {
            modified.onValueChanged.RemoveListener(OnInput);
        }

        void OnInput(string value)
        {
            if (float.TryParse(value, out var result))
                prop.Value = result;
        }
    }
}