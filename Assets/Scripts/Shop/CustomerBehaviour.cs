using System.Collections;
using TMPro;
using UnityEngine;


public class CustomerBehaviour : MonoBehaviour, IOrderTeller
{
    [SerializeField] private string _Greeting;
    [SerializeField] private string[] _Enquiry; //"I would like a", "Can I have a" - {0} for mask colour {1} for mask pattern {2} for mask accessory
    [SerializeField] private float _TimeBetweenStatements = 0;
    [SerializeField] private float _Speed = 2f;
    private Vector3 _TargetPosition;

    [SerializeField] private Order _MaskOrder;
    [SerializeField] private int _ComponentPrice = 10;
    [SerializeField] private int _IncorrectComponentPenalty = 10;
    [SerializeField] private float _Patience = 7;

    [SerializeField] private TextMeshProUGUI _SpeechBubble; //TODO: need to implement this speech bubble thingy
    [SerializeField] private GameObject _SpeechCanvas;

    private bool hasOrdered = false;

    private void Awake()
    {
        _MaskOrder = new Order(_ComponentPrice, _IncorrectComponentPenalty, _Patience);
    }


    void FixedUpdate()
    {
        if (_TargetPosition != Vector3.zero)
        {
            if (transform.position.x <= _TargetPosition.x)
            {
                WalkTo(_TargetPosition);
            }
            else { _TargetPosition = Vector3.zero; }
        } else if (!hasOrdered)
        {
            hasOrdered = true;
            TellOrder();
        }
        
    }


    public void WalkTo(Vector3 target)
    {   
        Vector3 direction = (target - transform.position).normalized;
        transform.Translate(_Speed * Time.deltaTime * direction, Space.World);
    }

    public void TellOrder()
    {
        _SpeechCanvas.gameObject.SetActive(true);
        StartCoroutine(ReciteOrder());
    }

    private IEnumerator ReciteOrder()
    {
        var orderMask = _MaskOrder.GetMask();
        _SpeechBubble.text = _Greeting;
        yield return new WaitForSeconds(0.2f);
        for (int i = 0; i < _Enquiry.Length; i++)
        {
            _SpeechBubble.text = string.Format(_Enquiry[i], orderMask.GetColourName(), orderMask.GetPatternName(), orderMask.GetAccessoryName());
            yield return new WaitForSeconds(_TimeBetweenStatements);
        }
        yield return new WaitForSeconds(0.5f);
        _SpeechCanvas.gameObject.SetActive(false);
    }

    public void SetTarget(Vector3 newTarget) => _TargetPosition = newTarget;
}
