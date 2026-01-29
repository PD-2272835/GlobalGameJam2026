using System.Collections;
using TMPro;
using UnityEngine;


public class CustomerBehaviour : MonoBehaviour, IOrderTeller
{
    [SerializeField] private string _Greeting;
    [SerializeField] private string[] _Enquiry; //"I would like a", "Can I have a" - {0} for mask colour {1} for mask pattern {2} for mask accessory
    [SerializeField] private Order _MaskOrder;
    [SerializeField] private float _TimeBetweenStatements = 0;
    [SerializeField] private float _Speed = 5f;
    private Vector3 _TargetPosition;

    public TextMeshProUGUI SpeechBubble; //TODO: need to implement this speech bubble thingy

    
    void FixedUpdate()
    {
       if (_TargetPosition != Vector3.zero)
       {
           if(transform.position.y <= _TargetPosition.y)
           {
               WalkTo(_TargetPosition);
           }
           else { _TargetPosition = Vector3.zero; }
       }     
    }

    public void WalkTo(Vector3 target)
    {
        Vector3 direction = (transform.position - target).normalized;
        transform.position += (direction * _Speed * Time.deltaTime);
    }

    public void TellOrder()
    {
        StartCoroutine(ReciteOrder());
    }

    private IEnumerator ReciteOrder()
    {
        var orderMask = _MaskOrder.GetMask();
        SpeechBubble.text = _Greeting;
        yield return new WaitForSeconds(0.2f);
        for (int i = 0; i < _Enquiry.Length; i++)
        {
            SpeechBubble.text = string.Format(_Enquiry[i], orderMask.GetColourName(), orderMask.GetPatternName(), orderMask.GetAccessoryName());
            yield return new WaitForSeconds(_TimeBetweenStatements);
        }
    }


}
