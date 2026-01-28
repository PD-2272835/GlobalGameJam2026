using UnityEngine;

public struct MaskAttribute
{
    public string AttributeName;
    public Sprite AttributeSprite;

    public override string ToString() {  return AttributeName; }
}



public class Mask : MonoBehaviour
{

    private Color Colour_;
    private MaskAttribute Pattern_;
    private MaskAttribute Accessory_;

    private SpriteRenderer[] SpriteRenderers_; //0: pattern 1: Accessory

    private void Awake()
    {
        SpriteRenderers_ = GetComponentsInChildren<SpriteRenderer>();
    }


    public void SetColour(Color colour)
    {
        Colour_ = colour;
        SpriteRenderers_[0].color = Colour_;
    }


    public void SetPattern(MaskAttribute pattern)
    {
        Pattern_ = pattern;
        SpriteRenderers_[0].sprite = Pattern_.AttributeSprite;
    }


    public void SetAccessory(MaskAttribute accessory)
    {
        Accessory_ = accessory;
        SpriteRenderers_[1].sprite = Accessory_.AttributeSprite;
    }



    public string GetColourName() { return Colour_.ToString(); }
    public string GetPatternName() { return Pattern_.ToString(); }
    public string GetAccessoryName() { return Accessory_.ToString(); }
}
