using UnityEngine;

public abstract class MaskAttribute
{
    public string AttributeName;
    public Sprite AttributeSprite;

    public override string ToString() {  return AttributeName; }
}


public class MaskPattern : MaskAttribute, IRandomCreatable
{
    public void CreateRandom()
    {

    }
}

public class MaskAccessory : MaskAttribute, IRandomCreatable
{
    public void CreateRandom()
    {

    }
}


public class Mask : IRandomCreatable
{
    //Masks have three attributes
    private Color _Colour;
    private MaskAttribute _Pattern;
    private MaskAttribute _Accessory;

    public void CreateRandom()
    {
        _Colour = Random.ColorHSV();
        _Pattern = new MaskPattern();
        _Accessory = new MaskPattern();
    }

    //Setters
    public void SetColour(Color colour) => _Colour = colour;
    public void SetPattern(MaskAttribute pattern) => _Pattern = pattern;
    public void SetAccessory(MaskAttribute accessory) => _Accessory = accessory;


    //Getters
    //Get this mask's raw attributes
    public Color GetColour() => _Colour;
    public MaskAttribute GetPattern() => _Pattern;
    public MaskAttribute GetAccessory() => _Accessory;

    //Get names of mask's attributes
    public string GetColourName() { return _Colour.ToString(); }
    public string GetPatternName() { return _Pattern.ToString(); }
    public string GetAccessoryName() { return _Accessory.ToString(); }
}
