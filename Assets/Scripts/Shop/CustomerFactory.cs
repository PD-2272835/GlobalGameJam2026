using UnityEngine;

public class CustomerFactory : MonoBehaviour
{
    [SerializeField] private CustomerBehaviour Customer;

    public CustomerBehaviour CreateCustomer(Vector3 startPos, Vector3 endPos)
    {
        var customerInstance = Instantiate(Customer, startPos, Quaternion.identity);
        customerInstance.SetTarget(endPos);

        return customerInstance;
    }
}
