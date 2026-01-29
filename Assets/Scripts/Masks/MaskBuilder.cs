using JetBrains.Annotations;
using UnityEngine;

public class MaskBuilder : MonoBehaviour
{
    public MaskBehaviour maskBehaviour;

    private int patternID = 0;
    private int accessoryID = 0;

    public void SetColour(int colourID)
    {
        Color colour = Color.white;
        switch (colourID)
        {
            case 0:
                colour = Color.white;
                break;
            case 1:
                colour = Color.red;
                break;
            case 2:
                colour = Color.purple;
                break;
            case 3:
                colour = Color.pink;
                break;
            case 4:
                colour = Color.grey;
                break;
            case 5:
                colour = Color.green;
                break;
            case 6:
                colour = Color.darkBlue;
                break;
            case 7:
                colour = Color.blue;
                break;
        }

        maskBehaviour.SetColour(colour);
    }

    public void ScrollPattern()
    {
        MaskAttribute pattern;

        patternID++;
        if (patternID >= 9)
        {
            patternID = 0;
        }

        switch (patternID)
        {
            case 0:
                ///pattern = trim blue
                break;
            case 1:
                ///pattern = trim dark blue
                break;
            case 2:
                ///pattern = trim green
                break;
            case 3:
                ///pattern = trim grey
                break;
            case 4:
                ///pattern = trim orange
                break;
            case 5:
                ///pattern = trim pink
                break;
            case 6:
                ///pattern = trim purple
                break;
            case 7:
                ///pattern = trim red
                break;
            case 8:
                ///pattern = trim silver
                break;
        }

        ///maskBehaviour.SetPattern(pattern);
    }

    public void ScrollAccessory()
    {
        MaskAttribute accessory;

        accessoryID++;
        if (accessoryID >= 9)
        {
            accessoryID = 0;
        }

        switch (accessoryID)
        {
            case 0:
                ///accessory = none
                break;
            case 1:
                ///accessory = feathers blue
                break;
            case 2:
                ///accessory = feathers green
                break;
            case 3:
                ///accessory = feathers grey
                break;
            case 4:
                ///accessory = feathers orange
                break;
            case 5:
                ///accessory = feathers pink
                break;
            case 6:
                ///accessory = feathers purple
                break;
            case 7:
                ///accessory = feathers red
                break;
            case 8:
                ///accesssory = feathers white
                break;
        }

        ///maskBehaviour.SetAccessory(accessory);
    }

    public void ResetMask()
    {
        SetColour(0);
        ///maskBehaviour.SetPattern(default);
        ///maskBehaviour.SetAccessory(none);
    }
}
