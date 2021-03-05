using UnityEngine;
using Utils;

namespace Test
{
    public class Spawner : MonoBehaviour
    {
        public GameObject prefab;
        public FloatProperty cooldown;
        float _lastSpawn = float.MinValue;

        void FixedUpdate()
        {
            if (Time.time < _lastSpawn + cooldown.Value) return;
            
            _lastSpawn = Time.time;
            var obj = Instantiate(prefab, prefab.transform.parent); // здесь можно использовать пул
            obj.SetActive(true);
        }
    }
}