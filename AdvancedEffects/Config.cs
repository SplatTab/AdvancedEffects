using System.ComponentModel;
using System.Collections.Generic;
using Exiled.API.Interfaces;
using Exiled.API.Enums;
using AdvancedEffects.Structs;

namespace AdvancedEffects
{
    public sealed class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled on this server.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Effects to add on item used[ItemType:EffectValues]")]
        public Dictionary<ItemType, List<CustomEffect>> EffectsOnUse { get; set; } = new Dictionary<ItemType, List<CustomEffect>>()
        {
            {
                ItemType.SCP018, new List<CustomEffect>
                {
                    new CustomEffect
                    {
                        Effect = EffectType.Ensnared,
                        Chance = 20
                    }
                }
            }
        };

        [Description("Effects to remove on item used [ItemType:EffectType")]
        public Dictionary<ItemType, List<EffectType>> EffectsLostOnUse { get; set; } = new Dictionary<ItemType, List<EffectType>>()
        {
            {
                ItemType.Painkillers, new List<EffectType>
                {
                    EffectType.Concussed
                }
            },
            {
                ItemType.Medkit, new List<EffectType>
                {
                    EffectType.Poisoned
                }
            },
            {
                ItemType.Adrenaline, new List<EffectType>
                {
                    EffectType.Disabled
                }
            },
            {
                ItemType.SCP500, new List<EffectType>
                {
                    EffectType.Amnesia, EffectType.Concussed, EffectType.Poisoned
                }
            }
        };

        [Description("Effects to add on damage[DamageType:EffectValues]")]
        public Dictionary<DamageType, List<CustomEffect>> EffectsOnDamage { get; set; } = new Dictionary<DamageType, List<CustomEffect>>()
        {
            {
                DamageType.Falldown, new List<CustomEffect>
                {
                    new CustomEffect
                    {
                        Effect = EffectType.Disabled,
                        Duration = 15,
                        Chance = 100,
                    }
                }
            }
        };

        [Description("Items that when in inventory will apply a effect reduction [ItemType:IntesityMultiplier]")]
        public Dictionary<ItemType, float> EffectReducers { get; set; } = new Dictionary<ItemType, float>()
        {
            {
                ItemType.ArmorHeavy, 0.8f
            }
        };
    }
}