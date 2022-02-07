using Exiled.Events.EventArgs;
using Exiled.API.Enums;
using System.Collections.Generic;
using AdvancedEffects.Structs;
using UnityEngine;
using Exiled.API.Features.Items;

namespace AdvancedEffects
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        public void OnItemUsed(UsedItemEventArgs ev)
        {
            if (plugin.Config.EffectsOnUse.TryGetValue(ev.Item.Type, out List<CustomEffect> EffectsToAdd))
                for (int i = 0; i < EffectsToAdd.Count; i++)
                    if (EffectsToAdd[i].Chance > Random.Range(0, 100))
                        ev.Player.EnableEffect(EffectsToAdd[i].Effect, EffectsToAdd[i].Duration);

            if (plugin.Config.EffectsLostOnUse.TryGetValue(ev.Item.Type, out List<EffectType> EffectsToRemove))
                ev.Player.DisableEffects(EffectsToRemove);
        }

        public void OnDamage(HurtingEventArgs ev)
        {
            if (plugin.Config.EffectsOnDamage.TryGetValue(ev.Handler.Type, out List<CustomEffect> EffectsToAdd))
                for (int i = 0; i < EffectsToAdd.Count; i++)
                    if (EffectsToAdd[i].Chance > Random.Range(0, 100))
                        ev.Target.EnableEffect(EffectsToAdd[i].Effect, EffectsToAdd[i].Duration);
        }

        public void OnAddEffect(ReceivingEffectEventArgs ev)
        {
            foreach (ItemType item in plugin.Config.EffectReducers.Keys)
                if (ev.Player.HasItem(new Item(item)) & plugin.Config.EffectReducers.TryGetValue(item, out float value))
                    ev.Effect.Intensity = (byte)(ev.Effect.Intensity * value);
        }
    }
}
