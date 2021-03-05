using UnityEngine;

namespace Utils
{
    public abstract class Modifier<T> : MonoBehaviour
    {
        public T modified { get; private set; }

        protected virtual void Awake()
        {
            modified = GetComponent<T>();
        }
    }
}