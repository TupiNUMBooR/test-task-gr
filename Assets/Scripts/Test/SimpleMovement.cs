using UnityEngine;
using Utils;

namespace Test
{
    public class SimpleMovement : MonoBehaviour
    {
        public FloatProperty speed;
        
        void FixedUpdate()
        {
            transform.position += speed.Value * Time.deltaTime * Vector3.forward;
        }
    }
}