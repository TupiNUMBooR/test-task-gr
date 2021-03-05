using UnityEngine;
using Utils;

namespace Test
{
    public class AutoDestroy : MonoBehaviour
    {
        public FloatProperty destroyDistance;
        public Transform target;

        void FixedUpdate()
        {
            var sqDist = (target.position - transform.position).sqrMagnitude;
            if (sqDist > destroyDistance.Value * destroyDistance.Value) Destroy(gameObject);
        }
    }
}