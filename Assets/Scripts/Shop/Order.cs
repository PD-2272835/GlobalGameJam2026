using UnityEngine;

public class Order
{
    private Mask _Mask;
    private int _CorrectMaskComponentPrice_;
    private int _IncorrectMaskComponentPenalty;

    private float _TimeLimit;

    public Mask GetMask() { return _Mask; }

}
