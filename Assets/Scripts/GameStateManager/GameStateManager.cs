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
        _CurrentState = MainMenu;
        CustomerFactories = transform.GetComponents<CustomerFactory>();
    }



    public void ChangeState(GameState newState)
    {
        _CurrentState?.ExitState(this);
        _CurrentState = newState;
        _CurrentState?.EnterState(this);
    }
}
