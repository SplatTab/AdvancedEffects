<img alt="GitHub all releases" src="https://img.shields.io/github/downloads/SplatTab/AdvancedEffects/total">
<img alt="GitHub release (latest by date)" src="https://img.shields.io/github/v/release/SplatTab/AdvancedEffects">

# AdvancedEffects
A plugin that allows you to customize everything about effects

## Features
1. Make item's give effects and remove them!
1. Give effects on damage!
1. Change effect intesity based on armor!
1. Highly modifable configuration!

## Config
```
advanced_effects:
  # Effects to add on item used[ItemType:EffectValues]
  effects_on_use:
    SCP018:
    - effect: SeveredHands
      duration: 0
      chance: 100
  # Effects to remove on item used [ItemType:EffectType
  effects_lost_on_use:
    Painkillers:
    - Concussed
    Medkit:
    - Poisoned
    Adrenaline:
    - Disabled
    SCP500:
    - Amnesia
    - Concussed
    - Poisoned
  # Effects to add on damage[DamageType:EffectValues]
  effects_on_damage:
    Falldown:
    - effect: Disabled
      duration: 15
      chance: 100
  # Items that when in inventory will apply a effect reduction [ItemType:IntesityMultiplier]
  effect_reducers:
    ArmorHeavy: 0.8
```

## ComingSoon/Todo
1. Add more options for when to add effects (ex. On Shooting, On entering a certain area, Certain In game events)
1. Think of more Todos then do the todos
1. Update to Exiled 5
