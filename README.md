# Low VFX mod

This is a Slay the Spire 2 mod that disables some flashy visual effects:

- generic attack

- some specific attacks:

  - "big slash" - Perfected Strike, Sovereign Blade, Mecha Knight, ...

  - "large magic missile" - Bombardment, Meteor Strike, ...

  - "small magic missile" - Comet, Guiding Star, ...

  - "scratch" - Claw, Maul, Rip and Tear, ...

  - "gaseous impact" - a part of Bouncing Flask, Deadly Poison, ...

  - Sweeping Beam

  - Minion Dive Bomb (known issue: the minion gets stuck on the player character)

- the "cosmic swords/daggers" effect that appears above the Regent for a moment when playing an attack

- card transformations

- smithing at rest sites

## Installing

Download `LowVFX.zip` from the latest release and extract it in your mods folder:

- Linux: `~/.local/share/Steam/steamapps/common/Slay the Spire 2/mods`

- Windows: `C:/Program Files (x86)/Steam/steamapps/common/Slay the Spire 2/mods/`

This mod depends on [BaseLib](https://github.com/Alchyr/BaseLib-StS2), so you'll need to install that too if you haven't already

To build from source, install .NET 9 SDK, then run `dotnet build`. This should also automatically install the mod
