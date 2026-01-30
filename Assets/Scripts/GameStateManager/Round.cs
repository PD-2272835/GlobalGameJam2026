using UnityEngine;

public class Round : GameState
{
    //this should be the client for the customer factory and will manage customers entering/leaving the shop.
    CustomerBehaviour CurrentCustomer;
    Vector3 CustomerSpawnPoint;
    Vector3 CustomerOrderPoint;


    public override void EnterState(GameStateManager context)
    {
        CurrentCustomer = null;
        CustomerSpawnPoint = new Vector3(-10f, -0.5f);
        CustomerOrderPoint = new Vector3(-4.5f, -0.5f);
    }

    public override void ExitState(GameStateManager context)
    {
        
    }

    public override void UpdateState(GameStateManager context)
    {
        if (CurrentCustomer == null)
        {
            CurrentCustomer = context.CustomerFactories[Random.Range(0, context.CustomerFactories.Length)].CreateCustomer(CustomerSpawnPoint, CustomerOrderPoint);
        }

    }
}
