using UnityEngine;

public abstract class GameState
{
    public abstract void EnterState(GameStateManager context);
    public abstract void UpdateState(GameStateManager context);
    public abstract void ExitState(GameStateManager context);
}
