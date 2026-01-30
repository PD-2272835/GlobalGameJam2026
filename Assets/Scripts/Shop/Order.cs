using UnityEngine;

public class Order
{
    private Mask _Mask;
    private CustomerBehaviour _Customer;
    private int _CorrectMaskComponentPrice;
    private int _IncorrectMaskComponentPenalty;
    private float _TimeLimit;


    public Order(int correctPrice, int incorrectPrice, float timeLimit)
    {
        _Mask = new Mask();
        _Mask.CreateRandom();
        _CorrectMaskComponentPrice = correctPrice;
        _IncorrectMaskComponentPenalty = incorrectPrice;
        _TimeLimit = timeLimit;
    }
    
    
    public Mask GetMask() { return _Mask; }
    public CustomerBehaviour GetCustomer() { return _Customer; }
}
