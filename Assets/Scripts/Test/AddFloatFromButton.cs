using Utils;

namespace Test
{
    public class AddFloatFromButton : ButtonHandler
    {
        public FloatProperty prop;
        public float addValue;
        
        protected override void OnClick() => prop.Value += addValue;
    }
}