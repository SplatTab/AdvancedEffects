using Exiled.API.Features;
using System;
using Player = Exiled.Events.Handlers.Player;

namespace AdvancedEffects
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Singleton;
        public EventHandlers EventHandlers;
        public override string Author => "SplatTab";
        public override string Name => "AdvancedEffects";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(3, 0, 0);

        public override void OnEnabled()
        {
            Singleton = this;
            EventHandlers = new EventHandlers(this);
            Player.ItemUsed += EventHandlers.OnItemUsed;
            Player.Hurting += EventHandlers.OnDamage;
            Player.ReceivingEffect += EventHandlers.OnAddEffect;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.ItemUsed -= EventHandlers.OnItemUsed;
            Player.Hurting -= EventHandlers.OnDamage;
            Player.ReceivingEffect -= EventHandlers.OnAddEffect;
            Singleton = null;
            EventHandlers = null;
            base.OnDisabled();
        }
    }
}