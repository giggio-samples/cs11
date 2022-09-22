namespace CSharp11;

public readonly struct StructsInitialize
{
    //public StructsInitialize() { } // uncomment for output to change to "0 (Ordinary measurement)"
    public StructsInitialize(double value) => Value = value;
    public StructsInitialize(double value, string description)
    {
        Value = value;
        Description = description;
    }
    public StructsInitialize(string description) => Description = description;

    public double Value { get; init; }
    public string Description { get; init; } = "Ordinary measurement";
    public override string ToString() => $"{Value} ({Description})";
}
