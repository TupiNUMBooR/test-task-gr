using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Test
{
    [RequireComponent(typeof(Button))]
    public class AddFloatFromButton : Modifier<Button>
    {
        public FloatProperty prop;
        public float addValue;
        
        void Start()
        {
            modified.onClick.AddListener(OnClick);
        }

        void OnDestroy()
        {
            modified.onClick.RemoveListener(OnClick);
        }

        void OnClick()
        {
            prop.Value += addValue;
        }
    }
}