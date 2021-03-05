using UnityEngine;
using UnityEngine.UI;

namespace Utils
{
    [RequireComponent(typeof(Button))]
    public abstract class ButtonHandler : Modifier<Button>
    {
            void Start()
            {
                modified.onClick.AddListener(OnClick);
            }

            void OnDestroy()
            {
                modified.onClick.RemoveListener(OnClick);
            }

            protected abstract void OnClick();
    }
}