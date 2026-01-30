using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    private static GameStateManager Instance_;
    public GameStateManager GetInstance() {  return Instance_; }

    private GameState _CurrentState;
    public Round Round = new Round();
    public MainMenu MainMenu = new MainMenu();

    public CustomerFactory[] CustomerFactories;


    private void Awake()
    {
        ChangeState(Round);
        CustomerFactories = transform.GetComponents<CustomerFactory>();
    }


    private void Update()
    {
        _CurrentState.UpdateState(this);
    }

    public void ChangeState(GameState newState)
    {
        _CurrentState?.ExitState(this);
        _CurrentState = newState;
        _CurrentState?.EnterState(this);
    }
}
