using System;
using UnityEngine;

namespace Utils
{
    public abstract class AbstractProperty<T> : MonoBehaviour
    {
        [SerializeField] protected T _value;

        public virtual T Value
        {
            get => _value;
            set
            {
                if (IsEqual(value)) return;
                var was = _value;
                _value = value;
                ChangeEvent?.Invoke();
            }
        }

        public event Action ChangeEvent;

        public abstract bool IsEqual(T v);
    }
}