using UnityEngine;

public struct MaskAttribute
{
    public string AttributeName;
    public Sprite AttributeSprite;

    public override string ToString() {  return AttributeName; }
}



public class Mask : MonoBehaviour, IRandomCreatable
{
    //Masks have three attributes
    private Color Colour_;
    private MaskAttribute Pattern_;
    private MaskAttribute Accessory_;

    public void CreateRandom()
    {
        ///Colour_
    }

    //Setters
    public void SetColour(Color colour) => Colour_ = colour;
    public void SetPattern(MaskAttribute pattern) => Pattern_ = pattern;
    public void SetAccessory(MaskAttribute accessory) => Accessory_ = accessory;


    //Getters
    //Get this mask's raw attributes
    public Color GetColour() => Colour_;
    public MaskAttribute GetPattern() => Pattern_;
    public MaskAttribute GetAccessory() => Accessory_;

    //Get names of mask's attributes
    public string GetColourName() { return Colour_.ToString(); }
    public string GetPatternName() { return Pattern_.ToString(); }
    public string GetAccessoryName() { return Accessory_.ToString(); }
}
