using Exiled.API.Enums;

namespace AdvancedEffects.Structs
{
    public struct CustomEffect
    {
        public CustomEffect(EffectType effect, float duration, byte intensity, float chance)
        {
            Effect = effect;
            Duration = duration;
            Chance = chance;
        }
        public EffectType Effect { get; set; }
        public float Duration { get; set; }
        public float Chance { get; set; }
    }
}
