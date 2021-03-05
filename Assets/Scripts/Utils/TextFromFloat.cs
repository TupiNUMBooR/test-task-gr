using System.Globalization;
using TMPro;
using UnityEngine;

namespace Utils
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(TMP_Text))]
    public class TextFromFloat : Modifier<TMP_Text>
    {
        public FloatProperty prop;
        public string format = "{0:0.#}";

        void Start()
        {
            prop.ChangeEvent += OnChange;
            OnChange();
        }

        void OnChange()
        {
            modified.text = string.Format(CultureInfo.InvariantCulture, format, prop.Value);
        }
    }
}