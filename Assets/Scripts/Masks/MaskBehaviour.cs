using UnityEngine;

public class MaskBehaviour : MonoBehaviour
{
    public Mask MaskHolder;
    private SpriteRenderer[] SpriteRenderers_; //0: Pattern 1: Accessory

    private void Awake()
    {
        SpriteRenderers_ = GetComponentsInChildren<SpriteRenderer>();
    }

    public void SetColour(Color colour)
    {
        MaskHolder.SetColour(colour);
        SpriteRenderers_[0].color = MaskHolder.GetColour();
    }


    public void SetPattern(MaskAttribute pattern)
    {
        MaskHolder.SetPattern(pattern);
        SpriteRenderers_[0].sprite = MaskHolder.GetPattern().AttributeSprite;
    }


    public void SetAccessory(MaskAttribute accessory)
    {
        MaskHolder.SetPattern(accessory);
        SpriteRenderers_[1].sprite = MaskHolder.GetAccessory().AttributeSprite;
    }
}
