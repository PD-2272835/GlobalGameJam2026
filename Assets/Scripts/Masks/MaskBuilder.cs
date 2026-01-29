using UnityEngine;

public class MaskBuilder : MonoBehaviour
{
    public MaskBehaviour maskBehaviour;

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

    public void SetPattern(int patternID)
    {
        //
    }

    public void SetAccessory(int accessoryID)
    {
        //
    }
}
