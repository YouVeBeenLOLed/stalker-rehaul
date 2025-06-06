﻿namespace Content.Server._Stalker.Anomaly.Effects.GenericVisualizer;

[RegisterComponent]
public sealed partial class STAnomalyGenericVisualizerEffectComponent : Component
{
    [DataField]
    public Dictionary<string, STAnomalyGenericVisualizerEffectOptions> Options = new();
}

[Serializable, DataDefinition]
public partial struct STAnomalyGenericVisualizerEffectOptions
{
    [DataField]
    public string State;
}

[Serializable]
public enum STAnomalyGenericVisualizerEffectVisuals
{
    Layer,
}
