using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    private static GameStateManager Instance_;
    public GameStateManager GetInstance() {  return Instance_; }

    private GameState CurrentState_;
    public Round Round = new Round();
    public MainMenu MainMenu = new MainMenu();


    private void Awake()
    {
        CurrentState_ = MainMenu;
    }



    public void ChangeState(GameState newState)
    {
        CurrentState_?.ExitState(this);
        CurrentState_ = newState;
        CurrentState_?.EnterState(this);
    }
}
