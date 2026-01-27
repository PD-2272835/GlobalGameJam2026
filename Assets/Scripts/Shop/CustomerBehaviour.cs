using NUnit.Framework.Constraints;
using System.Collections;
using UnityEngine;
using TMPro;

public class CustomerBehaviour : MonoBehaviour, IOrderTeller
{
    [SerializeField] private string Greeting_;
    [SerializeField] private string Enquiry_; //"I would like a", "Can I have a"
    [SerializeField] private Order MaskOrder_;

    public TextMeshProUGUI DialogTMP;



    public void TellOrder()
    {
        StartCoroutine(ReciteOrder());
    }

    private IEnumerator ReciteOrder()
    {
        DialogTMP.text = Greeting_;
        yield return new WaitForSeconds(0.2f);
        DialogTMP.text = Enquiry_;
    }
}
