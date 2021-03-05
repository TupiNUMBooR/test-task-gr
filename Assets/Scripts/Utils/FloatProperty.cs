using UnityEngine;

namespace Utils
{
    public class FloatProperty : AbstractProperty<float>
    {
        public override bool IsEqual(float v)
        {
            return Mathf.Abs(Value - v) <= Mathf.Abs(Value * 1e-6f);
        }
    }
}